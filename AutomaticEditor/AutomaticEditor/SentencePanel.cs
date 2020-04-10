using GrammarBotClient;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using Microsoft.Office.Interop.Word;
using System.Windows.Forms;

namespace AutomaticEditor
{
    public partial class SentencePanel : UserControl
    {
        public delegate void ErrorResolved();
        public static Document currentDocument;

        private Queue<Matches> errorQ = new Queue<Matches>();                                    // errorList is a queue of all the errors in the currentDocument
        private Matches nextMatch;
        private int offset, charCount;
        private string editedSentence;

        public SentencePanel(Document currentDoc)
        {
            currentDocument = currentDoc;
            InitializeComponent();

            RunGrammarbot();
            StartEdit.Enabled = true;
        }

        private
        void RejectEdit_Click(object sender, EventArgs e)
        {
            GetNextError();

        }

        private void ApplyEdit_Click(object sender, EventArgs e)
        {
            string errString = nextMatch.Sentence.Substring(offset, charCount);

            nextMatch.Sentence.Replace(errString, nextMatch.replacements[0].Value);

            GetNextError();
        }
        
    #region Setters and Getters
        public void SetErrorMessage(string errorMessage)
        {
            ErrorMessage.Text = errorMessage;
            return;
        }

        public void SetOriginalSentence(string sentence)
        {
            OriginalSentence.Text = sentence;
            return;
        }

        public string GetOriginalSentence()
        {
            return OriginalSentence.Text;
        }

        public void SetEditedSentence(string sentence)
        {
            EditedSentence.Text = sentence;
            return;
        }

        public string GetEditedSentence()
        {
            return EditedSentence.Text;
        }
    #endregion

        private void StartEdit_Click(object sender, EventArgs e)
        {
            // Get the first error
            GetNextError();

            StartEdit.Enabled = false;
            StartEdit.Visible = false;
            RejectEdit.Enabled = true;
            ApplyEdit.Enabled = true;
        }

        private Matches GetNextError()
        {
            nextMatch = errorQ.Dequeue();

            SetErrorMessage(nextMatch.Message.ToString());
            SetOriginalSentence(nextMatch.Sentence.ToString());

            offset = (int)nextMatch.offset;
            charCount = (int)nextMatch.Length;
            editedSentence = nextMatch.Sentence.Remove(offset, charCount);
            editedSentence = editedSentence.Insert(offset, nextMatch.replacements[0].Value.ToString());
            SetEditedSentence(editedSentence);

            // Move the document to the relevant text
            currentDocument.Content.Find.Execute(FindText: nextMatch.Sentence.Remove(20).ToString());

            // Select the error in the original sentence textbox
            OriginalSentence.Select(offset, charCount);

            return nextMatch;
        }

        #region GrammarBot

        public void RunGrammarbot()
        {
            foreach (Paragraph para in currentDocument.Paragraphs)
            {
                foreach (Range sentence in para.Range.Sentences)
                {
                    CheckAsync(sentence);

                }
            }

            return;
        }

        // This method handles the errors in one sentence
        private async void CheckAsync(Range currentRange)
        {
            GrammarBotClient.GrammarBot grammarBot = new GrammarBotClient.GrammarBot(new GrammarBotClient.ApiConfig());
            //string editedSentence;
            //int offset, charCount;
            GrammarBotClient.Matches error;

            try
            {
                var grammar = await grammarBot.CheckAsync(currentRange.Text);

                if (grammar.Success)
                {
                    try
                    {
                        for (int i = 0; i < grammar.CheckContent.Matches.Count; i++)
                        {
                            // Each "error" describes one error in a sentence
                            error = grammar.CheckContent.Matches[i];

                            // Add the current error to the error queue
                            errorQ.Enqueue(error);

                            // If it is not a valid error type, skip this 'item'
                            if (!IsErrorValid(error)) continue;

                            //sentences.SetErrorMessage(error.Message.ToString());
                            //sentences.SetOriginalSentence(error.Sentence.ToString());

                            //offset = (int)error.offset;
                            //charCount = (int)error.Length;
                            //editedSentence = error.Sentence.Remove(offset, charCount);
                            //editedSentence = editedSentence.Insert(offset, error.replacements[0].Value.ToString());
                            //sentences.SetOriginalSentence(editedSentence);

                            //rngStart = currentRange.Sentences[numSentence].Start + item.offset;
                            //rngEnd = rngStart + item.Length;

                            //rng = currentDocument.Range(rngStart, rngEnd);
                            //rng.HighlightColorIndex = WdColorIndex.wdDarkYellow;

                            // If there are any suggested replacements, show the first one in a Comment
                            //if (item.replacements.Count > 0)
                            //{
                            //    // Add highlight and comment
                            //    currentDocument.Comments.Add(rng, item.replacements[0].Value.ToString() + "\nrng.Start: " + rng.Start.ToString() + "\nerror: " + item.Message);

                            //    // Replace an error with its suggested correction
                            //    ReplaceText(rng, item.replacements[0].Value.ToString());
                            //}
                        }
                    }
                    catch (Exception EX)
                    {
                        MessageBox.Show(EX.ToString());

                        // Add an error comment
                        Range errRng = currentDocument.Range(0, 1);
                        currentDocument.Comments.Add(errRng, "EXCEPTION! \n\n" + EX.ToString());
                    }
                }
                else
                {
                    Console.WriteLine(grammar.Message);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.ToString());

                // Add an error comment
                Range errRng = currentDocument.Range(0, 1);
                currentDocument.Comments.Add(errRng, "GrammarBot EXCEPTION! \n\n" + EX.ToString());
            }

            return;
        }

        // This method returns 'false' if it is an error type that I do NOT want checked
        private bool IsErrorValid(GrammarBotClient.Matches item)
        {
            String activeSentence = item.Sentence;

            if (item.Sentence.StartsWith("%")) return false;                                // if the sentence starts with the LaTex '%,' ignore it.
            if (item.Sentence.IndexOf("(") == item.offset) return false;                    // if the error starts with a '(,' ignore it.

            // Reject any error with sub- or superscript formatting
            Range error = currentDocument.Range(item.offset + 4, item.offset + 4);
            if (error.Font.Subscript == -1 || error.Font.Superscript == -1) return false;               // -1 means True
            if (error.Font.Subscript == 9999999 || error.Font.Superscript == 9999999) return false;     // means "undefined," a mixture of True and False

            // If it's a spelling error, check if the error text is in all caps, as in: it's an abbreviation
            // This must be the last check; if it returns true (not all caps), nothing after it will get checked.
            if (item.Message.StartsWith("Possible spelling"))
            {
                int capCount = 0;
                for (int i = 0; i < item.Length - 1; i++)
                {
                    // Check if each char is a capital and increment the count
                    if (activeSentence[(int)item.offset + i].ToString() == activeSentence[(int)item.offset + i].ToString().ToUpper()) capCount++;
                }

                if (capCount == item.Length - 1) return false;                                          // it was all caps, so probably an abbreviation
            }

            return true;
        }

        private void ReplaceText(Range localCurrentRange, string replacement)
        {
            int stringLength = localCurrentRange.End - localCurrentRange.Start;

            localCurrentRange.Delete(WdUnits.wdCharacter, stringLength);
            localCurrentRange.SetRange(localCurrentRange.Start, localCurrentRange.Start);
            localCurrentRange.InsertAfter(replacement);

            return;
        }

        #endregion
    }
}
