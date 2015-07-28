namespace AutoComplete
{
    partial class Form1
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
            this.ultraFormattedTextEditor1 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.ultraFormattedTextEditor2 = new Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor();
            this.SuspendLayout();
            // 
            // ultraFormattedTextEditor1
            // 
            this.ultraFormattedTextEditor1.Location = new System.Drawing.Point(16, 36);
            this.ultraFormattedTextEditor1.Name = "ultraFormattedTextEditor1";
            this.ultraFormattedTextEditor1.Size = new System.Drawing.Size(621, 119);
            this.ultraFormattedTextEditor1.TabIndex = 1;
            this.ultraFormattedTextEditor1.Value = "";
            this.ultraFormattedTextEditor1.TextChanged += new System.EventHandler(this.ultraFormattedTextEditor1_TextChanged);
            // 
            // ultraFormattedTextEditor2
            // 
            this.ultraFormattedTextEditor2.Location = new System.Drawing.Point(16, 171);
            this.ultraFormattedTextEditor2.Name = "ultraFormattedTextEditor2";
            this.ultraFormattedTextEditor2.Size = new System.Drawing.Size(164, 168);
            this.ultraFormattedTextEditor2.TabIndex = 2;
            this.ultraFormattedTextEditor2.Value = new Infragistics.Win.FormattedLinkLabel.ParsedFormattedTextValue("ultraFormattedTextEditor2");
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 351);
            this.Controls.Add(this.ultraFormattedTextEditor2);
            this.Controls.Add(this.ultraFormattedTextEditor1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor ultraFormattedTextEditor1;
        private Infragistics.Win.FormattedLinkLabel.UltraFormattedTextEditor ultraFormattedTextEditor2;
    }
}

