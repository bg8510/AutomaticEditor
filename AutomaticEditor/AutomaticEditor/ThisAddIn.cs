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

namespace AutomaticEditor
{
    public partial class ThisAddIn
    {
        public static SidePanel sidePanel;
        //public static SentencePanel sentences;
        public Microsoft.Office.Tools.CustomTaskPane customPanel;
        //public static Microsoft.Office.Tools.CustomTaskPane sentencePanel;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            sidePanel = new SidePanel();
            customPanel = this.CustomTaskPanes.Add(sidePanel, "Grammarlin Editor");
            customPanel.Visible = true;

            //sentences = new SentencePanel();
            //sentencePanel = this.CustomTaskPanes.Add(sentences, "Grammarlin");
            //sentencePanel.DockPosition = Office.MsoCTPDockPosition.msoCTPDockPositionTop;
            //DisactivateSentencePanel();
        }

        public void ActivateCustomPanel()
        {
            customPanel.Visible = true;
        }

        public void DisactivateCustomPanel()
        {
            customPanel.Visible = false;
        }

        //public void ActivateSentencePanel()
        //{
        //    sentencePanel.Visible = true;
        //}

        //public void DisactivateSentencePanel()
        //{
        //    sentencePanel.Visible = false;
        //}

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