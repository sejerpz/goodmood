using GoodMood.UI;
using GoodMood.Utility;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood
{
    public partial class FormSettings : MetroForm
    {
        public FormSettings()
        {
            InitializeComponent();
            ReadSettings();
        }


        private void ReadSettings()
        {
            try
            {
                metroCheckBoxAutoUpdatePhoto.Checked = Properties.Settings.Default.CheckPictureUpdate;
                metroCheckBoxSetBackground.Checked = Properties.Settings.Default.SetBackground;
                metroCheckBoxLauchAtStartup.Checked = Properties.Settings.Default.LaunchAtStartup;
                metroCheckBoxFillBackground.Checked = Properties.Settings.Default.FillBackground;
                if (string.Compare(Properties.Settings.Default.FillColorMode, "bright", true) == 0)
                {
                    metroRadioButtonFillColorModeBright.Checked = true;
                }
                else
                {
                    metroRadioButtonFillColorModeDark.Checked = true;
                }
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private void metroCheckBoxAutoUpdatePhoto_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateAutoUpdatePhotoSettingValue(metroCheckBoxAutoUpdatePhoto.Checked);
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private void metroCheckBoxSetBackground_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateSetBackgroundSettingValue(metroCheckBoxSetBackground.Checked);
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private void metroCheckBoxLauchAtStartup_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateLaunchAtStartupSettingValue(metroCheckBoxLauchAtStartup.Checked);
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private void UpdateLaunchAtStartupSettingValue(bool newValue)
        {
            if (Properties.Settings.Default.LaunchAtStartup != newValue)
            {
                Properties.Settings.Default.LaunchAtStartup = newValue;
                Properties.Settings.Default.Save();
                Windows.SetLaunchAtStartup(newValue);
            }
        }

        private void UpdateAutoUpdatePhotoSettingValue(bool newValue)
        {
            if (Properties.Settings.Default.CheckPictureUpdate != newValue)
            {
                Properties.Settings.Default.CheckPictureUpdate = newValue;
                Properties.Settings.Default.Save();
            }
        }

        private void UpdateSetBackgroundSettingValue(bool newValue)
        {
            if (Properties.Settings.Default.SetBackground != newValue)
            {
                Properties.Settings.Default.SetBackground = newValue;
                Properties.Settings.Default.Save();
            }
        }

        private void UpdateFillBackgroundSettingValue(bool newValue)
        {
            if (Properties.Settings.Default.FillBackground != newValue)
            {
                Properties.Settings.Default.FillBackground = newValue;
                Properties.Settings.Default.Save();
            }
        }

        private void UpdateFillColorModeSettingValue(string newValue)
        {
            if (Properties.Settings.Default.FillColorMode != newValue)
            {
                Properties.Settings.Default.FillColorMode = metroRadioButtonFillColorModeBright.Checked ? "Bright" : "Dark";
                Properties.Settings.Default.Save();
            }
        }

        private void metroCheckBoxFillBackground_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                metroRadioButtonFillColorModeBright.Enabled = metroCheckBoxFillBackground.Checked;
                metroRadioButtonFillColorModeDark.Enabled = metroCheckBoxFillBackground.Checked;
                UpdateFillBackgroundSettingValue(metroCheckBoxFillBackground.Checked);
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }

        private void metroRadioButtonFillColorMode_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                UpdateFillColorModeSettingValue(metroRadioButtonFillColorModeBright.Checked ? "Bright" : "Dark");
            }
            catch (Exception ex)
            {
                Interaction.Error(ex);
            }
        }
    }
}
