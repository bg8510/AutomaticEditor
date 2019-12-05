namespace AutomaticEditor
{
    partial class Ribbon : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.TextGroup = this.Factory.CreateRibbonGroup();
            this.label1 = this.Factory.CreateRibbonLabel();
            this.checkBoxStandard = this.Factory.CreateRibbonCheckBox();
            this.checkBoxLaTex = this.Factory.CreateRibbonCheckBox();
            this.label2 = this.Factory.CreateRibbonLabel();
            this.checkBoxKorean = this.Factory.CreateRibbonCheckBox();
            this.checkBoxELSVR = this.Factory.CreateRibbonCheckBox();
            this.group3 = this.Factory.CreateRibbonGroup();
            this.AmericanStyle = this.Factory.CreateRibbonCheckBox();
            this.BritishStyle = this.Factory.CreateRibbonCheckBox();
            this.StartGroup = this.Factory.CreateRibbonGroup();
            this.StartButton = this.Factory.CreateRibbonButton();
            this.group1 = this.Factory.CreateRibbonGroup();
            this.label3 = this.Factory.CreateRibbonLabel();
            this.dropDownTextOptions = this.Factory.CreateRibbonDropDown();
            this.group2 = this.Factory.CreateRibbonGroup();
            this.button1 = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.TextGroup.SuspendLayout();
            this.group3.SuspendLayout();
            this.StartGroup.SuspendLayout();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.TextGroup);
            this.tab1.Groups.Add(this.group3);
            this.tab1.Groups.Add(this.StartGroup);
            this.tab1.Groups.Add(this.group1);
            this.tab1.Groups.Add(this.group2);
            this.tab1.Label = "Cactus Editing";
            this.tab1.Name = "tab1";
            // 
            // TextGroup
            // 
            this.TextGroup.Items.Add(this.label1);
            this.TextGroup.Items.Add(this.checkBoxStandard);
            this.TextGroup.Items.Add(this.checkBoxLaTex);
            this.TextGroup.Items.Add(this.label2);
            this.TextGroup.Items.Add(this.checkBoxKorean);
            this.TextGroup.Items.Add(this.checkBoxELSVR);
            this.TextGroup.Label = "Introductory Text Options";
            this.TextGroup.Name = "TextGroup";
            this.TextGroup.Visible = false;
            // 
            // label1
            // 
            this.label1.Label = "Choose the style of introductory text";
            this.label1.Name = "label1";
            // 
            // checkBoxStandard
            // 
            this.checkBoxStandard.Label = "Standard Text";
            this.checkBoxStandard.Name = "checkBoxStandard";
            // 
            // checkBoxLaTex
            // 
            this.checkBoxLaTex.Label = "LaTex Text";
            this.checkBoxLaTex.Name = "checkBoxLaTex";
            // 
            // label2
            // 
            this.label2.Label = " ";
            this.label2.Name = "label2";
            // 
            // checkBoxKorean
            // 
            this.checkBoxKorean.Label = "Korean Corporate Text";
            this.checkBoxKorean.Name = "checkBoxKorean";
            // 
            // checkBoxELSVR
            // 
            this.checkBoxELSVR.Label = "ELSVR Text";
            this.checkBoxELSVR.Name = "checkBoxELSVR";
            // 
            // group3
            // 
            this.group3.Items.Add(this.AmericanStyle);
            this.group3.Items.Add(this.BritishStyle);
            this.group3.Label = "Rule Domain";
            this.group3.Name = "group3";
            this.group3.Visible = false;
            // 
            // AmericanStyle
            // 
            this.AmericanStyle.Checked = true;
            this.AmericanStyle.Label = "American Style English";
            this.AmericanStyle.Name = "AmericanStyle";
            this.AmericanStyle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.AmericanStyle_Click);
            // 
            // BritishStyle
            // 
            this.BritishStyle.Label = "British English";
            this.BritishStyle.Name = "BritishStyle";
            this.BritishStyle.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.BritishStyle_Click);
            // 
            // StartGroup
            // 
            this.StartGroup.Items.Add(this.StartButton);
            this.StartGroup.Label = "Start";
            this.StartGroup.Name = "StartGroup";
            // 
            // StartButton
            // 
            this.StartButton.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.StartButton.Image = ((System.Drawing.Image)(resources.GetObject("StartButton.Image")));
            this.StartButton.Label = "Rock the Casbah";
            this.StartButton.Name = "StartButton";
            this.StartButton.ShowImage = true;
            this.StartButton.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.Button1_Click);
            // 
            // group1
            // 
            this.group1.Items.Add(this.label3);
            this.group1.Items.Add(this.dropDownTextOptions);
            this.group1.Label = "Comment Options";
            this.group1.Name = "group1";
            // 
            // label3
            // 
            this.label3.Label = "Choose the text for your comment:";
            this.label3.Name = "label3";
            // 
            // dropDownTextOptions
            // 
            this.dropDownTextOptions.Label = "Text Options";
            this.dropDownTextOptions.Name = "dropDownTextOptions";
            this.dropDownTextOptions.ShowImage = true;
            this.dropDownTextOptions.ShowItemLabel = false;
            this.dropDownTextOptions.SelectionChanged += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.DropDownTextOptions_SelectionChanged);
            // 
            // group2
            // 
            this.group2.Name = "group2";
            // 
            // button1
            // 
            this.button1.Label = "";
            this.button1.Name = "button1";
            // 
            // Ribbon
            // 
            this.Name = "Ribbon";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.TextGroup.ResumeLayout(false);
            this.TextGroup.PerformLayout();
            this.group3.ResumeLayout(false);
            this.group3.PerformLayout();
            this.StartGroup.ResumeLayout(false);
            this.StartGroup.PerformLayout();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup TextGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBoxStandard;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBoxLaTex;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label2;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBoxKorean;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox checkBoxELSVR;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton StartButton;
        public Microsoft.Office.Tools.Ribbon.RibbonLabel label1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup StartGroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group1;
        internal Microsoft.Office.Tools.Ribbon.RibbonLabel label3;
        internal Microsoft.Office.Tools.Ribbon.RibbonDropDown dropDownTextOptions;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group2;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton button1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup group3;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox AmericanStyle;
        internal Microsoft.Office.Tools.Ribbon.RibbonCheckBox BritishStyle;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon Ribbon
        {
            get { return this.GetRibbon<Ribbon>(); }
        }
    }
}
