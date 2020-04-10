using Microsoft.Office.Interop.Word;
using System;
using System.Text.RegularExpressions;
using System.Reflection;
using System.Windows.Forms;
using Office = Microsoft.Office.Core;
using System.Collections.Generic;
using System.Threading.Tasks;
using Task = System.Threading.Tasks.Task;

namespace AutomaticEditor
{
    class Main
    {
        public static readonly Document currentDocument = Globals.ThisAddIn.Application.ActiveDocument;

        public static SentencePanel sentences;
        public Microsoft.Office.Tools.CustomTaskPane sentencePanel;

        // this is a list of th eunicode values for sub- and superscript characters
        //List<int> SubscriptOrSuperscript = new List<int>(){688, 689, 690, 691, 692, 693, 694, 695, 696, 890, 1388, 7468, 7469, 7470, 7471, 7472, 7473, 7474, 7475, 7476, 7477, 7478,
        //                                                7479, 7480, 7481, 7482, 7483, 7484, 7485, 7486, 7487, 7488, 7489, 7490, 7491, 7492, 7493, 7494, 7495, 7496, 7497, 7498, 7499,
        //                                                7500, 7501, 7502, 7503, 7504, 7505, 7506, 7507, 7508, 7509, 7510, 7511, 7512, 7513, 7514, 7515, 7516, 7517, 7518, 7519, 7520,
        //                                                7521, 7522, 7523, 7524, 7525, 7526, 7527, 7528, 7529, 7530, 8305, 8319, 8336, 8337, 8338, 8339, 8340, 8341, 8342, 8343, 8344,
        //                                                8345, 8346, 8347, 8348};

        // Choose the current Selection
        // Range range = Globals.ThisAddIn.Application.Selection.Range;

        #region Start Editing method

        public void StartEditing(String introText, bool isAmericanStyle = true)
        {
            bool result;

            sentences = new SentencePanel(currentDocument);
            sentencePanel = Globals.ThisAddIn.CustomTaskPanes.Add(sentences, "Grammarlin");
            sentencePanel.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionTop;
            DisactivateSentencePanel();

            // Activate track changes
            currentDocument.TrackRevisions = true;
            RevisionsFilter wrdRevisionsFilter = currentDocument.ActiveWindow.View.RevisionsFilter;
            wrdRevisionsFilter.Markup = WdRevisionsMarkup.wdRevisionsMarkupSimple;

            // Set the language version
            if (isAmericanStyle) Globals.ThisAddIn.Application.Selection.Range.LanguageID = WdLanguageID.wdEnglishUS;
            else Globals.ThisAddIn.Application.Selection.Range.LanguageID = WdLanguageID.wdEnglishUK;

            // Call the stringReplacer method for each string that should be changed. Capture the result when necessary and use it to indicate whether the comment has already been made for that issue.
            StringReplacer("What's more", "Also", "“What's more” is too informal for academic writing.");
            
            result = StringReplacer("And ", "", "Avoid using short coordinating conjunctions like “and” and “but” at the beginning of a sentence.");
            result = StringReplacer("But ", "", "Avoid using short coordinating conjunctions like “and” and “but” at the beginning of a sentence.", commentHasBeenMade: result);
            result = StringReplacer("So ", "", "Avoid using short coordinating conjunctions like “and” and “so” at the beginning of a sentence.", commentHasBeenMade: result);
            StringReplacer("Or ", "", "Avoid using short coordinating conjunctions like “but” and “or” at the beginning of a sentence.", commentHasBeenMade: result);

            result = StringReplacer("can't", "cannot", "Avoid using contractions like “can’t” in academic writing.");
            result = StringReplacer("don't", "do not", "Avoid using contractions like “don’t” in academic writing.", commentHasBeenMade: result);
            result = StringReplacer("doesn't", "does not", "Avoid using contractions like “doesn’t” in academic writing.", commentHasBeenMade: result);
            result = StringReplacer("didn't", "did not", "Avoid using contractions like “didn’t” in academic writing.", commentHasBeenMade: result);
            StringReplacer("won't", "will not", "Avoid using contractions like “won’t” in academic writing.", commentHasBeenMade: result);

            result = StringReplacer("utilize", "use", "“Use” is almost always a better word choice than “utilize.”");
            result = StringReplacer("utilizing", "using", "“Using” is almost always a better word choice than “utilizing.”", true, commentHasBeenMade: result);
            StringReplacer("Utilizing", "Using", "“Using” is almost always a better word choice than “utilizing.”", true, commentHasBeenMade: result);   

            // This section is for American grammar and spelling
            if (isAmericanStyle) result = StringReplacer("\", ", ",\" ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.");
            if (isAmericanStyle) result = StringReplacer("\". ", ".\" ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.", commentHasBeenMade: result);
            if (isAmericanStyle) result = StringReplacer("', ", ",' ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.", commentHasBeenMade: result);
            if (isAmericanStyle) StringReplacer("'. ", ".' ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.", commentHasBeenMade: result);
            
            result = StringReplacer("Since", "Because", "In technical writing, the word “since” is reserved for time-related references. To indicate causality, replace “since” with synonyms such as “because.”");
            StringReplacer("since", "because", "In technical writing, the word “since” is reserved for time-related references. To indicate causality, replace “since” with synonyms such as “because.”", commentHasBeenMade: result);

            result = StringReplacer("In order to", "To", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.");
            result = StringReplacer("in order to", "to", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.", commentHasBeenMade: result);
            result = StringReplacer("it is worth noting that ", "", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.", false, commentHasBeenMade: result);
            result = StringReplacer("it should be mentioned that ", "", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.", false, commentHasBeenMade: result);
            result = StringReplacer("All of", "All", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.", true, commentHasBeenMade: result);
            StringReplacer("all of", "all", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.", true);


            result = StringReplacer("Nowadays", "Currently", "“Nowadays” is too informal for academic writing.", true);
            StringReplacer("nowadays", "currently", "“Nowadays” is too informal for academic writing.", true, commentHasBeenMade: result);

            result = StringReplacer("more and more", "increasingly", "“more and more” is too informal for academic writing.", true);
            StringReplacer("More and more", "Increasingly", "“more and more” is too informal for academic writing.", true, commentHasBeenMade: result);

            StringReplacer("huge", "large", "“Huge” is too informal for academic writing.", false);
            
            StringReplacer("Compared to", "Unlike", "Edited for redundancy/wordiness.", true);
            
            StringReplacer("At first", "First", "Edited for redundancy/wordiness.", true);

            StringReplacer("et al. find", "et al. found", "Refer to other studies in the past tense.");

            StringReplacer("et al ", "et al. ", "“al” is an abbreviation and requires a period.");

            StringReplacer("i.e. ", "i.e., ", "“i.e.” requires a comma; it is the same as saying “for example,” and then listing items.", true);

            StringReplacer("by using", "using", "Removed an unnecessary word.", false);

            StringReplacer("indexes", "indices", "“indices” is the correct form and should be used in formal writing, although “indexes” is acceptable in other contexts.", false);

            StringReplacer("is able to", "can", "“is able to” is too wordy", false);

            result = StringReplacer("researches", "studies", "The plural form “researches” is very rarely used. “Studies” is better.", true);
            StringReplacer("Researches", "Studies", "The plural form “researches” is very rarely used. “Studies” is better.", true, commentHasBeenMade: result);

            StringHighlighter("paper");


            //RegexReplacer(@"\w+, \w+ and ", @"\w+, \w+, and ", "In academic writing, insert a comma before the conjunction that precedes the last element of a series (e.g., bread, eggs, and milk).");
            //Spelldoink();

            // Add the chosen introductory comment at the currently selected range
            //currentDocument.Comments.Range.Font.Name = "Calibri";
            currentDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, introText).Range.Font.Name = "Calibri";

            //Spelldoink();

            Globals.ThisAddIn.DisactivateCustomPanel();

            // Make visible the top panel
            ActivateSentencePanel();

            //RunGrammarbot(currentDocument);

            return;
        }

    #endregion
    //#region GrammarBot

    //    private void RunGrammarbot()
    //    {
    //        foreach (Paragraph para in currentDocument.Paragraphs)
    //        {
    //            foreach (Range sentence in para.Range.Sentences)
    //            {
    //                CheckAsync(sentence);
    //            }
    //        }
           
    //        return;
    //    }

    //    // This method handles the errors in one sentence
    //    private async void CheckAsync(Range currentRange)
    //    {
    //        GrammarBotClient.GrammarBot grammarBot = new GrammarBotClient.GrammarBot(new GrammarBotClient.ApiConfig());
    //        //string editedSentence;
    //        //int offset, charCount;
    //        GrammarBotClient.Matches error;
    //        int success;

    //        try
    //        {
    //            var grammar = await grammarBot.CheckAsync(currentRange.Text);

    //            if (grammar.Success)
    //            {
    //                try
    //                {
    //                    for(int i = 0; i < grammar.CheckContent.Matches.Count; i++)
    //                    {
    //                        // Each "error" describes one error in a sentence
    //                        error = grammar.CheckContent.Matches[i];

    //                        // If it is not a valid error type, skip this 'item'
    //                        if (!IsErrorValid(error)) continue;

    //                        // Pass control to the top panel, through the HandleErrorAsync method, and wait
    //                        await HandleErrorAsync(error);

    //                        //sentences.SetErrorMessage(error.Message.ToString());
    //                        //sentences.SetOriginalSentence(error.Sentence.ToString());

    //                        //offset = (int)error.offset;
    //                        //charCount = (int)error.Length;
    //                        //editedSentence = error.Sentence.Remove(offset, charCount);
    //                        //editedSentence = editedSentence.Insert(offset, error.replacements[0].Value.ToString());
    //                        //sentences.SetOriginalSentence(editedSentence);

    //                        //rngStart = currentRange.Sentences[numSentence].Start + item.offset;
    //                        //rngEnd = rngStart + item.Length;

    //                        //rng = currentDocument.Range(rngStart, rngEnd);
    //                        //rng.HighlightColorIndex = WdColorIndex.wdDarkYellow;

    //                        // If there are any suggested replacements, show the first one in a Comment
    //                        //if (item.replacements.Count > 0)
    //                        //{
    //                        //    // Add highlight and comment
    //                        //    currentDocument.Comments.Add(rng, item.replacements[0].Value.ToString() + "\nrng.Start: " + rng.Start.ToString() + "\nerror: " + item.Message);

    //                        //    // Replace an error with its suggested correction
    //                        //    ReplaceText(rng, item.replacements[0].Value.ToString());
    //                        //}
    //                    }
    //                }
    //                catch (Exception EX)
    //                {
    //                    MessageBox.Show(EX.ToString());

    //                    // Add an error comment
    //                    Range errRng = currentDocument.Range(0, 1);
    //                    currentDocument.Comments.Add(errRng, "EXCEPTION! \n\n" + EX.ToString());
    //                }
    //            }
    //            else
    //            {
    //                Console.WriteLine(grammar.Message);
    //            }
    //        }
    //        catch (Exception EX)
    //        {
    //            MessageBox.Show(EX.ToString());

    //            // Add an error comment
    //            Range errRng = currentDocument.Range(0, 1);
    //            currentDocument.Comments.Add(errRng, "GrammarBot EXCEPTION! \n\n" + EX.ToString());
    //        }

    //        return;
    //    }

    //    // This method returns 'false' if it is an error type that I do NOT want checked
    //    private bool IsErrorValid(GrammarBotClient.Matches item)
    //    {
    //        String activeSentence = item.Sentence;

    //        if (item.Sentence.StartsWith("%")) return false;                                // if the sentence starts with the LaTex '%,' ignore it.
    //        if (item.Sentence.IndexOf("(") == item.offset) return false;                    // if the error starts with a '(,' ignore it.

    //        // Reject any error with sub- or superscript formatting
    //        Range error = currentDocument.Range(item.offset + 4, item.offset + 4);
    //        if (error.Font.Subscript == -1 || error.Font.Superscript == -1) return false;               // -1 means True
    //        if (error.Font.Subscript == 9999999 || error.Font.Superscript == 9999999) return false;     // means "undefined," a mixture of True and False

    //        // If it's a spelling error, check if the error text is in all caps, as in: it's an abbreviation
    //        // This must be the last check; if it returns true (not all caps), nothing after it will get checked.
    //        if (item.Message.StartsWith("Possible spelling"))
    //        {
    //            int capCount = 0;
    //            for (int i = 0; i < item.Length - 1; i++)
    //            {
    //                // Check if each char is a capital and increment the count
    //                if (activeSentence[(int)item.offset + i].ToString() == activeSentence[(int)item.offset + i].ToString().ToUpper()) capCount++;
    //            }
                
    //            if (capCount == item.Length - 1) return false;                                          // it was all caps, so probably an abbreviation
    //        }

    //        return true;
    //    }

    //    private void ReplaceText(Range localCurrentRange, string replacement)
    //    {
    //        int stringLength = localCurrentRange.End - localCurrentRange.Start;

    //        localCurrentRange.Delete(WdUnits.wdCharacter, stringLength);
    //        localCurrentRange.SetRange(localCurrentRange.Start, localCurrentRange.Start);
    //        localCurrentRange.InsertAfter(replacement);

    //        return;
    //    }

    //    #endregion

    #region String Replacer method

        /// <summary>
        ///  STRINGREPLACER
        /// </summary>
        /// <param name="find"></param>string: the string to find
        /// <param name="replace"></param>string: the string to replace the found string with
        /// <param name="commentText"></param>string: the comment to add the first time the string is changed
        /// <param name="useCaps"></param>bool: sets the "MatchCase" property for the find operation
        /// <param name="useWholeWord"></param>bool: sets the "MatchWholeWord" property for the find operation
        /// <param name="commentHasBeenMade"></param>Bool: a flag that a comment has already been made for this error, to avoid duplicate comments
        /// <returns>bool</returns>
        private bool StringReplacer(String find, String replace, String commentText, bool useCaps = true, bool useWholeWord = true, bool commentHasBeenMade = false)
        {
             currentDocument.ActiveWindow.Selection.Find.ClearFormatting();

            Range range = currentDocument.Content;
            range.Start = currentDocument.Content.Start;
            range.End = currentDocument.Content.End;

            range.Find.MatchCase = useCaps;
            range.Find.MatchWholeWord = useWholeWord;

            while(range.Find.Execute(FindText: find, ReplaceWith: replace))
            {
                // if this is the first one found, create a comment using the passed-in text
                if (!commentHasBeenMade)
                {
                    Comment comment = currentDocument.Comments.Add(range, commentText);
                    comment.Range.Font.Name = "Calibri";
                    commentHasBeenMade = true;

                    // Delete the text from the drop-down list
                    //foreach (RibbonDropDownItem currentItem in Globals.Ribbons.Ribbon.dropDownTextOptions.Items)
                    //{
                    //    if (currentItem.Label == commentText)
                    //    {
                    //        Globals.Ribbons.Ribbon.dropDownTextOptions.Items.Remove(currentItem);
                    //    }
                    //}
                }

                // Move the start position, so it doesn't find the same thing again
                range.Start = currentDocument.Content.Start + replace.Length + 1;
                range.End = currentDocument.Content.End;
            }

            return commentHasBeenMade;
        }

    #endregion

    #region String Highlighter method

        /// <summary>
        ///  STRINGHIGHLIGHTER
        /// </summary>
        /// <param name="find"></param>string: the string to highlight
        /// <returns>bool</returns>
        private void StringHighlighter(String find)
        {
            currentDocument.ActiveWindow.Selection.Find.ClearFormatting();

            Range range = currentDocument.Content;
            range.Start = currentDocument.Content.Start;
            range.End = currentDocument.Content.End;

            range.Find.MatchCase = true;
            range.Find.MatchWholeWord = true;

            while (range.Find.Execute(FindText: find))
            {
                range.HighlightColorIndex = WdColorIndex.wdTeal;
            }

            return;
        }

    #endregion

    #region Regex Replacer method

        private void RegexReplacer(String regexPattern, String replacement, String commentText)
        {
            bool commentHasBeenMade = false;

            currentDocument.ActiveWindow.Selection.Find.ClearFormatting();

            Range range = currentDocument.Content;
            range.Start = currentDocument.Content.Start;
            range.End = currentDocument.Content.End;

            //range.Find.MatchCase = useAllCaps;
            //range.Find.MatchWholeWord = useWholeWord;

            MatchCollection matches = Regex.Matches(range.Text, regexPattern);

            foreach (Match m in matches)
            {
                Regex.Replace(range.Text, regexPattern, replacement);

                // if this is the first one found, create a comment using the passed-in text
                if (!commentHasBeenMade)
                {
                    // Move the beginning of "range" to the found text
                    range.Start = m.Index;
                    range.End = m.Index + m.Length;

                    currentDocument.Comments.Add(range, commentText);
                    commentHasBeenMade = true;

                    // Reset the end of the range back to the full document
                    //range.Start = currentDocument.Content.Start;
                    //range.End = currentDocument.Content.End;

                    // Delete the text from the drop-down list
                    //foreach (RibbonDropDownItem currentItem in Globals.Ribbons.Ribbon.dropDownTextOptions.Items)
                    //{
                    //    if (currentItem.Label == commentText)
                    //    {
                    //        Globals.Ribbons.Ribbon.dropDownTextOptions.Items.Remove(currentItem);
                    //    }
                    //}
                }

                
            }
                
            return;

        }

    #endregion

    #region Spell Check

        private void Spelldoink()
        {
            //string result = "Spelled incorrectly.";

            object optional = Missing.Value;
            currentDocument.CheckSpelling(ref optional, true, true, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);
            currentDocument.CheckGrammar();

        }

        #endregion

        public void ActivateSentencePanel()
        {
            sentencePanel.Visible = true;
        }

        public void DisactivateSentencePanel()
        {
            sentencePanel.Visible = false;
        }
    }
}