namespace GoodMood
{
    partial class FormError
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
            this.metroCheckBoxShowDetails = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxDetails = new MetroFramework.Controls.MetroTextBox();
            this.metroLinkReportSend = new MetroFramework.Controls.MetroLink();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCheckBoxShowDetails
            // 
            this.metroCheckBoxShowDetails.AutoSize = true;
            this.metroCheckBoxShowDetails.Location = new System.Drawing.Point(129, 72);
            this.metroCheckBoxShowDetails.Name = "metroCheckBoxShowDetails";
            this.metroCheckBoxShowDetails.Size = new System.Drawing.Size(129, 15);
            this.metroCheckBoxShowDetails.TabIndex = 2;
            this.metroCheckBoxShowDetails.Text = "Show me the details";
            this.metroCheckBoxShowDetails.UseVisualStyleBackColor = true;
            this.metroCheckBoxShowDetails.CheckedChanged += new System.EventHandler(this.metroCheckBoxShowDetails_CheckedChanged);
            // 
            // metroTextBoxDetails
            // 
            this.metroTextBoxDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBoxDetails.Location = new System.Drawing.Point(6, 110);
            this.metroTextBoxDetails.Multiline = true;
            this.metroTextBoxDetails.Name = "metroTextBoxDetails";
            this.metroTextBoxDetails.ReadOnly = true;
            this.metroTextBoxDetails.Size = new System.Drawing.Size(408, 0);
            this.metroTextBoxDetails.TabIndex = 3;
            this.metroTextBoxDetails.Text = "metroTextBoxDetails";
            // 
            // metroLinkReportSend
            // 
            this.metroLinkReportSend.AutoSize = true;
            this.metroLinkReportSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkReportSend.Location = new System.Drawing.Point(284, 68);
            this.metroLinkReportSend.Name = "metroLinkReportSend";
            this.metroLinkReportSend.Size = new System.Drawing.Size(100, 23);
            this.metroLinkReportSend.TabIndex = 5;
            this.metroLinkReportSend.Text = "Send report...";
            this.metroLinkReportSend.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.metroLinkReportSend.Click += new System.EventHandler(this.metroLinkReportSend_Click);
            // 
            // pictureBoxIcon
            // 
            this.pictureBoxIcon.Image = global::GoodMood.Properties.Resources.Oops96;
            this.pictureBoxIcon.Location = new System.Drawing.Point(6, 8);
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.Size = new System.Drawing.Size(96, 96);
            this.pictureBoxIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxIcon.TabIndex = 4;
            this.pictureBoxIcon.TabStop = false;
            // 
            // FormError
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(420, 110);
            this.Controls.Add(this.metroLinkReportSend);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.metroTextBoxDetails);
            this.Controls.Add(this.metroCheckBoxShowDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(420, 110);
            this.Name = "FormError";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
            this.Text = "              Oops an error occurred...";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroCheckBox metroCheckBoxShowDetails;
        private MetroFramework.Controls.MetroTextBox metroTextBoxDetails;
        private System.Windows.Forms.PictureBox pictureBoxIcon;
        private MetroFramework.Controls.MetroLink metroLinkReportSend;
    }
}