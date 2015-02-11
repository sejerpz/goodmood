namespace GoodMood
{
    partial class FormAbout
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
            this.components = new System.ComponentModel.Container();
            this.metroLabelVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCopyRight = new MetroFramework.Controls.MetroLabel();
            this.metroLinkWebSite = new MetroFramework.Controls.MetroLink();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelVersion
            // 
            this.metroLabelVersion.AutoSize = true;
            this.metroLabelVersion.Location = new System.Drawing.Point(50, 63);
            this.metroLabelVersion.Name = "metroLabelVersion";
            this.metroLabelVersion.Size = new System.Drawing.Size(119, 19);
            this.metroLabelVersion.TabIndex = 0;
            this.metroLabelVersion.Text = "metroLabelVersion";
            // 
            // metroLabelCopyRight
            // 
            this.metroLabelCopyRight.AutoSize = true;
            this.metroLabelCopyRight.Location = new System.Drawing.Point(50, 97);
            this.metroLabelCopyRight.Name = "metroLabelCopyRight";
            this.metroLabelCopyRight.Size = new System.Drawing.Size(137, 19);
            this.metroLabelCopyRight.TabIndex = 1;
            this.metroLabelCopyRight.Text = "metroLabelCopyRight";
            // 
            // metroLinkWebSite
            // 
            this.metroLinkWebSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkWebSite.Location = new System.Drawing.Point(98, 133);
            this.metroLinkWebSite.Name = "metroLinkWebSite";
            this.metroLinkWebSite.Size = new System.Drawing.Size(146, 23);
            this.metroLinkWebSite.TabIndex = 2;
            this.metroLinkWebSite.Text = "metroLinkWebSite";
            this.metroLinkWebSite.Click += new System.EventHandler(this.metroLinkWebSite_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 179);
            this.Controls.Add(this.metroLinkWebSite);
            this.Controls.Add(this.metroLabelCopyRight);
            this.Controls.Add(this.metroLabelVersion);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "GoodMood";
            this.Click += new System.EventHandler(this.FormAbout_Click);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelVersion;
        private MetroFramework.Controls.MetroLabel metroLabelCopyRight;
        private MetroFramework.Controls.MetroLink metroLinkWebSite;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
    }
}