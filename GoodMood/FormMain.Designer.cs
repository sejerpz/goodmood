namespace GoodMood
{
    partial class FormMain
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.metroLabelTitle = new MetroFramework.Controls.MetroLabel();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroProgressSpinnerLoader = new MetroFramework.Controls.MetroProgressSpinner();
            this.contextMenuStripMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemSetWallpaper = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroToolTips = new MetroFramework.Components.MetroToolTip();
            this.pictureBoxDonate = new System.Windows.Forms.PictureBox();
            this.contextMenuStripDonate = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItemDonatePayPal = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxSettings = new System.Windows.Forms.PictureBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.contextMenuStripMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).BeginInit();
            this.contextMenuStripDonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // metroLabelTitle
            // 
            resources.ApplyResources(this.metroLabelTitle, "metroLabelTitle");
            this.metroLabelTitle.Name = "metroLabelTitle";
            this.metroToolTips.SetToolTip(this.metroLabelTitle, resources.GetString("metroLabelTitle.ToolTip"));
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // metroProgressSpinnerLoader
            // 
            resources.ApplyResources(this.metroProgressSpinnerLoader, "metroProgressSpinnerLoader");
            this.metroProgressSpinnerLoader.Maximum = 100;
            this.metroProgressSpinnerLoader.Name = "metroProgressSpinnerLoader";
            this.metroToolTips.SetToolTip(this.metroProgressSpinnerLoader, resources.GetString("metroProgressSpinnerLoader.ToolTip"));
            // 
            // contextMenuStripMain
            // 
            resources.ApplyResources(this.contextMenuStripMain, "contextMenuStripMain");
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRefresh,
            this.toolStripMenuItemSetWallpaper,
            this.toolStripMenuItem1,
            this.toolStripMenuItemSettings,
            this.toolStripMenuItem2,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExit});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.metroToolTips.SetToolTip(this.contextMenuStripMain, resources.GetString("contextMenuStripMain.ToolTip"));
            // 
            // toolStripMenuItemRefresh
            // 
            resources.ApplyResources(this.toolStripMenuItemRefresh, "toolStripMenuItemRefresh");
            this.toolStripMenuItemRefresh.Name = "toolStripMenuItemRefresh";
            this.toolStripMenuItemRefresh.Click += new System.EventHandler(this.toolStripMenuItemRefresh_Click);
            // 
            // toolStripMenuItemSetWallpaper
            // 
            resources.ApplyResources(this.toolStripMenuItemSetWallpaper, "toolStripMenuItemSetWallpaper");
            this.toolStripMenuItemSetWallpaper.Name = "toolStripMenuItemSetWallpaper";
            this.toolStripMenuItemSetWallpaper.Click += new System.EventHandler(this.toolStripMenuItemSetWallpaper_Click);
            // 
            // toolStripMenuItem1
            // 
            resources.ApplyResources(this.toolStripMenuItem1, "toolStripMenuItem1");
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            // 
            // toolStripMenuItemSettings
            // 
            resources.ApplyResources(this.toolStripMenuItemSettings, "toolStripMenuItemSettings");
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.toolStripMenuItemSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            resources.ApplyResources(this.toolStripMenuItem2, "toolStripMenuItem2");
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            // 
            // toolStripMenuItemAbout
            // 
            resources.ApplyResources(this.toolStripMenuItemAbout, "toolStripMenuItemAbout");
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemExit
            // 
            resources.ApplyResources(this.toolStripMenuItemExit, "toolStripMenuItemExit");
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // notifyIcon
            // 
            resources.ApplyResources(this.notifyIcon, "notifyIcon");
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripMain;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // pictureBoxDonate
            // 
            resources.ApplyResources(this.pictureBoxDonate, "pictureBoxDonate");
            this.pictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate.Image = global::GoodMood.Properties.Resources.Donate14;
            this.pictureBoxDonate.Name = "pictureBoxDonate";
            this.pictureBoxDonate.TabStop = false;
            this.metroToolTips.SetToolTip(this.pictureBoxDonate, resources.GetString("pictureBoxDonate.ToolTip"));
            this.pictureBoxDonate.EnabledChanged += new System.EventHandler(this.pictureBoxDonate_EnabledChanged);
            this.pictureBoxDonate.Click += new System.EventHandler(this.pictureBoxDonate_Click);
            // 
            // contextMenuStripDonate
            // 
            resources.ApplyResources(this.contextMenuStripDonate, "contextMenuStripDonate");
            this.contextMenuStripDonate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDonatePayPal});
            this.contextMenuStripDonate.Name = "contextMenuStripDonate";
            this.metroToolTips.SetToolTip(this.contextMenuStripDonate, resources.GetString("contextMenuStripDonate.ToolTip"));
            // 
            // toolStripMenuItemDonatePayPal
            // 
            resources.ApplyResources(this.toolStripMenuItemDonatePayPal, "toolStripMenuItemDonatePayPal");
            this.toolStripMenuItemDonatePayPal.Image = global::GoodMood.Properties.Resources.Paypal16;
            this.toolStripMenuItemDonatePayPal.Name = "toolStripMenuItemDonatePayPal";
            this.toolStripMenuItemDonatePayPal.Click += new System.EventHandler(this.toolStripMenuItemDonatePayPal_Click);
            // 
            // pictureBoxSettings
            // 
            resources.ApplyResources(this.pictureBoxSettings, "pictureBoxSettings");
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxSettings.Image = global::GoodMood.Properties.Resources.Edit14;
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.TabStop = false;
            this.metroToolTips.SetToolTip(this.pictureBoxSettings, resources.GetString("pictureBoxSettings.ToolTip"));
            this.pictureBoxSettings.EnabledChanged += new System.EventHandler(this.pictureBoxSettings_EnabledChanged);
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // pictureBoxPreview
            // 
            resources.ApplyResources(this.pictureBoxPreview, "pictureBoxPreview");
            this.pictureBoxPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.TabStop = false;
            this.metroToolTips.SetToolTip(this.pictureBoxPreview, resources.GetString("pictureBoxPreview.ToolTip"));
            this.pictureBoxPreview.Click += new System.EventHandler(this.pictureBoxPreview_Click);
            this.pictureBoxPreview.Resize += new System.EventHandler(this.pictureBoxPreview_Resize);
            // 
            // FormMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBoxDonate);
            this.Controls.Add(this.metroProgressSpinnerLoader);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.metroLabelTitle);
            this.Controls.Add(this.pictureBoxPreview);
            this.Name = "FormMain";
            this.metroToolTips.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.contextMenuStripMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxDonate)).EndInit();
            this.contextMenuStripDonate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private MetroFramework.Controls.MetroLabel metroLabelTitle;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender;
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroProgressSpinner metroProgressSpinnerLoader;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMain;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemRefresh;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSetWallpaper;
        private System.Windows.Forms.PictureBox pictureBoxSettings;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemExit;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemSettings;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.PictureBox pictureBoxDonate;
        private MetroFramework.Components.MetroToolTip metroToolTips;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripDonate;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemDonatePayPal;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
    }
}

