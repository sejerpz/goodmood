using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood.Utility
{
    class Windows
    {
        public static void SetLaunchAtStartup(bool newValue)
        {
            RegistryKey rk = Registry.CurrentUser.OpenSubKey
                ("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            string keyValue = "\"" + Application.ExecutablePath.ToString() + "\" /quiet";

            if (newValue)
            {
                if ((string)rk.GetValue(Application.ProductName) != keyValue)
                {
                    rk.SetValue(Application.ProductName, keyValue);
                }
            }
            else
            {
                rk.DeleteValue(Application.ProductName, false);
            }
        }

        public static void UpgradeSettings()
        {
            if (Properties.Settings.Default.UpgradeSettings)
            {
                Properties.Settings.Default.Upgrade();
                Properties.Settings.Default.UpgradeSettings = false;
                Properties.Settings.Default.Save();
            }
        }
    }
}
