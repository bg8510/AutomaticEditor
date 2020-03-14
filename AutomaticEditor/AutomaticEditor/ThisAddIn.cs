﻿using System;
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
        private SidePanel sidePanel;
        public Microsoft.Office.Tools.CustomTaskPane customPanel;

        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            sidePanel = new SidePanel();
            customPanel = this.CustomTaskPanes.Add(sidePanel, "Cactus Editor");
            customPanel.Visible = true;
        }

        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
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