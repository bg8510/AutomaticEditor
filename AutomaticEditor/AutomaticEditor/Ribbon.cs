using System;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace AutomaticEditor
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            StringHandler stringHandler = new StringHandler();
            ArticleStringHandler articleStringHandler = new ArticleStringHandler();

            // Get all the comment strings
            foreach (string comment in stringHandler.GetCommentStrings())
            {
                RibbonDropDownItem currentItem = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                currentItem.Label = comment;
                dropDownTextOptions.Items.Add(currentItem);
            }

            // Get the comment strings for the Articles comment dropdown
            foreach (string comment in articleStringHandler.GetArticleCommentStrings())
            {
                RibbonDropDownItem currentItem = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                currentItem.Label = comment;
                dropDownArticles.Items.Add(currentItem);
            }
        }

        #region Button1_Click method

        private void Button1_Click(object sender, RibbonControlEventArgs e)
        {
            Form myForm = new frmOptions();
            myForm.Show();

        }

        #endregion

        // When a text is selected from the dropdown, a comment is created and the text is
        // deleted from the dropdown list to avoid duplicate comments
        private void DropDownTextOptions_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            String selectedText = dropDownTextOptions.SelectedItem.Label;

            if (selectedText.StartsWith(" "))
            {
                selectedText = selectedText.TrimStart(' ');
            }
             
            // Add the selected comment at the currently selected range
            Comment comment = Globals.ThisAddIn.Application.ActiveDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, selectedText);
            comment.Range.Font.Name = "Calibri";

            // Do not delete any text that starts with a blank. The blank indicates a text that might be repeated in comments.
            if (dropDownTextOptions.SelectedItem.Label.StartsWith(" "))
            {
                // Set the selected item back to the first (the "---------" one)
                dropDownTextOptions.SelectedItem = dropDownTextOptions.Items[0];

                return;
            }

            // If it's any other text, delete it after one use. Do not reference the last Item because the List will be one shorter
            for (int i = 0; i < dropDownTextOptions.Items.Count; i++)                      // each (RibbonDropDownItem currentItem in dropDownTextOptions.Items)
            {
                if (dropDownTextOptions.Items[i].Label == dropDownTextOptions.SelectedItem.Label)
                {
                    dropDownTextOptions.Items.Remove(dropDownTextOptions.Items[i]);
                    return;
                }
            }

            return;
        }

        private void AmericanStyle_Click(object sender, RibbonControlEventArgs e)
        {
            BritishStyle.Checked = false;
        }

        private void BritishStyle_Click(object sender, RibbonControlEventArgs e)
        {
            AmericanStyle.Checked = false;
        }

        private void dropDown1_SelectionChanged(object sender, RibbonControlEventArgs e)
        {

        }

        private void checkBoxSidePanel_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.customPanel.Visible = checkBoxSidePanel.Checked;
        }

        private void checkBoxCommonPhrases_Click(object sender, RibbonControlEventArgs e)
        {
            Globals.ThisAddIn.commonPhrasePanel.Visible = checkBoxCommonPhrases.Checked;
        }
    }
}