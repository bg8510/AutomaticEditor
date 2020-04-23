﻿using GrammarBotClient;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AutomaticEditor
{
    public partial class SentencePanel : UserControl
    {
        public delegate void ErrorResolved();
        public static Document currentDocument;

        public struct Error
        {
            public Matches match;
            public Range paraRange;
            public int fullOffset;

            public int Compare(Error a, Error b) 
            {
                if (a.fullOffset > b.fullOffset) return 1;
                if (a.fullOffset < b.fullOffset) return -1;
                return 0;
            }
        };
        private Error nextMatch;
        private List<Error> errorL = new List<Error>();                            // errorL is a List<> of all the Error structs for the currentDocument to be sorted into a queue
        private Queue<Error> errorQ = new Queue<Error>();                          // errorQ is a Queue<> of all the Error structs for the currentDocument

        private int sentenceOffset, charCount;  // fullOffset;
        private string editedSentence;
        private Range errorRange;

        public SentencePanel(Document currentDoc)
        {
            currentDocument = currentDoc;
            InitializeComponent();

            RunGrammarbot();
            StartEdit.Enabled = true;
        }

        private void RejectEdit_Click(object sender, EventArgs e)
        {
            GetNextError();
        }

        private void ApplyEdit_Click(object sender, EventArgs e)
        {
            string errString = nextMatch.match.replacements[0].Value;
            errorRange = currentDocument.Range(nextMatch.fullOffset, nextMatch.fullOffset + charCount);

            errorRange.Text = errString;

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
            // Sort the List of Error structs
            errorL.Sort((M1, M2) => M1.Compare(M1, M2));

            // Create a Queue<Error> from the sorted List<Error>
            for (int i = 0; i < errorL.Count; i++)
            {
                errorQ.Enqueue(errorL[i]);
            }

            // Get the first error
            
            GetNextError();

            StartEdit.Enabled = false;
            StartEdit.Visible = false;
            RejectEdit.Enabled = true;
            ApplyEdit.Enabled = true;
        }

        private Error GetNextError()
        {
            if (errorQ.Count > 0)
            {
                nextMatch = errorQ.Dequeue();
            }
            else  // It's finished with all the errors in the queue, so start spellchecker and grammar checker
            {
                this.Visible = false;
                object optional = Missing.Value;
                currentDocument.CheckSpelling(ref optional, true, true, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);
                currentDocument.CheckGrammar();
            }
            
            try
            {
                if (errorQ.Count > 0) SetErrorMessage(nextMatch.match.Message.ToString());
                else if (errorQ.Count == 0) SetErrorMessage(nextMatch.match.Message.ToString() + "\n \n \n LAST ERROR");

                sentenceOffset = (int)nextMatch.match.offset;
                //fullOffset = nextMatch.paraRange.Start + sentenceOffset;
                charCount = (int)nextMatch.match.Length;
                //editedSentence = nextMatch.match.Sentence.Remove(sentenceOffset, charCount);
                //editedSentence = editedSentence.Insert(sentenceOffset, nextMatch.match.replacements[0].Value);
                
                SetOriginalSentence(nextMatch.match.Sentence.Substring(sentenceOffset, charCount));
                editedSentence = nextMatch.match.replacements[0].Value;
                SetEditedSentence(editedSentence);

                // Select the error in the main text
                currentDocument.Range(nextMatch.fullOffset, nextMatch.fullOffset + charCount).Select();         
            }
            catch (Exception EX)
            {
                //MessageBox.Show(EX.ToString());
            }

            return nextMatch;
        }

        #region GrammarBot

        public void RunGrammarbot()
        {
            //foreach (Paragraph para in currentDocument.Paragraphs)
            for (int p = 1; p <= currentDocument.Paragraphs.Count; p++)
            {
                for (int s = 1; s <= currentDocument.Paragraphs[p].Range.Sentences.Count; s++)
                {
                    //Range myRange = currentDocument.Paragraphs[p].Range;
                    //int myCount = currentDocument.Paragraphs[p].Range.Sentences.Count;
                    //var mySentence = currentDocument.Paragraphs[p].Range.Sentences[s];
                    //string myText = currentDocument.Paragraphs[p].Range.Sentences[s].Text;

                    Range myRange = currentDocument.Range(currentDocument.Paragraphs[p].Range.Sentences[s].Start, currentDocument.Paragraphs[p].Range.Sentences[s].End);

                    CheckAsync(currentDocument.Paragraphs[p].Range.Sentences[s], myRange);
                }
            }

            return;
        }

        // This method handles the errors in one sentence
        private async void CheckAsync(Range currentRange, Range paraRange)
        {
            GrammarBotClient.GrammarBot grammarBot = new GrammarBotClient.GrammarBot(new GrammarBotClient.ApiConfig());
            //string editedSentence;
            //int offset, charCount;
            //GrammarBotClient.Matches error;
            Error currentError;
            currentError.paraRange = paraRange;

            try
            {
                var grammar = await grammarBot.CheckAsync(currentRange.Text);

                if (grammar.Success)
                {
                    try
                    {
                        for (int i = 0; i < grammar.CheckContent.Matches.Count; i++)
                        {
                            // Each "currentError" describes one error in a sentence
                            currentError.match = grammar.CheckContent.Matches[i];
                            currentError.fullOffset = paraRange.Start + (int)grammar.CheckContent.Matches[i].offset;

                            // If it is not a valid error type, skip this 'item'
                            if (!IsErrorValid(currentError.match)) continue;

                            // Add the current error to the error queue
                            errorL.Add(currentError); 

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
                //Range errRng = currentDocument.Range(0, 1);
                //currentDocument.Comments.Add(errRng, "GrammarBot EXCEPTION! \n\n" + EX.ToString());
            }

            return;
        }

        private void OriginalSentence_TextChanged(object sender, EventArgs e)
        {

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

            // Reject this error because it usually means there are equations fooling it into thinking that there's a new sentence.
            if (item.Message.StartsWith("This sentence does not start with an uppercase")) return false;

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

                if (capCount == item.Length || capCount == item.Length - 1) return false;                  // it was all caps, so probably an abbreviation (the -1 is to account for a possible 's' at the end)
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