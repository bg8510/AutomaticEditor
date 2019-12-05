using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace AutomaticEditor
{
    public partial class Ribbon
    {
        private void Ribbon_Load(object sender, RibbonUIEventArgs e)
        {
            List<RibbonDropDownItem> Comments = new List<RibbonDropDownItem>();
            
            StringHandler stringHandler = new StringHandler();

            foreach (string comment in stringHandler.GetCommentStrings())
            {
                RibbonDropDownItem currentItem = Globals.Factory.GetRibbonFactory().CreateRibbonDropDownItem();
                currentItem.Label = comment;
                dropDownTextOptions.Items.Add(currentItem);
            }
        }

        #region Button1_Click method

        private void Button1_Click(object sender, RibbonControlEventArgs e)
        {
            Form myForm = new frmOptions();
            myForm.Show();

        }

        #endregion

        // When a text is selected from the dropdown, a comment is created and the text is deleted from the dropdown list
        private void DropDownTextOptions_SelectionChanged(object sender, RibbonControlEventArgs e)
        {
            String selectedText = dropDownTextOptions.SelectedItem.Label;

            // Add the selected comment at the currently selected range
            Globals.ThisAddIn.Application.ActiveDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, selectedText);

            // Do not delete any text that starts with a blank. The blank indicates a text that might be repeated in comments.
            if (selectedText.StartsWith(" ")) return;

            // If it's any other text, delete it after one use
            foreach (RibbonDropDownItem currentItem in dropDownTextOptions.Items)
            {
                if (currentItem.Label == selectedText)
                {
                    dropDownTextOptions.Items.Remove(currentItem);
                }
            }

        }

        private void AmericanStyle_Click(object sender, RibbonControlEventArgs e)
        {
            BritishStyle.Checked = false;
        }

        private void BritishStyle_Click(object sender, RibbonControlEventArgs e)
        {
            AmericanStyle.Checked = false;
        }
    }
}