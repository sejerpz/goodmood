/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

using GoodMood.UI;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood
{
    public partial class FormAbout : MetroForm
    {
        public FormAbout()
        {
            InitializeComponent();
            Defaults();
        }

        private void Defaults()
        {
            this.Text = Application.ProductName;
            metroLabelVersion.Text = string.Format(Strings.VersionText, Application.ProductVersion);
            metroLabelCopyRight.Text = string.Format("copyright © 2015 by {0}", Application.CompanyName);

            metroLinkCheckUpdates.Visible = ApplicationDeployment.IsNetworkDeployed;
        }

        private void FormAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLinkWebSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sejerpz.github.io/goodmood/");
        }

        private void metroLinkCheckUpdates_Click(object sender, EventArgs e)
        {
            CheckAndInstallUpdate();
        }

        private void CheckAndInstallUpdate()
        {
            UpdateCheckInfo info = null;

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                ApplicationDeployment ad = ApplicationDeployment.CurrentDeployment;
               
                try
                {
                    using (var wait = new WaitCursor())
                    {
                        info = ad.CheckForDetailedUpdate();
                    }
                }
                catch (DeploymentDownloadException ex)
                {
                    Interaction.Warning(Strings.DowloadFailed, string.Format(Strings.DowloadFailedMessage, ex.Message));
                    return;
                }
                catch (InvalidDeploymentException ex)
                {
                    Interaction.Warning(Strings.UpdateCheckFailed, string.Format(Strings.UpdateCheckFailedMessage, ex.Message));
                    return;
                }
                catch (InvalidOperationException ex)
                {
                    Interaction.Info(Strings.UpdateFailed, string.Format(Strings.UpdateFailed, ex.Message));
                    return;
                }
                

                if (info.UpdateAvailable)
                {
                    Boolean doUpdate = true;

                    if (!info.IsUpdateRequired)
                    {
                        var result = Interaction.Query(Strings.UpdateAvailable, Strings.UpdateAvailableMessage, DialogButton.Ok(Strings.UpdateButtonText), DialogButton.No());
                        if (result != FormDialog.MessageResult.Ok)
                        {
                            doUpdate = false;
                        }
                    }
                    else
                    {
                        // Display a message that the app MUST reboot. Display the minimum required version.
                        Interaction.Info(Strings.MandatoryUpdate, 
                            string.Format(Strings.MandatoryUpdateMessage
                                , info.MinimumRequiredVersion.ToString())
                            , DialogButton.Ok("&Update now"));
                    }

                    if (doUpdate)
                    {
                        try
                        {
                            using (var wait = new WaitCursor())
                            {
                                ad.Update();
                            }
                            Interaction.Info(Strings.ApplicaionUpgraded, Strings.ApplicaionUpgradedMessage , DialogButton.Ok(Strings.ApplicationUpgradedButtonText));
                            Application.Restart();
                        }
                        catch (DeploymentDownloadException ex)
                        {
                            Interaction.Error(ex);
                        }
                    }
                }
                else
                {
                    Interaction.Info(Strings.NoUpdate, Strings.NoUpdateMessage);
                }
            }
        }
    }
}
