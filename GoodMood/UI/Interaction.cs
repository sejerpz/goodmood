using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood.UI
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

        public static void Info(string message, DialogButton okButton = null)
        {
            Info(message, "", okButton ?? DialogButton.Ok());
        }

        public static void Info(string message, string detailMessage, DialogButton okButton = null)
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentException("message argument required");

            using (var form = CreateDialog(FormDialog.MessageStyle.Info, message, detailMessage, okButton ?? DialogButton.Ok()))
            {
                form.ShowDialog();
            }
        }

        public static FormDialog.MessageResult Query(string message, DialogButton yesButton, DialogButton noButton, DialogButton cancelButton = null)
        {
            return Query(message, "", yesButton, noButton, cancelButton);
        }

        public static FormDialog.MessageResult Query(string message, string detailMessage, DialogButton yesButton, DialogButton noButton, DialogButton cancelButton = null)
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentException("message argument required");
            if (yesButton == null) throw new ArgumentNullException("yesButton  argument required");
            if (noButton == null) throw new ArgumentNullException("noButton argument required");

            List<DialogButton> buttons = new List<DialogButton>();
            buttons.Add(yesButton);
            buttons.Add(noButton);
            if (cancelButton != null)
            {
                buttons.Add(cancelButton);
            }

            using (var form = CreateDialog(FormDialog.MessageStyle.Query, message, detailMessage, buttons.ToArray()))
            {
                return form.ShowDialog();
            }
        }

        public static void Warning(string message, DialogButton okButton = null)
        {
            Warning(message, "", okButton ?? DialogButton.Ok());
        }

        public static void Warning(string message, string detailMessage, DialogButton okButton = null)
        {
            if (string.IsNullOrEmpty(message)) throw new ArgumentException("message argument required");

            using (var form = CreateDialog(FormDialog.MessageStyle.Warning, message, detailMessage, okButton ?? DialogButton.Ok()))
            {
                form.ShowDialog();
            }
        }

        private static FormDialog CreateDialog(FormDialog.MessageStyle dialogStyle, string message, string detailMessage, params DialogButton[] buttons)
        {
            return new FormDialog(dialogStyle, message, detailMessage, buttons);
        }
    }
}
