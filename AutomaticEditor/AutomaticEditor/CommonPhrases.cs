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

        private void ApplyComment(string commentWords, ComboBox selectedCB, int index)
        {
            if (commentWords == "") return;

            // Add the selected comment at the currently selected range
            Comment comment = Globals.ThisAddIn.Application.ActiveDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, commentWords);
            comment.Range.Font.Name = "Calibri";

            if (selectedCB != RepeatableCommentsCB)
            {
                // Remove the selected option so I can't use it twice
                selectedCB.Items.Remove(selectedCB.Items[index]);
            }
            else
            {
                RepeatableCommentsCB.Text = "";
                if (commentWords == "This is not clear. If you contact me via your Client Manager with an explanation of your meaning, I will be happy to review and correct your wording.")
                {
                    selectedCB.Items.Remove(selectedCB.Items[index]);
                    selectedCB.Items.Add("This is not clear. Again, if you contact me via your Client Manager with an explanation, I will be happy to review and correct your wording.");
                    return;
                }
                else if (commentWords == "This is not clear. Again, if you contact me via your Client Manager with an explanation, I will be happy to review and correct your wording.")
                {
                    selectedCB.Items.Remove(selectedCB.Items[index]);
                    selectedCB.Items.Add("This is not clear. As always, you can contact me via your Client Manager with an explanation, and I will be happy to review and correct your wording.");
                    return;
                }
                else if (commentWords == "This is not clear. As always, you can contact me via your Client Manager with an explanation, and I will be happy to review and correct your wording.")
                {
                    selectedCB.Items.Remove(selectedCB.Items[index]);
                    selectedCB.Items.Add("This is not clear. Again, if you contact me via your Client Manager with an explanation, I will be happy to review and correct your wording.");
                    return;
                }
            }
        }

#region ComboBox Handlers

        private void AbbreviationsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = AbbreviationsCB.SelectedItem.ToString();
            int index = AbbreviationsCB.SelectedIndex;
            ApplyComment(selectedComment, AbbreviationsCB, index);

            return;
        }

        private void AdjectivesCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = AdjectivesCB.SelectedItem.ToString();
            int index = AdjectivesCB.SelectedIndex;
            ApplyComment(selectedComment, AdjectivesCB, index);

            return;
        }

        private void ArticlesCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = ArticlesCB.SelectedItem.ToString();
            int index = ArticlesCB.SelectedIndex;
            ApplyComment(selectedComment, ArticlesCB, index);

            return;
        }

        private void BetterWordsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = BetterWordsCB.SelectedItem.ToString();
            int index = BetterWordsCB.SelectedIndex;
            ApplyComment(selectedComment, BetterWordsCB, index);

            return;
        }

        private void CaptionsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = CaptionsCB.SelectedItem.ToString();
            int index = CaptionsCB.SelectedIndex;
            ApplyComment(selectedComment, CaptionsCB, index);

            return;
        }

        private void ContractionsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = ContractionsCB.SelectedItem.ToString();
            int index = ContractionsCB.SelectedIndex;
            ApplyComment(selectedComment, ContractionsCB, index);

            return;
        }

        private void FormalityCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = FormalityCB.SelectedItem.ToString();
            int index = FormalityCB.SelectedIndex;
            ApplyComment(selectedComment, FormalityCB, index);

            return;
        }

        private void RepeatableCommentsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = RepeatableCommentsCB.SelectedItem.ToString();
            int index = RepeatableCommentsCB.SelectedIndex;
            ApplyComment(selectedComment, RepeatableCommentsCB, index);

            return;
        }

        private void SentencesCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = SentencesCB.SelectedItem.ToString();
            int index = SentencesCB.SelectedIndex;
            ApplyComment(selectedComment, SentencesCB, index);

            return;
        }

        private void WordinessCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = WordinessCB.SelectedItem.ToString();
            int index = WordinessCB.SelectedIndex;
            ApplyComment(selectedComment, WordinessCB, index);

            return;
        }

        private void ΩCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = ΩCB.SelectedItem.ToString();
            int index = ΩCB.SelectedIndex;
            ApplyComment(selectedComment, ΩCB, index);

            return;
        }
        #endregion

        private void CommentsToggleButton_Click(object sender, EventArgs e)
        {
            //switch (CommentsToggle.Text)
            //{
            //    case "Switch to LFTE Comments":
            //        //menuStripLFTE.Visible = true;
            //        AbbreviationsLabel.Visible = false;
            //        AbbreviationsCB.Visible = false;
            //        AdjectivesLabel.Visible = false;
            //        AdjectivesCB.Visible = false;
            //        CommentsToggle.Text = "Toggle to Regular Comments";
            //        break;

            //    case "Switch to Regular Comments":
            //        //menuStripRegular.Visible = true;
            //        AbbreviationsLabel.Visible = true;
            //        AbbreviationsCB.Visible = true;
            //        AdjectivesLabel.Visible = true;
            //        AdjectivesCB.Visible = true;
            //        CommentsToggle.Text = "Toggle to LFTE Comments";
            //        break;
            //}
            return;
        }
    }
}