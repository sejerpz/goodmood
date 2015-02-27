using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood
{
    class Utility
    {
        public static void SynchronizeLaunchAtStartup(bool newValue)
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

    }
}
