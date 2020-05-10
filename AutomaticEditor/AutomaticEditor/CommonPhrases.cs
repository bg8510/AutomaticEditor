using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace AutomaticEditor
{
    public partial class CommonPhrases : UserControl
    {
        public static Document currentDocument;

        public CommonPhrases(Document currentDoc)
        {
            currentDocument = currentDoc;
            InitializeComponent();
        }

        private void ApplyComment(string commentWords, ToolStripComboBox selectedCB, int index)
        {
            // Add the selected comment at the currently selected range
            Comment comment = Globals.ThisAddIn.Application.ActiveDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, commentWords);
            comment.Range.Font.Name = "Calibri";

            if (selectedCB != repeatableCommentsCB)
            {
                // Remove the selected option so I can't use it twice
                selectedCB.Items.Remove(selectedCB.Items[index]);
            }
            else
            {
                repeatableCommentsCB.Text = "";
            }
        }

        private void abbreviationsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = abbreviationsCB.SelectedItem.ToString();
            int index = abbreviationsCB.SelectedIndex;
            ApplyComment(selectedComment, abbreviationsCB, index);

            return;
        }

        private void contractionsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = contractionsCB.SelectedItem.ToString();
            int index = contractionsCB.SelectedIndex;
            ApplyComment(selectedComment, contractionsCB, index);
            
            return;
        }

        private void formalityCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = formalityCB.SelectedItem.ToString();
            int index = formalityCB.SelectedIndex;
            ApplyComment(selectedComment, formalityCB, index);

            return;
        }

        private void sentencesCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = sentencesCB.SelectedItem.ToString();
            int index = sentencesCB.SelectedIndex;
            ApplyComment(selectedComment, sentencesCB, index);

            return;
        }

        private void articlesCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = articlesCB.SelectedItem.ToString();
            int index = articlesCB.SelectedIndex;
            ApplyComment(selectedComment, articlesCB, index);

            return;
        }

        private void betterWordsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = betterWordsCB.SelectedItem.ToString();
            int index = betterWordsCB.SelectedIndex;
            ApplyComment(selectedComment, betterWordsCB, index);

            return;
        }

        private void repeatableCommentsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = repeatableCommentsCB.SelectedItem.ToString();
            int index = repeatableCommentsCB.SelectedIndex;
            ApplyComment(selectedComment, repeatableCommentsCB, index);

            return;
        }

        private void wordinessCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = wordinessCB.SelectedItem.ToString();
            int index = wordinessCB.SelectedIndex;
            ApplyComment(selectedComment, wordinessCB, index);

            return;
        }

        private void commentsToggleButton_Click(object sender, EventArgs e)
        {
            switch (commentsToggleButton.Text)
            {
                case "Switch to LFTE Comments":
                    menuStripLFTE.Visible = true;
                    menuStripRegular.Visible = false;
                    commentsToggleButton.Text = "Switch to Regular Comments";
                    break;

                case "Switch to Regular Comments":
                    menuStripRegular.Visible = true;
                    menuStripLFTE.Visible = false;
                    commentsToggleButton.Text = "Switch to LFTE Comments";
                    break;
            }
            return;
        }
    }
}
