using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Word = Microsoft.Office.Interop.Word;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Word;
using Microsoft.Office.Interop.Word;
using Document = Microsoft.Office.Interop.Word.Document;
using Microsoft.Office.Tools;

namespace AutomaticEditor
{
    public partial class ThisAddIn
    {
        public static SidePanel sidePanel;
        public static CommonPhrases commonPhrases;
        public CustomTaskPane customPanel;
        public CustomTaskPane commonPhrasePanel;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            sidePanel = new SidePanel();
            customPanel = CustomTaskPanes.Add(sidePanel, "Grammarlin");
            customPanel.Visible = true;
        }

        public void ActivateCustomPanel()
        {
            customPanel.Visible = true;
        }

        public void DisactivateCustomPanel()
        {
            customPanel.Visible = false;
        }

        private static void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        #region VSTO generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion

    }
}