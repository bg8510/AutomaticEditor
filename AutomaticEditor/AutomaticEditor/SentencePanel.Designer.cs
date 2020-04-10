namespace AutomaticEditor
{
    public partial class SentencePanel
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
            this.OriginalSentence = new System.Windows.Forms.TextBox();
            this.EditedSentence = new System.Windows.Forms.TextBox();
            this.RejectEdit = new System.Windows.Forms.Button();
            this.ApplyEdit = new System.Windows.Forms.Button();
            this.ErrorMessage = new System.Windows.Forms.TextBox();
            this.StartEdit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OriginalSentence
            // 
            this.OriginalSentence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OriginalSentence.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OriginalSentence.Location = new System.Drawing.Point(3, 28);
            this.OriginalSentence.Multiline = true;
            this.OriginalSentence.Name = "OriginalSentence";
            this.OriginalSentence.Size = new System.Drawing.Size(1617, 44);
            this.OriginalSentence.TabIndex = 0;
            // 
            // EditedSentence
            // 
            this.EditedSentence.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditedSentence.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditedSentence.Location = new System.Drawing.Point(3, 71);
            this.EditedSentence.Multiline = true;
            this.EditedSentence.Name = "EditedSentence";
            this.EditedSentence.Size = new System.Drawing.Size(1617, 44);
            this.EditedSentence.TabIndex = 1;
            // 
            // RejectEdit
            // 
            this.RejectEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.RejectEdit.BackColor = System.Drawing.Color.Tomato;
            this.RejectEdit.Enabled = false;
            this.RejectEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RejectEdit.Location = new System.Drawing.Point(524, 119);
            this.RejectEdit.Name = "RejectEdit";
            this.RejectEdit.Size = new System.Drawing.Size(203, 44);
            this.RejectEdit.TabIndex = 2;
            this.RejectEdit.Text = "Reject > Next";
            this.RejectEdit.UseVisualStyleBackColor = false;
            this.RejectEdit.Click += new System.EventHandler(this.RejectEdit_Click);
            // 
            // ApplyEdit
            // 
            this.ApplyEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.ApplyEdit.BackColor = System.Drawing.Color.GreenYellow;
            this.ApplyEdit.Enabled = false;
            this.ApplyEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApplyEdit.Location = new System.Drawing.Point(924, 119);
            this.ApplyEdit.Name = "ApplyEdit";
            this.ApplyEdit.Size = new System.Drawing.Size(152, 44);
            this.ApplyEdit.TabIndex = 3;
            this.ApplyEdit.Text = "Apply Edit";
            this.ApplyEdit.UseVisualStyleBackColor = false;
            this.ApplyEdit.Click += new System.EventHandler(this.ApplyEdit_Click);
            // 
            // ErrorMessage
            // 
            this.ErrorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorMessage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ErrorMessage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ErrorMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErrorMessage.ImeMode = System.Windows.Forms.ImeMode.On;
            this.ErrorMessage.Location = new System.Drawing.Point(7, 6);
            this.ErrorMessage.Name = "ErrorMessage";
            this.ErrorMessage.Size = new System.Drawing.Size(1612, 15);
            this.ErrorMessage.TabIndex = 4;
            // 
            // StartEdit
            // 
            this.StartEdit.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.StartEdit.BackColor = System.Drawing.Color.GreenYellow;
            this.StartEdit.Enabled = false;
            this.StartEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartEdit.Location = new System.Drawing.Point(1311, 119);
            this.StartEdit.Name = "StartEdit";
            this.StartEdit.Size = new System.Drawing.Size(148, 43);
            this.StartEdit.TabIndex = 5;
            this.StartEdit.Text = "Start";
            this.StartEdit.UseVisualStyleBackColor = false;
            this.StartEdit.Click += new System.EventHandler(this.StartEdit_Click);
            // 
            // SentencePanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.StartEdit);
            this.Controls.Add(this.ErrorMessage);
            this.Controls.Add(this.ApplyEdit);
            this.Controls.Add(this.RejectEdit);
            this.Controls.Add(this.EditedSentence);
            this.Controls.Add(this.OriginalSentence);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "SentencePanel";
            this.Size = new System.Drawing.Size(1623, 169);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OriginalSentence;
        private System.Windows.Forms.TextBox EditedSentence;
        private System.Windows.Forms.Button RejectEdit;
        private System.Windows.Forms.Button ApplyEdit;
        private System.Windows.Forms.TextBox ErrorMessage;
        private System.Windows.Forms.Button StartEdit;
    }
}
