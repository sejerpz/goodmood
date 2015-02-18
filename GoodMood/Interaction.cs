using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood
{
    class Interaction
    {
        public static void Error(Exception ex)
        {
            using (var form = new FormError(ex))
            {
                form.ShowDialog();
            }
        }

        public static void CriticalError(Exception ex)
        {
            using (var form = new FormError(ex, false))
            {
                form.ShowDialog();
            }
        }

        public static void Info(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void Warning(string message)
        {
            MessageBox.Show(message, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
