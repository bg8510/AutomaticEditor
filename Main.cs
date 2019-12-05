using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Threading.Tasks;

namespace AutomaticEditor
{
    class Main
    {
        Document currentDocument = Globals.ThisAddIn.Application.ActiveDocument;
        
        #region Start Editing method

        public void StartEditing(String introText, bool isAmericanStyle = true)
        {
            // Activate track changes
            currentDocument.TrackRevisions = true;
            RevisionsFilter wrdRevisionsFilter = currentDocument.ActiveWindow.View.RevisionsFilter;
            wrdRevisionsFilter.Markup = WdRevisionsMarkup.wdRevisionsMarkupSimple;

            // Set the language version
            if (isAmericanStyle) Globals.ThisAddIn.Application.Selection.Range.LanguageID = WdLanguageID.wdEnglishUS;
            else Globals.ThisAddIn.Application.Selection.Range.LanguageID = WdLanguageID.wdEnglishUK;

            // Add the chosen introductory comment at the currently selected range
            currentDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, introText);

            //StringReplacer("What's more", "Also", "“What's more” is too informal for academic writing.");
            //StringReplacer("And", "", "Avoid using short coordinating conjunctions like “and” and “but” at the beginning of a sentence.");
            //StringReplacer("But", "", "Avoid using short coordinating conjunctions like “and” and “but” at the beginning of a sentence.");
            //StringReplacer("So", "", "Avoid using short coordinating conjunctions like “and” and “so” at the beginning of a sentence.");
            //StringReplacer("Or", "", "Avoid using short coordinating conjunctions like “but” and “or” at the beginning of a sentence.");
            //StringReplacer("can't", "cannot", "Avoid using contractions like “can’t” in academic writing.");
            //StringReplacer("don't", "do not", "Avoid using contractions like “don’t” in academic writing.");
            //StringReplacer("doesn't", "does not", "Avoid using contractions like “doesn’t” in academic writing.");
            //StringReplacer("utilize", "use", "“Use” is almost always a better word choice than “utilize.”");
            //StringReplacer("paper", "study", "In an academic context, “paper” implies a formal written composition that is intended to be published, presented, etc. The “study,” on the other hand, is the actual work carried out.");
            //if (isAmericanStyle) StringReplacer("\", ", ",\" ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.");
            //if (isAmericanStyle) StringReplacer("\". ", ".\" ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.");
            //if (isAmericanStyle) StringReplacer("', ", ",' ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.");
            //if (isAmericanStyle) StringReplacer("'. ", ".' ", "In formal American English, periods and commas go inside the quotes, even if they were not part of the thing being quoted.");
            //StringReplacer("Since", "Because", "In technical writing, the word “since” is reserved for time-related references. To indicate causality, replace “since” with synonyms such as “because.”");
            //StringReplacer("since", "because", "In technical writing, the word “since” is reserved for time-related references. To indicate causality, replace “since” with synonyms such as “because.”");
            StringReplacer("In order to", "To", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.");
            StringReplacer("in order to", "to", "The use of too many words to convey one idea can muddle the message and divert the reader’s attention. Therefore, especially academic writing, ideas need to be conveyed as concisely as possible.");
            StringReplacer("Nowadays", "Recently", "“Nowadays” is too informal for academic writing.", false);
            StringReplacer("huge", "large", "“Huge” is too informal for academic writing.", false);
            StringReplacer("Compared to", "Unlike", "Edited for redundancy/wordiness.", true);
            StringReplacer("At first", "First", "Edited for redundancy/wordiness.", true);
        }

        #endregion

        #region String Replacer method

        private void StringReplacer(String find, String replace, String commentText, bool useAllCaps = true, bool useWholeWord = true)
        {
            bool commentHasBeenMade = false;

            currentDocument.ActiveWindow.Selection.Find.ClearFormatting();

            Range range = currentDocument.Content;
            range.Start = currentDocument.Content.Start;
            range.End = currentDocument.Content.End;

            range.Find.MatchCase = useAllCaps;
            range.Find.MatchWholeWord = useWholeWord;

            while(range.Find.Execute(FindText: find, ReplaceWith: replace))
            {
                // if this is the first one found, create a comment using the passed-in text
                if (!commentHasBeenMade)
                {
                    currentDocument.Comments.Add(range, commentText);
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

                range.End = currentDocument.Content.End;
            }

            return;

        }

        #endregion
    }
}