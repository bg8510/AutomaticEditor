namespace AutomaticEditor
{
    partial class frmOptions
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOptions));
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkBoxELSVR = new System.Windows.Forms.CheckBox();
            this.checkBoxKorean = new System.Windows.Forms.CheckBox();
            this.checkBoxLaTex = new System.Windows.Forms.CheckBox();
            this.checkBoxStandard = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxBritish = new System.Windows.Forms.CheckBox();
            this.checkBoxAmerican = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(73)))), ((int)(((byte)(51)))));
            this.buttonStart.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(47)))), ((int)(((byte)(79)))));
            this.buttonStart.Location = new System.Drawing.Point(505, 222);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(195, 82);
            this.buttonStart.TabIndex = 0;
            this.buttonStart.Text = "Start Editing";
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(93)))));
            this.groupBox1.Controls.Add(this.checkBoxELSVR);
            this.groupBox1.Controls.Add(this.checkBoxKorean);
            this.groupBox1.Controls.Add(this.checkBoxLaTex);
            this.groupBox1.Controls.Add(this.checkBoxStandard);
            this.groupBox1.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(170)))), ((int)(((byte)(176)))));
            this.groupBox1.Location = new System.Drawing.Point(54, 43);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.groupBox1.Size = new System.Drawing.Size(350, 260);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select the Introduction";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBoxELSVR
            // 
            this.checkBoxELSVR.AutoSize = true;
            this.checkBoxELSVR.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxELSVR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxELSVR.Location = new System.Drawing.Point(14, 205);
            this.checkBoxELSVR.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxELSVR.Name = "checkBoxELSVR";
            this.checkBoxELSVR.Size = new System.Drawing.Size(169, 33);
            this.checkBoxELSVR.TabIndex = 3;
            this.checkBoxELSVR.Text = "ELSVR Text";
            this.checkBoxELSVR.UseVisualStyleBackColor = true;
            this.checkBoxELSVR.CheckedChanged += new System.EventHandler(this.checkBoxELSVR_CheckedChanged);
            // 
            // checkBoxKorean
            // 
            this.checkBoxKorean.AutoSize = true;
            this.checkBoxKorean.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxKorean.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxKorean.Location = new System.Drawing.Point(14, 152);
            this.checkBoxKorean.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxKorean.Name = "checkBoxKorean";
            this.checkBoxKorean.Size = new System.Drawing.Size(303, 33);
            this.checkBoxKorean.TabIndex = 2;
            this.checkBoxKorean.Text = "Korean Corporate Text";
            this.checkBoxKorean.UseVisualStyleBackColor = true;
            this.checkBoxKorean.CheckedChanged += new System.EventHandler(this.checkBoxKorean_CheckedChanged);
            // 
            // checkBoxLaTex
            // 
            this.checkBoxLaTex.AutoSize = true;
            this.checkBoxLaTex.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLaTex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxLaTex.Location = new System.Drawing.Point(14, 99);
            this.checkBoxLaTex.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxLaTex.Name = "checkBoxLaTex";
            this.checkBoxLaTex.Size = new System.Drawing.Size(159, 33);
            this.checkBoxLaTex.TabIndex = 1;
            this.checkBoxLaTex.Text = "LaTex Text";
            this.checkBoxLaTex.UseVisualStyleBackColor = true;
            this.checkBoxLaTex.CheckedChanged += new System.EventHandler(this.checkBoxLaTex_CheckedChanged);
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.AutoSize = true;
            this.checkBoxStandard.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStandard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxStandard.Location = new System.Drawing.Point(14, 46);
            this.checkBoxStandard.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxStandard.Name = "checkBoxStandard";
            this.checkBoxStandard.Size = new System.Drawing.Size(200, 33);
            this.checkBoxStandard.TabIndex = 0;
            this.checkBoxStandard.Text = "Standard Text";
            this.checkBoxStandard.UseVisualStyleBackColor = true;
            this.checkBoxStandard.CheckedChanged += new System.EventHandler(this.checkBoxStandard_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(61)))), ((int)(((byte)(93)))));
            this.groupBox2.Controls.Add(this.checkBoxBritish);
            this.groupBox2.Controls.Add(this.checkBoxAmerican);
            this.groupBox2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(170)))), ((int)(((byte)(176)))));
            this.groupBox2.Location = new System.Drawing.Point(455, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 160);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select the Language";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // checkBoxBritish
            // 
            this.checkBoxBritish.AutoSize = true;
            this.checkBoxBritish.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBritish.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxBritish.Location = new System.Drawing.Point(18, 99);
            this.checkBoxBritish.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxBritish.Name = "checkBoxBritish";
            this.checkBoxBritish.Size = new System.Drawing.Size(203, 33);
            this.checkBoxBritish.TabIndex = 2;
            this.checkBoxBritish.Text = "British English";
            this.checkBoxBritish.UseVisualStyleBackColor = true;
            this.checkBoxBritish.CheckedChanged += new System.EventHandler(this.checkBoxBritish_CheckedChanged);
            // 
            // checkBoxAmerican
            // 
            this.checkBoxAmerican.AutoSize = true;
            this.checkBoxAmerican.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAmerican.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(235)))), ((int)(((byte)(245)))), ((int)(((byte)(255)))));
            this.checkBoxAmerican.Location = new System.Drawing.Point(18, 46);
            this.checkBoxAmerican.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.checkBoxAmerican.Name = "checkBoxAmerican";
            this.checkBoxAmerican.Size = new System.Drawing.Size(239, 33);
            this.checkBoxAmerican.TabIndex = 1;
            this.checkBoxAmerican.Text = "American English";
            this.checkBoxAmerican.UseVisualStyleBackColor = true;
            this.checkBoxAmerican.CheckedChanged += new System.EventHandler(this.checkBoxAmerican_CheckedChanged);
            // 
            // frmOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(6)))), ((int)(((byte)(47)))), ((int)(((byte)(79)))));
            this.ClientSize = new System.Drawing.Size(800, 361);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonStart);
            this.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "frmOptions";
            this.Text = "Choose Options";
            this.Load += new System.EventHandler(this.frmOptions_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBoxKorean;
        private System.Windows.Forms.CheckBox checkBoxLaTex;
        private System.Windows.Forms.CheckBox checkBoxELSVR;
        private System.Windows.Forms.CheckBox checkBoxStandard;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxAmerican;
        private System.Windows.Forms.CheckBox checkBoxBritish;
    }
}