using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticEditor
{
    public partial class frmOptions : Form
    {
        public frmOptions()
        {
            InitializeComponent();
        }

        private void frmOptions_Load(object sender, EventArgs e)
        {

        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            String introString = "";
            bool isAmerican = true;

            // Check that only one introductory text is checked
            int sumOfTrues = (checkBoxStandard.Checked ? 1 : 0) + (checkBoxLaTex.Checked ? 1 : 0) + (checkBoxKorean.Checked ? 1 : 0) + (checkBoxELSVR.Checked ? 1 : 0);
            if (sumOfTrues != 1)
            {
                MessageBox.Show("You picked a poor number of texts. Pick one.", "You screwed up!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // If it passed the 'one box' check, assign the chosen text string             
            if (checkBoxStandard.Checked)
            {
                introString = "Although this document did not require heavy or extensive revisions, I have carefully checked it for language, readability, clarity, and an appropriate tone. Do not hesitate to contact me via your Client Manager if you require any clarifications or have some questions. All the best with your submission!";
            }
            else if (checkBoxLaTex.Checked)
            {
                introString = "Thank you for submitting your revised manuscript for editing. Although this document did not require heavy or extensive revisions, I have carefully checked it for language, readability, clarity, and an appropriate tone. Figures, tables and references have been excluded from the edit, as per your instruction. This Word file shows my changes through the Track Changes feature. This file also contains my comments. Please go through them carefully. It is important that all of them are addressed before the document is put to its intended use._You can review my changes and make any revisions directly in this file. Once you have made all revisions, switch to Final view (no markup) and copy all contents into the TeX file to update it with your revisions. As always, if you have any further questions or concerns you can contact me at any time via your Client Manager.";
            }
            else if (checkBoxKorean.Checked)
            {
                introString = "Thank you for using our service. Please go through all the comments and allow us to check any further changes made to the edited files to prevent negative journal comments on language.";
            }
            else if (checkBoxELSVR.Checked)
            {
                introString = "Thank you for using our service. Please go through all the comments and allow us to check any further changes made to the edited files to prevent negative journal comments on language.";
            }

            // Check that one language has been checked
            if (!checkBoxAmerican.Checked && !checkBoxBritish.Checked) MessageBox.Show("Pick a language you bastard!", "You screwed up!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Check that one language has been checked
            if (checkBoxAmerican.Checked && checkBoxBritish.Checked) MessageBox.Show("Pick only one language you bastard!", "You screwed up!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            // Get the value for is American style
            if (checkBoxAmerican.Checked == true) isAmerican = true;
            else isAmerican = false;

            // If all the input is good, close the form
            this.Close();

            // Start editing, passing in the "introString" and the value for "isAmerican"
            Main main = new Main();
            main.StartEditing(introString, isAmerican);

            MessageBox.Show("Editing finished with no errors.", "We be done.", MessageBoxButtons.OK);

            return;
        }

        #region Handle the "Choose text" textboxes
        private void checkBoxStandard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxStandard.Checked)
            {
                checkBoxELSVR.Checked = false;
                checkBoxKorean.Checked = false;
                checkBoxLaTex.Checked = false;
            }
        }

        private void checkBoxLaTex_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxLaTex.Checked)
            {
                checkBoxELSVR.Checked = false;
                checkBoxKorean.Checked = false;
                checkBoxStandard.Checked = false;
            }
        }

        private void checkBoxKorean_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxKorean.Checked)
            {
                checkBoxELSVR.Checked = false;
                checkBoxLaTex.Checked = false;
                checkBoxStandard.Checked = false;
            }
        }

        private void checkBoxELSVR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxELSVR.Checked)
            {
                checkBoxLaTex.Checked = false;
                checkBoxKorean.Checked = false;
                checkBoxStandard.Checked = false;
            }
        }

        #endregion

        #region Handle the language check boxes

        private void checkBoxAmerican_CheckedChanged(object sender, EventArgs e)
        {
            // On click, set both check boxes
            if (checkBoxAmerican.Checked == true) checkBoxBritish.Checked = false;
            else checkBoxBritish.Checked = true;
        }

        private void checkBoxBritish_CheckedChanged(object sender, EventArgs e)
        {
            // On click, set both check boxes
            if (checkBoxBritish.Checked == true) checkBoxAmerican.Checked = false;
            else checkBoxAmerican.Checked = true;
        }

        #endregion


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}