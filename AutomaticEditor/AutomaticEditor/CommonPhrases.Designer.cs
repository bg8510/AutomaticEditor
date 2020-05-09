namespace AutomaticEditor
{
    partial class CommonPhrases
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CommonPhrases));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.abbreviationsCB = new System.Windows.Forms.ToolStripComboBox();
            this.contractionsCB = new System.Windows.Forms.ToolStripComboBox();
            this.formalityCB = new System.Windows.Forms.ToolStripComboBox();
            this.sentencesCB = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.LeftToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("menuStrip1.BackgroundImage")));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abbreviationsCB,
            this.contractionsCB,
            this.formalityCB,
            this.sentencesCB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.MaximumSize = new System.Drawing.Size(320, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(1, 2, 1, 2);
            this.menuStrip1.ShowItemToolTips = true;
            this.menuStrip1.Size = new System.Drawing.Size(315, 308);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // abbreviationsCB
            // 
            this.abbreviationsCB.BackColor = System.Drawing.SystemColors.Window;
            this.abbreviationsCB.DropDownWidth = 300;
            this.abbreviationsCB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.abbreviationsCB.Items.AddRange(new object[] {
            "Define an abbreviation the first time you use it. Please make sure this is the co" +
                "rrect definition.",
            resources.GetString("abbreviationsCB.Items"),
            "Once you define an abbreviation, use it.",
            "Redefine the abbreviation in the main text. Some readers will not read both the a" +
                "bstract and the main text.",
            "When using an abbreviation, the last word that the abbreviation stands for should" +
                " not be repeated after it.",
            "You do not need to define an abbreviation in the abstract that you never use in t" +
                "he abstract.",
            "You do not need to define an abbreviation that you never use.",
            "Ω Cancel"});
            this.abbreviationsCB.Margin = new System.Windows.Forms.Padding(1, 5, 1, 0);
            this.abbreviationsCB.Name = "abbreviationsCB";
            this.abbreviationsCB.Size = new System.Drawing.Size(310, 25);
            this.abbreviationsCB.Sorted = true;
            this.abbreviationsCB.Text = "Abbreviations";
            this.abbreviationsCB.ToolTipText = "Abbreviations";
            this.abbreviationsCB.SelectedIndexChanged += new System.EventHandler(this.abbreviationsCB_Pick);
            // 
            // contractionsCB
            // 
            this.contractionsCB.DropDownWidth = 300;
            this.contractionsCB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contractionsCB.Items.AddRange(new object[] {
            "Contractions like “can’t” should be avoided in academic writing.",
            "Contractions like “didn’t” should be avoided in academic writing.",
            "Contractions like “doesn’t” should be avoided in academic writing.",
            "Contractions like “don’t” should be avoided in academic writing.",
            "Contractions like “I’d” should be avoided in academic writing.",
            "Contractions like “won’t” should be avoided in academic writing.",
            "Ω Cancel"});
            this.contractionsCB.Margin = new System.Windows.Forms.Padding(1, 5, 1, 0);
            this.contractionsCB.MaxDropDownItems = 7;
            this.contractionsCB.Name = "contractionsCB";
            this.contractionsCB.Size = new System.Drawing.Size(310, 25);
            this.contractionsCB.Sorted = true;
            this.contractionsCB.Text = "Contractions";
            this.contractionsCB.ToolTipText = "Contractions";
            this.contractionsCB.SelectedIndexChanged += new System.EventHandler(this.contractionsCB_Pick);
            // 
            // formalityCB
            // 
            this.formalityCB.DropDownWidth = 300;
            this.formalityCB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formalityCB.Items.AddRange(new object[] {
            "“a lot of” is too informal.",
            "“Huge” is too informal for academic writing.",
            "“more and more” is too informal for academic writing.",
            "“Nowadays” is too informal for academic writing.",
            "“What\'s more” is too informal for academic writing.",
            "Ω Cancel"});
            this.formalityCB.Margin = new System.Windows.Forms.Padding(1, 5, 1, 0);
            this.formalityCB.MaxDropDownItems = 6;
            this.formalityCB.Name = "formalityCB";
            this.formalityCB.Size = new System.Drawing.Size(310, 25);
            this.formalityCB.Sorted = true;
            this.formalityCB.Text = "Formality";
            this.formalityCB.ToolTipText = "Formality";
            this.formalityCB.SelectedIndexChanged += new System.EventHandler(this.formalityCB_Pick);
            // 
            // sentencesCB
            // 
            this.sentencesCB.DropDownWidth = 300;
            this.sentencesCB.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sentencesCB.Items.AddRange(new object[] {
            "Avoid using short coordinating conjunctions like “and” and “but” at the beginning" +
                " of a sentence.",
            "Avoid using short coordinating conjunctions like “and” and “so” at the beginning " +
                "of a sentence.",
            "Comma splice: Two complete sentences should not be joined with only a comma. Use " +
                "either a semicolon or a comma followed by a conjunction.",
            "Compound sentences require a comma before the conjunction.",
            "Do not put a comma before the conjunction because this is not two sentences. It i" +
                "s one subject with a compound predicate.",
            "Use a semicolon rather than a comma to join sentences with a conjunctive adverb.",
            "Ω Cancel"});
            this.sentencesCB.Margin = new System.Windows.Forms.Padding(1, 5, 1, 0);
            this.sentencesCB.MaxDropDownItems = 7;
            this.sentencesCB.Name = "sentencesCB";
            this.sentencesCB.Size = new System.Drawing.Size(310, 25);
            this.sentencesCB.Sorted = true;
            this.sentencesCB.Text = "Sentences";
            this.sentencesCB.ToolTipText = "Sentences";
            this.sentencesCB.SelectedIndexChanged += new System.EventHandler(this.sentencesCB_Pick);
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.label1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(0, 308);
            // 
            // toolStripContainer1.LeftToolStripPanel
            // 
            this.toolStripContainer1.LeftToolStripPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.Location = new System.Drawing.Point(8, 8);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(317, 308);
            this.toolStripContainer1.TabIndex = 1;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // CommonPhrases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(187)))));
            this.Controls.Add(this.toolStripContainer1);
            this.Name = "CommonPhrases";
            this.Size = new System.Drawing.Size(330, 433);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.LeftToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.LeftToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripComboBox abbreviationsCB;
        private System.Windows.Forms.ToolStripComboBox contractionsCB;
        private System.Windows.Forms.ToolStripComboBox sentencesCB;
        private System.Windows.Forms.ToolStripComboBox formalityCB;
        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.Label label1;
    }
}
