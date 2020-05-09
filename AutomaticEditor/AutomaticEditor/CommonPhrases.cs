using System;
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
            // Apply the "Cancel" option by not doing anything here
            if (commentWords == "Ω Cancel") return;

            // Add the selected comment at the currently selected range
            Comment comment = Globals.ThisAddIn.Application.ActiveDocument.Comments.Add(Globals.ThisAddIn.Application.Selection.Range, commentWords);
            comment.Range.Font.Name = "Calibri";

            // Remove the selected option so I can't use it twice
            selectedCB.Items.Remove(selectedCB.Items[index]);
        }

        private void abbreviationsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = abbreviationsCB.SelectedItem.ToString();
            int index = abbreviationsCB.SelectedIndex;
            abbreviationsCB.Text = "Abbreviations";
            ApplyComment(selectedComment, abbreviationsCB, index);

            return;
        }

        private void contractionsCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = contractionsCB.SelectedItem.ToString();
            int index = contractionsCB.SelectedIndex;
            contractionsCB.Text = "Contractions";
            ApplyComment(selectedComment, contractionsCB, index);
            
            return;
        }

        private void formalityCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = formalityCB.SelectedItem.ToString();
            int index = formalityCB.SelectedIndex;
            formalityCB.Text = "Formality";
            ApplyComment(selectedComment, formalityCB, index);

            return;
        }

        private void sentencesCB_Pick(object sender, EventArgs e)
        {
            string selectedComment = sentencesCB.SelectedItem.ToString();
            int index = sentencesCB.SelectedIndex;
            sentencesCB.Text = "Sentences";
            ApplyComment(selectedComment, sentencesCB, index);

            return;
        }
    }
}
