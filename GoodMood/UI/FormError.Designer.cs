namespace GoodMood.UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormError));
            this.metroCheckBoxShowDetails = new MetroFramework.Controls.MetroCheckBox();
            this.metroTextBoxDetails = new MetroFramework.Controls.MetroTextBox();
            this.metroLinkReportSend = new MetroFramework.Controls.MetroLink();
            this.pictureBoxIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // metroCheckBoxShowDetails
            // 
            resources.ApplyResources(this.metroCheckBoxShowDetails, "metroCheckBoxShowDetails");
            this.metroCheckBoxShowDetails.Name = "metroCheckBoxShowDetails";
            this.metroCheckBoxShowDetails.UseVisualStyleBackColor = true;
            this.metroCheckBoxShowDetails.CheckedChanged += new System.EventHandler(this.metroCheckBoxShowDetails_CheckedChanged);
            // 
            // metroTextBoxDetails
            // 
            resources.ApplyResources(this.metroTextBoxDetails, "metroTextBoxDetails");
            this.metroTextBoxDetails.Multiline = true;
            this.metroTextBoxDetails.Name = "metroTextBoxDetails";
            this.metroTextBoxDetails.ReadOnly = true;
            // 
            // metroLinkReportSend
            // 
            resources.ApplyResources(this.metroLinkReportSend, "metroLinkReportSend");
            this.metroLinkReportSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkReportSend.Name = "metroLinkReportSend";
            this.metroLinkReportSend.Click += new System.EventHandler(this.metroLinkReportSend_Click);
            // 
            // pictureBoxIcon
            // 
            resources.ApplyResources(this.pictureBoxIcon, "pictureBoxIcon");
            this.pictureBoxIcon.Image = global::GoodMood.Properties.Resources.Oops96;
            this.pictureBoxIcon.Name = "pictureBoxIcon";
            this.pictureBoxIcon.TabStop = false;
            // 
            // FormError
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.Controls.Add(this.metroLinkReportSend);
            this.Controls.Add(this.pictureBoxIcon);
            this.Controls.Add(this.metroTextBoxDetails);
            this.Controls.Add(this.metroCheckBoxShowDetails);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormError";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Red;
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