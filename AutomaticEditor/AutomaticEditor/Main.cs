using Microsoft.Office.Interop.Word;
using System;
using System.Text.RegularExpressions;
using System.Reflection;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools;

namespace AutomaticEditor
{
    class Main
    {
        public static readonly Document currentDocument = Globals.ThisAddIn.Application.ActiveDocument;

        public static SentencePanel sentences;
        public CustomTaskPane sentencePanel;
        public static CommonPhrases commonPhrases;
        public CustomTaskPane commonPhrasePanel;

        // Choose the current Selection
        // Range range = Globals.ThisAddIn.Application.Selection.Range;

        #region Start Editing method

        public void StartEditing(String introText, bool isAmericanStyle = true)
        {
            bool result;

            sentences = new SentencePanel(currentDocument);
            sentencePanel = Globals.ThisAddIn.CustomTaskPanes.Add(sentences, "Grammatlin");
            sentencePanel.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionRight;
            DisactivateSentencePanel();

            commonPhrases = new CommonPhrases(currentDocument);
            commonPhrasePanel = Globals.ThisAddIn.CustomTaskPanes.Add(commonPhrases, "Common Comments");
            commonPhrasePanel.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionLeft;
            ActivateCommonPhrasesPanel();

            // Activate track changes
            currentDocument.TrackRevisions = true;
            RevisionsFilter wrdRevisionsFilter = currentDocument.ActiveWindow.View.RevisionsFilter;
            wrdRevisionsFilter.Markup = WdRevisionsMarkup.wdRevisionsMarkupSimple;

            // Set the language version
            if (isAmericanStyle) Globals.ThisAddIn.Application.Selection.Range.LanguageID = WdLanguageID.wdEnglishUS;
            else Globals.ThisAddIn.Application.Selection.Range.LanguageID = WdLanguageID.wdEnglishUK;

        goto SkipStringReplacer;

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

SkipStringReplacer:

            //StringHighlighter("paper");


            //RegexReplacer(@"\w+, \w+ and ", @"\w+, \w+, and ", "In academic writing, insert a comma before the conjunction that precedes the last element of a series (e.g., bread, eggs, and milk).");

            // Add the chosen introductory comment at the currently selected range
            //currentDocument.Comments.Range.Font.Name = "Calibri";
            currentDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, introText).Range.Font.Name = "Calibri";

            //Spelldoink();

            Globals.ThisAddIn.DisactivateCustomPanel();

            // Make visible the side panels
            ActivateSentencePanel();
            ActivateCommonPhrasesPanel();

            //object optional = Missing.Value;
            //currentDocument.CheckSpelling(ref optional, true, true, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional, ref optional);
            //currentDocument.CheckGrammar();

            //RunGrammarbot(currentDocument);

            return;
        }

    #endregion


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

        public void ActivateSentencePanel()
        {
            sentencePanel.Visible = true;
        }

        public void DisactivateSentencePanel()
        {
            sentencePanel.Visible = false;
        }

        public void ActivateCommonPhrasesPanel()
        {
            commonPhrasePanel.Visible = true;
        }

        public void DisactivateCommonPhrasesPanel()
        {
            commonPhrasePanel.Visible = false;
        }
    }
}