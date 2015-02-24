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
            if (ex == null) throw new ArgumentNullException ("ex argument required");

            using (var form = new FormError(ex, showSendLink))
            {
                form.ShowDialog();
            }
        }

        public static void Info(string message, string okButtonText = "&Ok")
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentException("message argument required");

            using(var form = CreateDialog(FormDialog.MessageStyle.Info, message, okButtonText))
            {
                form.ShowDialog();
            }
        }

        public static FormDialog.MessageResult Query(string message, string yesButtonText, string noButtonText, string cancelButtonText = null)
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentException("message argument required");
            if (string.IsNullOrEmpty(yesButtonText)) throw new ArgumentException("yesButtonText argument required");
            if (string.IsNullOrEmpty(noButtonText)) throw new ArgumentException("noButtonText argument required");

            using (var form = CreateDialog(FormDialog.MessageStyle.Query, message, yesButtonText, noButtonText, cancelButtonText))
            {
                return form.ShowDialog();
            }
        }

        public static void Warning(string message, string okButtonText = "&Ok")
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentException("message argument required");

            using (var form = CreateDialog(FormDialog.MessageStyle.Warning, message, okButtonText))
            {
                form.ShowDialog();
            }
        }

        private static FormDialog CreateDialog(FormDialog.MessageStyle dialogStyle, string message, string yesButtonText, string noButtonText = null, string cancelButtonText = null)
        {
            List<DialogButton> buttons = new List<DialogButton>();

            if (yesButtonText != null)
            {
                buttons.Add(DialogButton.Ok(yesButtonText));
            }
            if (noButtonText != null)
            {
                buttons.Add(DialogButton.No(noButtonText));
            }
            if (cancelButtonText != null)
            {
                buttons.Add(DialogButton.Cancel(cancelButtonText));
            }

            return new FormDialog(dialogStyle, message, yesButtonText, buttons.ToArray());
        }
    }
}
