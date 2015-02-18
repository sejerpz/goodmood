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
        public static void Error(Exception ex, bool showSendLink = true)
        {
            using (var form = new FormError(ex, showSendLink))
            {
                form.ShowDialog();
            }
        }

        public static void Info(string message, string okButtonText = null)
        {
            using(var form = CreateDialog(FormDialog.DialogStyle.Info, message, okButtonText))
            {
                form.ShowDialog();
            }
        }

        //public static DialogResult Query(string message, string okButtonText = null)
        //{
        //    using (var form = CreateDialog(FormDialog.DialogStyle.Query, message, okButtonText))
        //    {
        //        return form.ShowDialog();
        //    }
        //}

        public static void Warning(string message, string okButtonText = null)
        {
            using (var form = CreateDialog(FormDialog.DialogStyle.Warning, message, okButtonText))
            {
                form.ShowDialog();
            }
        }

        private static FormDialog CreateDialog(FormDialog.DialogStyle dialogStyle, string message, string okButtonText)
        {
            FormDialog form;
            if (okButtonText == null)
                form = new FormDialog(dialogStyle, message);
            else
                form = new FormDialog(dialogStyle, message, okButtonText);

            return form;
        }
    }
}
