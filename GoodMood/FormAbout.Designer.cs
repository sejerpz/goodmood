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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.metroLabelVersion = new MetroFramework.Controls.MetroLabel();
            this.metroLabelCopyRight = new MetroFramework.Controls.MetroLabel();
            this.metroLinkWebSite = new MetroFramework.Controls.MetroLink();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroLinkCheckUpdates = new MetroFramework.Controls.MetroLink();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelVersion
            // 
            resources.ApplyResources(this.metroLabelVersion, "metroLabelVersion");
            this.metroLabelVersion.Name = "metroLabelVersion";
            // 
            // metroLabelCopyRight
            // 
            resources.ApplyResources(this.metroLabelCopyRight, "metroLabelCopyRight");
            this.metroLabelCopyRight.Name = "metroLabelCopyRight";
            // 
            // metroLinkWebSite
            // 
            resources.ApplyResources(this.metroLinkWebSite, "metroLinkWebSite");
            this.metroLinkWebSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkWebSite.Name = "metroLinkWebSite";
            this.metroLinkWebSite.Click += new System.EventHandler(this.metroLinkWebSite_Click);
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // metroLinkCheckUpdates
            // 
            resources.ApplyResources(this.metroLinkCheckUpdates, "metroLinkCheckUpdates");
            this.metroLinkCheckUpdates.Cursor = System.Windows.Forms.Cursors.Hand;
            this.metroLinkCheckUpdates.Name = "metroLinkCheckUpdates";
            this.metroLinkCheckUpdates.Click += new System.EventHandler(this.metroLinkCheckUpdates_Click);
            // 
            // FormAbout
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroLinkCheckUpdates);
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
        private MetroFramework.Controls.MetroLink metroLinkCheckUpdates;
    }
}