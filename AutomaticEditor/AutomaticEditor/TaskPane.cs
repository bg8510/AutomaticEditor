using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutomaticEditor
{
    public partial class TaskPane : UserControl
    {
        public TaskPane()
        {
            InitializeComponent();
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            DialogResult msg = MessageBox.Show("It worked!", "Goobers", MessageBoxButtons.OK);
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

    #region Handle thelanguage check boxes

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

    }
}
