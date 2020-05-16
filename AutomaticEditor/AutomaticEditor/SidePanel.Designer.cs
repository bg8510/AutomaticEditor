using System.Windows.Forms;

namespace AutomaticEditor
{
    partial class SidePanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxELSVR = new System.Windows.Forms.CheckBox();
            this.checkBoxKorean = new System.Windows.Forms.CheckBox();
            this.checkBoxLaTex = new System.Windows.Forms.CheckBox();
            this.checkBoxStandard = new System.Windows.Forms.CheckBox();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBritish = new System.Windows.Forms.CheckBox();
            this.checkBoxAmerican = new System.Windows.Forms.CheckBox();
            this.bypassButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(169)))));
            this.groupBox1.Controls.Add(this.checkBoxELSVR);
            this.groupBox1.Controls.Add(this.checkBoxKorean);
            this.groupBox1.Controls.Add(this.checkBoxLaTex);
            this.groupBox1.Controls.Add(this.checkBoxStandard);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox1.Location = new System.Drawing.Point(5, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(196, 181);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the Introduction";
            // 
            // checkBoxELSVR
            // 
            this.checkBoxELSVR.AutoSize = true;
            this.checkBoxELSVR.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxELSVR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxELSVR.Location = new System.Drawing.Point(11, 147);
            this.checkBoxELSVR.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxELSVR.Name = "checkBoxELSVR";
            this.checkBoxELSVR.Size = new System.Drawing.Size(102, 20);
            this.checkBoxELSVR.TabIndex = 3;
            this.checkBoxELSVR.Text = "ELSVR Text";
            this.checkBoxELSVR.UseVisualStyleBackColor = true;
            // 
            // checkBoxKorean
            // 
            this.checkBoxKorean.AutoSize = true;
            this.checkBoxKorean.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKorean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxKorean.Location = new System.Drawing.Point(11, 116);
            this.checkBoxKorean.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxKorean.Name = "checkBoxKorean";
            this.checkBoxKorean.Size = new System.Drawing.Size(176, 20);
            this.checkBoxKorean.TabIndex = 2;
            this.checkBoxKorean.Text = "Korean Corporate Text";
            this.checkBoxKorean.UseVisualStyleBackColor = true;
            // 
            // checkBoxLaTex
            // 
            this.checkBoxLaTex.AutoSize = true;
            this.checkBoxLaTex.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLaTex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxLaTex.Location = new System.Drawing.Point(11, 86);
            this.checkBoxLaTex.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxLaTex.Name = "checkBoxLaTex";
            this.checkBoxLaTex.Size = new System.Drawing.Size(99, 20);
            this.checkBoxLaTex.TabIndex = 1;
            this.checkBoxLaTex.Text = "LaTex Text";
            this.checkBoxLaTex.UseVisualStyleBackColor = true;
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.AutoSize = true;
            this.checkBoxStandard.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxStandard.Location = new System.Drawing.Point(11, 56);
            this.checkBoxStandard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxStandard.Name = "checkBoxStandard";
            this.checkBoxStandard.Size = new System.Drawing.Size(121, 20);
            this.checkBoxStandard.TabIndex = 0;
            this.checkBoxStandard.Text = "Standard Text";
            this.checkBoxStandard.UseVisualStyleBackColor = true;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.MistyRose;
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonStart.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Firebrick;
            this.buttonStart.Location = new System.Drawing.Point(23, 365);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(151, 61);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start Editing";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(127)))), ((int)(((byte)(169)))));
            this.groupBox2.Controls.Add(this.checkBoxBritish);
            this.groupBox2.Controls.Add(this.checkBoxAmerican);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.groupBox2.Location = new System.Drawing.Point(5, 214);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(196, 109);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Language";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBoxBritish
            // 
            this.checkBoxBritish.AutoSize = true;
            this.checkBoxBritish.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBritish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxBritish.Location = new System.Drawing.Point(18, 66);
            this.checkBoxBritish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxBritish.Name = "checkBoxBritish";
            this.checkBoxBritish.Padding = new System.Windows.Forms.Padding(2);
            this.checkBoxBritish.Size = new System.Drawing.Size(121, 24);
            this.checkBoxBritish.TabIndex = 2;
            this.checkBoxBritish.Text = "British English";
            this.checkBoxBritish.UseVisualStyleBackColor = true;
            // 
            // checkBoxAmerican
            // 
            this.checkBoxAmerican.AutoSize = true;
            this.checkBoxAmerican.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAmerican.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxAmerican.Location = new System.Drawing.Point(18, 37);
            this.checkBoxAmerican.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxAmerican.Name = "checkBoxAmerican";
            this.checkBoxAmerican.Padding = new System.Windows.Forms.Padding(2);
            this.checkBoxAmerican.Size = new System.Drawing.Size(141, 24);
            this.checkBoxAmerican.TabIndex = 1;
            this.checkBoxAmerican.Text = "American English";
            this.checkBoxAmerican.UseVisualStyleBackColor = true;
            // 
            // bypassButton
            // 
            this.bypassButton.BackColor = System.Drawing.Color.SkyBlue;
            this.bypassButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bypassButton.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bypassButton.ForeColor = System.Drawing.Color.ForestGreen;
            this.bypassButton.Location = new System.Drawing.Point(45, 473);
            this.bypassButton.Name = "bypassButton";
            this.bypassButton.Size = new System.Drawing.Size(106, 55);
            this.bypassButton.TabIndex = 7;
            this.bypassButton.Text = "Bypass this Step";
            this.bypassButton.UseVisualStyleBackColor = false;
            this.bypassButton.Click += new System.EventHandler(this.bypassButton_Click);
            // 
            // SidePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Gray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Controls.Add(this.bypassButton);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "SidePanel";
            this.Padding = new System.Windows.Forms.Padding(2);
            this.Size = new System.Drawing.Size(208, 897);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxELSVR;
        private System.Windows.Forms.CheckBox checkBoxKorean;
        private System.Windows.Forms.CheckBox checkBoxLaTex;
        private System.Windows.Forms.CheckBox checkBoxStandard;
        private Button buttonStart;
        private GroupBox groupBox2;
        private CheckBox checkBoxBritish;
        private CheckBox checkBoxAmerican;
        private Button bypassButton;
    }
}
