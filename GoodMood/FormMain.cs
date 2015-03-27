/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using Microsoft.Win32;
using System.Threading;
using System.Net;
using GoodMood.Properties;
using GoodMood.UI;
using GoodMood.Photo;
using GoodMood.Utility;
using GoodMood.Extensions;

namespace GoodMood
{
    public partial class FormMain : MetroForm
    {
        private PhotoManager pictureManager;
        private bool closeByMenu = false;
        private CommandlineOptions startupOptions;
        private FormTrayTooltip customTooltip = null;
        private System.Windows.Forms.Timer toolTipTimer;
        private Rectangle trayIconSinsitiveArea = Rectangle.Empty;

        private FormMain()
        {
            InitializeComponent();
            
        }

        public FormMain(CommandlineOptions startupOptions)
            : this()
        {
            try
            {
                this.startupOptions = startupOptions;
                Windows.UpgradeSettings();
                Windows.SetLaunchAtStartup(Properties.Settings.Default.LaunchAtStartup);
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }

            this.pictureManager = new PhotoManager(new NasaPhotoUri());
            this.pictureManager.PictureUpdateBegin += pictureManager_PictureUpdateBegin;
            this.pictureManager.PictureUpdateSuccess += pictureManager_PictureUpdateSuccess;
            this.pictureManager.PictureUpdateEnd += pictureManager_PictureUpdateEnd;
            this.pictureManager.PictureUpdateError += pictureManager_PictureUpdateError;

            if (Properties.Settings.Default.CheckPictureUpdate)
            {
                this.pictureManager.Start();
            }
            else
            {
                metroProgressSpinnerLoader.Visible = metroProgressSpinnerLoader.Spinning = false;
                metroLabelTitle.Text = Strings.SelectRefreshInfo;
            }

            Application.Idle += Application_Idle;

            this.toolTipTimer = new System.Windows.Forms.Timer(this.components);
            this.toolTipTimer.Interval = 1250;
            this.toolTipTimer.Tick += toolTipTimer_Tick;
        }

        void Application_Idle(object sender, EventArgs e)
        {
            Application.Idle -= Application_Idle;
            ProcessCommandlineOptions();
        }

        private void ProcessCommandlineOptions()
        {
            if (startupOptions.Quiet)
                this.HideToTrayArea();
        }

        private async void UpdatePicture()
        {
            await pictureManager.Update();
        }

        private void OnPictureUpdateBegin(PhotoManager pictureManager)
        {
            pictureBoxDonate.Enabled = pictureBoxSettings.Enabled = false;
            metroLabelTitle.Text = string.Format(Strings.UpdateInProgressInfo, pictureManager.Uri.ProviderDescription);
            metroProgressSpinnerLoader.Visible = metroProgressSpinnerLoader.Spinning = true;
            pictureBoxPreview.Enabled = false;
        }

        private void OnPictureUpdateSuccess(PhotoManager pictureManager)
        {
            try
            {
                pictureBoxPreview.Image = pictureManager.Image;
                metroToolTips.SetToolTip(pictureBoxPreview, string.Format(Strings.GoToProviderWebSite, pictureManager.Uri.ProviderDescription));
                pictureBoxPreview.Cursor = Cursors.Hand;
                this.toolStripMenuItemSetWallpaper.Enabled = true;
                metroLabelTitle.Text = pictureManager.Uri.PhotoDescription ?? "";

                if (customTooltip != null && !customTooltip.IsDisposed)
                {
                    customTooltip.UpdateInfo(pictureBoxPreview.Image, metroLabelTitle.Text);
                }

                if (pictureManager.Image != null)
                {
                    if (Properties.Settings.Default.SetBackground)
                    {
                        SetWallpaper(pictureManager.Image);
                    }
                }
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private Image PreparePicture(Image image)
        {
            if (Properties.Settings.Default.FillBackground)
            {
                Screen screen = null;

                // get the screen with the biggest area
                foreach(var item in Screen.AllScreens)
                {
                    if (screen == null || (item.Bounds.Width * item.Bounds.Height) > (screen.Bounds.Width * screen.Bounds.Height))
                        screen = item;
                }

                var wallpaper = new Bitmap(screen.Bounds.Width, screen.Bounds.Height);
                var color = new ColorFinder(
                    string.Compare(Properties.Settings.Default.FillColorMode, "bright", true) == 0 ? 
                        ColorFinder.FavorBrightCallback : ColorFinder.FavorDarkCallback
                    ).GetMostProminentColor(new Bitmap(image));

                using(var graphics = Graphics.FromImage(wallpaper))
                {
                    int x = Math.Max(0, (wallpaper.Width - image.Width) / 2);
                    int y = Math.Max(0, (wallpaper.Height - image.Height) / 2);
                    var r = new Rectangle (x, y, Math.Min(image.Width + 8, wallpaper.Width), Math.Min(image.Height + 8, wallpaper.Width));

                    graphics.Clear(color);
                    graphics.DrawShadow(r);
                    graphics.DrawImage(image,x, y, image.Width, image.Height);
                }
                return wallpaper;
            }
            else
                return image;
        }

        private void OnPictureUpdateEnd(PhotoManager pictureManager)
        {
            try
            {
                metroProgressSpinnerLoader.Enabled = true;
                metroProgressSpinnerLoader.Visible = metroProgressSpinnerLoader.Spinning = false;
                pictureBoxPreview.Enabled = true;
                pictureBoxDonate.Enabled = pictureBoxSettings.Enabled = true;
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private void SetWallpaper(Image image)
        {
            try
            {
                Wallpaper.Set(PreparePicture(image), Wallpaper.Style.None);
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        #region Intercept Suspend & Resume Power Events
        public const int WM_POWERBROADCAST = 0x0218;
        public const int PBT_APMQUERYSUSPEND = 0x0000;
        public const int PBT_APMRESUMESUSPEND = 0x0007;

        protected override void WndProc(ref Message m)
        {
            switch (m.Msg)
            {
                case WM_POWERBROADCAST:
                    switch (m.WParam.ToInt32())
                    {
                        //value passed when system is going on standby / suspended
                        case PBT_APMQUERYSUSPEND:
                            if (pictureManager.IsRunning)
                            {
                                pictureManager.Stop();
                            }
                            break;
                        //value passed when system is resumed after suspension.
                        case PBT_APMRESUMESUSPEND:
                            if (Properties.Settings.Default.CheckPictureUpdate)
                            {
                                pictureManager.Start();
                            }
                            break;
                    }
                    break;
                default:
                    break;
            }
            base.WndProc(ref m);
        }
        #endregion

        private void pictureManager_PictureUpdateBegin(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                OnPictureUpdateBegin((PhotoManager)sender);
            }));
        }

        private void pictureManager_PictureUpdateEnd(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => 
            { 
                OnPictureUpdateEnd((PhotoManager)sender); 
            }));
        }

        private void pictureManager_PictureUpdateSuccess(object sender, EventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                OnPictureUpdateSuccess((PhotoManager)sender);
            }));
        }

        private void pictureManager_PictureUpdateError(object sender, ThreadExceptionEventArgs e)
        {
            this.Invoke(new Action(() =>
            {
                var wex = e.Exception as WebException;

                if (wex != null
                    && (wex.Status == WebExceptionStatus.NameResolutionFailure
                    || wex.Status == WebExceptionStatus.Timeout
                    || wex.Status == WebExceptionStatus.ConnectFailure
                    || wex.Status == WebExceptionStatus.ProtocolError))
                {
                    this.pictureBoxPreview.Image = Resources.NoInternet225;
                    this.pictureBoxPreview.Cursor = Cursors.Default;
                    this.metroToolTips.SetToolTip(pictureBoxPreview, "");
                    this.metroLabelTitle.Text = Strings.CheckYourInternetConnection;
                    this.toolStripMenuItemSetWallpaper.Enabled = false;
                }
                else
                {
                    Interaction.Error(e.Exception);
                }
            }));
        }

        private void toolStripMenuItemRefresh_Click(object sender, EventArgs e)
        {
            UpdatePicture();
        }

        private void pictureBoxSettings_Click(object sender, EventArgs e)
        {
            contextMenuStripMain.Show(pictureBoxSettings, new Point(0, pictureBoxSettings.Height + 1));
        }


        private void pictureBoxDonate_Click(object sender, EventArgs e)
        {
            contextMenuStripDonate.Show(pictureBoxDonate, new Point(0, pictureBoxDonate.Height + 1));
        }

        private void pictureBoxPreview_Resize(object sender, EventArgs e)
        {
            metroProgressSpinnerLoader.Location = new Point(
                pictureBoxPreview.Left + (pictureBoxPreview.Width - metroProgressSpinnerLoader.Width) / 2,
                pictureBoxPreview.Top + (pictureBoxPreview.Height - metroProgressSpinnerLoader.Height) / 2);
        }

        private void toolStripMenuItemSetWallpaper_Click(object sender, EventArgs e)
        {
            SetWallpaper(pictureManager.Image);
        }

        private void toolStripMenuItemExit_Click(object sender, EventArgs e)
        {
            if (this.pictureManager.IsRunning)
                this.pictureManager.Stop();

            closeByMenu = true;
            this.Close();
        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                this.Visible = !this.Visible;
            }
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing && !closeByMenu)
            {
                e.Cancel = true;
                HideToTrayArea();
            }
        }

        private void HideToTrayArea()
        {
            this.Visible = false;
            notifyIcon.ShowBalloonTip(1000, this.Text, Strings.TrayHideInfo, ToolTipIcon.Info);
        }

        private void pictureBoxSettings_EnabledChanged(object sender, EventArgs e)
        {
            contextMenuStripMain.Enabled = pictureBoxSettings.Enabled;
            pictureBoxSettings.Image = pictureBoxSettings.Enabled ? Properties.Resources.Edit14 : Properties.Resources.Edit14Disabled;
        }
    
        private void toolStripMenuItemAbout_Click(object sender, EventArgs e)
        {
            using(var formAbout = new FormAbout())
            {
                formAbout.ShowDialog();
            }
        }

        private void pictureBoxDonate_EnabledChanged(object sender, EventArgs e)
        {
            pictureBoxDonate.Image = pictureBoxDonate.Enabled ? Properties.Resources.Donate14 : Properties.Resources.Donate14Disabled;
        }

        private void toolStripMenuItemDonatePayPal_Click(object sender, EventArgs e)
        {
            DonatePayPay();
        }

        private void DonatePayPay()
        {
            try
            {
                string url = "";

                string business = "sejerpz@gmail.com";
                string description = "Donation%20for%20GoodMood%20";
                string country = "IT";   
                string currency = "EUR"; 

                url += "https://www.paypal.com/cgi-bin/webscr" +
                    "?cmd=" + "_donations" +
                    "&business=" + business +
                    "&lc=" + country +
                    "&item_name=" + description +
                    "&currency_code=" + currency +
                    "&bn=" + "PP%2dDonationsBF";

                System.Diagnostics.Process.Start(url);
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private void pictureBoxPreview_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(pictureManager.Uri.WebSiteAddress);
        }

        private void notifyIcon_MouseMove(object sender, MouseEventArgs e)
        {
            ShowCustomTooltip(e);
        }

        private void ShowCustomTooltip(MouseEventArgs e)
        {
            if (customTooltip == null || customTooltip.IsDisposed)
            {
                if (!this.toolTipTimer.Enabled)
                {
                    this.toolTipTimer.Start();
                    trayIconSinsitiveArea = new Rectangle(Control.MousePosition, new Size(16, 16));
                    trayIconSinsitiveArea.Inflate(12, 12);
                }
            }
            else
            {
                // still receiving move events
                customTooltip.StayVisible();
            }
        }

        private void toolTipTimer_Tick(object sender, EventArgs e)
        {
            toolTipTimer.Stop();
            var mouse = Control.MousePosition;
            if (trayIconSinsitiveArea.Contains(mouse))
            {
                customTooltip = new FormTrayTooltip();
                var screen = Screen.PrimaryScreen;
                customTooltip.Location = new Point(screen.WorkingArea.Width - customTooltip.Width - 2, screen.WorkingArea.Height - customTooltip.Height - 2);
                customTooltip.UpdateInfo(pictureBoxPreview.Image, metroLabelTitle.Text);
                customTooltip.Show();
                customTooltip.StayVisible();
            }
        }

        private void toolStripMenuItemSettings_Click(object sender, EventArgs e)
        {
            using(var formSettings = new FormSettings())
            {
                formSettings.ShowDialog();
            }
        }
    }
}
