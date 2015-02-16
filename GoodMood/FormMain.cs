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

namespace GoodMood
{
    public partial class FormMain : MetroForm
    {
        private PictureManager pictureManager;
        private bool closeByMenu = false;
        private CommandlineOptions startupOptions;

        private FormMain()
        {
            InitializeComponent();
            
        }

        public FormMain(CommandlineOptions startupOptions)
            : this()
        {
            try
            {
                this.notifyIcon.Text = this.Text;
                this.startupOptions = startupOptions;
                ReadSettings();
                
                SynchronizeLaunchAtStartup(Properties.Settings.Default.LaunchAtStartup);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error ({0}): {1}", ex.GetType().Name, ex.Message));
            }

            this.pictureManager = new PictureManager(new NationalGeographicPoDPictureUri());
            this.pictureManager.PictureUpdateBegin += pictureManager_PictureUpdateBegin;
            this.pictureManager.PictureUpdateEnd += pictureInfo_PictureUpdateEnd;
            if (Properties.Settings.Default.CheckPictureUpdate)
            {
                this.pictureManager.Start();
            }
            else
            {
                metroProgressSpinnerLoader.Visible = metroProgressSpinnerLoader.Spinning = false;
                metroLabelTitle.Text = "select 'refresh' menu' item to update the picture";
            }

            Application.Idle += Application_Idle;
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

        private void OnPictureUpdateBegin(PictureManager pictureManager)
        {
            pictureBoxDonate.Enabled = pictureBoxSettings.Enabled = false;
            notifyIcon.Text = metroLabelTitle.Text = "updating national geographic picture of the day...";
            metroProgressSpinnerLoader.Visible = metroProgressSpinnerLoader.Spinning = true;
            pictureBoxPreview.Enabled = false;
        }

        private void OnPictureUpdateEnd(PictureManager pictureManager)
        {
            try
            {
                metroProgressSpinnerLoader.Enabled = true;
                metroProgressSpinnerLoader.Visible = metroProgressSpinnerLoader.Spinning = false;
                pictureBoxPreview.Enabled = true;
                pictureBoxPreview.Image = pictureManager.Image;
                metroLabelTitle.Text = pictureManager.Uri.Description ?? "";
                pictureBoxDonate.Enabled = pictureBoxSettings.Enabled = true;
                string toolTip = metroLabelTitle.Text;
                if (toolTip.Length > 63)
                {
                    if (toolTip.StartsWith("Picture of ", StringComparison.CurrentCultureIgnoreCase))
                    {
                        toolTip = "..." + toolTip.Substring("Picture of ".Length);
                    }
                    if (toolTip.Length > 63)
                        toolTip = toolTip.Substring(0, 60) + "...";
                }

                notifyIcon.Text = toolTip;
                if (pictureManager.Image != null)
                {
                    if (Properties.Settings.Default.SetBackground)
                    {
                        SetWallpaper();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error ({0}): {1}", ex.GetType().Name, ex.Message));
            }
        }

        private void ReadSettings()
        {
            try
            {
                toolStripMenuItemSettingCheckPictureUpdates.Checked = Properties.Settings.Default.CheckPictureUpdate;
                toolStripMenuItemSettingSetBackground.Checked = Properties.Settings.Default.SetBackground;
                toolStripMenuItemLauchAtStartup.Checked = Properties.Settings.Default.LaunchAtStartup;
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error ({0}): {1}", ex.GetType().Name, ex.Message));
            }
        }

        private void SetWallpaper()
        {
            try
            {
                Wallpaper.Set(pictureBoxPreview.Image, Wallpaper.Style.None);
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error ({0}): {1}", ex.GetType().Name, ex.Message));
            }
        }

        private void SynchronizeLaunchAtStartup(bool newValue)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string keyValue = Application.ExecutablePath.ToString() + "/quiet";

            if (newValue)
            {
                if (rk.GetValue(Application.ProductName) != keyValue)
                {
                    rk.SetValue(Application.ProductName, keyValue);
                }
            }
            else
            {
                rk.DeleteValue(Application.ProductName, false);
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
                OnPictureUpdateBegin((PictureManager)sender);
            }));
        }

        private void pictureInfo_PictureUpdateEnd(object sender, EventArgs e)
        {
            this.Invoke(new Action(() => 
            { 
                OnPictureUpdateEnd((PictureManager)sender); 
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
            SetWallpaper();
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
            notifyIcon.ShowBalloonTip(1000, this.Text, "Hey, click here if you need me again ;)", ToolTipIcon.Info);
        }

        private void toolStripMenuItemSettingCheckPictureUpdates_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.CheckPictureUpdate != toolStripMenuItemSettingCheckPictureUpdates.Checked)
            {
                Properties.Settings.Default.CheckPictureUpdate = toolStripMenuItemSettingCheckPictureUpdates.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void toolStripMenuItemSettingSetBackground_CheckedChanged(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.SetBackground != toolStripMenuItemSettingSetBackground.Checked)
            {
                Properties.Settings.Default.SetBackground = toolStripMenuItemSettingSetBackground.Checked;
                Properties.Settings.Default.Save();
            }
        }

        private void pictureBoxSettings_EnabledChanged(object sender, EventArgs e)
        {
            contextMenuStripMain.Enabled = pictureBoxSettings.Enabled;
            pictureBoxSettings.Image = pictureBoxSettings.Enabled ? Properties.Resources.Edit14 : Properties.Resources.Edit14Disabled;
        }

        private void toolStripMenuItemLauchAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.LaunchAtStartup != toolStripMenuItemLauchAtStartup.Checked)
                {
                    Properties.Settings.Default.LaunchAtStartup = toolStripMenuItemLauchAtStartup.Checked;
                    Properties.Settings.Default.Save();
                    SynchronizeLaunchAtStartup(toolStripMenuItemLauchAtStartup.Checked);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Error ({0}): {1}", ex.GetType().Name, ex.Message));
            }
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
                MessageBox.Show(string.Format("Error ({0}): {1}", ex.GetType().Name, ex.Message));
            }
        }
    }
}
