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
            this.metroLabelTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelTitle.Location = new System.Drawing.Point(23, 431);
            this.metroLabelTitle.Name = "metroLabelTitle";
            this.metroLabelTitle.Size = new System.Drawing.Size(454, 23);
            this.metroLabelTitle.TabIndex = 1;
            this.metroLabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = null;
            // 
            // metroProgressSpinnerLoader
            // 
            this.metroProgressSpinnerLoader.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.metroProgressSpinnerLoader.Location = new System.Drawing.Point(224, 218);
            this.metroProgressSpinnerLoader.Maximum = 100;
            this.metroProgressSpinnerLoader.MaximumSize = new System.Drawing.Size(96, 96);
            this.metroProgressSpinnerLoader.MinimumSize = new System.Drawing.Size(48, 48);
            this.metroProgressSpinnerLoader.Name = "metroProgressSpinnerLoader";
            this.metroProgressSpinnerLoader.Size = new System.Drawing.Size(48, 48);
            this.metroProgressSpinnerLoader.TabIndex = 0;
            // 
            // contextMenuStripMain
            // 
            this.contextMenuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemRefresh,
            this.toolStripMenuItemSetWallpaper,
            this.toolStripMenuItem1,
            this.toolStripMenuItemSettings,
            this.toolStripMenuItem2,
            this.toolStripMenuItemAbout,
            this.toolStripMenuItemExit});
            this.contextMenuStripMain.Name = "contextMenuStripMain";
            this.contextMenuStripMain.Size = new System.Drawing.Size(217, 148);
            // 
            // toolStripMenuItemRefresh
            // 
            this.toolStripMenuItemRefresh.Name = "toolStripMenuItemRefresh";
            this.toolStripMenuItemRefresh.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemRefresh.Text = "Refresh";
            this.toolStripMenuItemRefresh.Click += new System.EventHandler(this.toolStripMenuItemRefresh_Click);
            // 
            // toolStripMenuItemSetWallpaper
            // 
            this.toolStripMenuItemSetWallpaper.Name = "toolStripMenuItemSetWallpaper";
            this.toolStripMenuItemSetWallpaper.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemSetWallpaper.Text = "Set as desktop background";
            this.toolStripMenuItemSetWallpaper.Click += new System.EventHandler(this.toolStripMenuItemSetWallpaper_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripMenuItemSettings
            // 
            this.toolStripMenuItemSettings.Name = "toolStripMenuItemSettings";
            this.toolStripMenuItemSettings.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemSettings.Text = "Settings...";
            this.toolStripMenuItemSettings.Click += new System.EventHandler(this.toolStripMenuItemSettings_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(213, 6);
            // 
            // toolStripMenuItemAbout
            // 
            this.toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            this.toolStripMenuItemAbout.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemAbout.Text = "About...";
            this.toolStripMenuItemAbout.Click += new System.EventHandler(this.toolStripMenuItemAbout_Click);
            // 
            // toolStripMenuItemExit
            // 
            this.toolStripMenuItemExit.Name = "toolStripMenuItemExit";
            this.toolStripMenuItemExit.Size = new System.Drawing.Size(216, 22);
            this.toolStripMenuItemExit.Text = "Exit";
            this.toolStripMenuItemExit.Click += new System.EventHandler(this.toolStripMenuItemExit_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.contextMenuStripMain;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseClick);
            this.notifyIcon.MouseMove += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseMove);
            // 
            // pictureBoxDonate
            // 
            this.pictureBoxDonate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxDonate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxDonate.Image = global::GoodMood.Properties.Resources.Donate14;
            this.pictureBoxDonate.Location = new System.Drawing.Point(392, 8);
            this.pictureBoxDonate.Name = "pictureBoxDonate";
            this.pictureBoxDonate.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxDonate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxDonate.TabIndex = 8;
            this.pictureBoxDonate.TabStop = false;
            this.metroToolTips.SetToolTip(this.pictureBoxDonate, "Support this App, please make a donation!");
            this.pictureBoxDonate.EnabledChanged += new System.EventHandler(this.pictureBoxDonate_EnabledChanged);
            this.pictureBoxDonate.Click += new System.EventHandler(this.pictureBoxDonate_Click);
            // 
            // contextMenuStripDonate
            // 
            this.contextMenuStripDonate.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemDonatePayPal});
            this.contextMenuStripDonate.Name = "contextMenuStripDonate";
            this.contextMenuStripDonate.Size = new System.Drawing.Size(186, 26);
            // 
            // toolStripMenuItemDonatePayPal
            // 
            this.toolStripMenuItemDonatePayPal.Image = global::GoodMood.Properties.Resources.Paypal16;
            this.toolStripMenuItemDonatePayPal.Name = "toolStripMenuItemDonatePayPal";
            this.toolStripMenuItemDonatePayPal.Size = new System.Drawing.Size(185, 22);
            this.toolStripMenuItemDonatePayPal.Text = "Donate with PayPal...";
            this.toolStripMenuItemDonatePayPal.Click += new System.EventHandler(this.toolStripMenuItemDonatePayPal_Click);
            // 
            // pictureBoxSettings
            // 
            this.pictureBoxSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxSettings.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxSettings.Image = global::GoodMood.Properties.Resources.Edit14;
            this.pictureBoxSettings.Location = new System.Drawing.Point(368, 8);
            this.pictureBoxSettings.Name = "pictureBoxSettings";
            this.pictureBoxSettings.Size = new System.Drawing.Size(14, 14);
            this.pictureBoxSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxSettings.TabIndex = 7;
            this.pictureBoxSettings.TabStop = false;
            this.pictureBoxSettings.EnabledChanged += new System.EventHandler(this.pictureBoxSettings_EnabledChanged);
            this.pictureBoxSettings.Click += new System.EventHandler(this.pictureBoxSettings_Click);
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPreview.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxPreview.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pictureBoxPreview.Location = new System.Drawing.Point(23, 65);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(454, 365);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 0;
            this.pictureBoxPreview.TabStop = false;
            this.pictureBoxPreview.Click += new System.EventHandler(this.pictureBoxPreview_Click);
            this.pictureBoxPreview.Resize += new System.EventHandler(this.pictureBoxPreview_Resize);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.pictureBoxDonate);
            this.Controls.Add(this.metroProgressSpinnerLoader);
            this.Controls.Add(this.pictureBoxSettings);
            this.Controls.Add(this.metroLabelTitle);
            this.Controls.Add(this.pictureBoxPreview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "Good Mood";
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

