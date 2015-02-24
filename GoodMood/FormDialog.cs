using MetroFramework.Controls;
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

    public partial class FormDialog : MetroForm
    {
        public enum MessageStyle
        {
            Info,
            Query,
            Warning
        }

        public enum MessageResult
        {
            Ok = 0,
            No = 1,
            Cancel = 2
        }


        private FormDialog()
        {
            InitializeComponent();
        }

        public FormDialog(MessageStyle dialogStyle, string message, string detail = "", params DialogButton[] buttons)
            : this()
        {
            switch(dialogStyle)
            {
                case MessageStyle.Info:
                    this.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case MessageStyle.Query:
                    this.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case MessageStyle.Warning:
                    this.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
            }
            this.Text = message;
            this.metroLabelInfo.Visible = string.IsNullOrEmpty(detail);
            this.metroLabelInfo.Text = detail;

            flowLayoutPanelButtonArea.SuspendLayout();
            try
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    var buttonControl = new MetroButton();
                    var button = buttons[i];

                    buttonControl.Anchor = System.Windows.Forms.AnchorStyles.None;
                    buttonControl.AutoSize = true;
                    buttonControl.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
                    buttonControl.DialogResult = DialogResultToWindowsFormsDialogResult(button.Result);
                    buttonControl.Location = new System.Drawing.Point(3, 3);
                    buttonControl.Name = string.Format("metroButtonResult{0}", i + 1);
                    buttonControl.MinimumSize = new System.Drawing.Size(90, 24);
                    buttonControl.Size = new System.Drawing.Size(90, 24);
                    buttonControl.TabIndex = flowLayoutPanelButtonArea.TabIndex + i + 1;
                    buttonControl.Text = button.Text;
                    buttonControl.Visible = true;
                    flowLayoutPanelButtonArea.Controls.Add(buttonControl);
                }
            }
            finally
            {
                flowLayoutPanelButtonArea.ResumeLayout(true);
            }
        }

        private System.Windows.Forms.DialogResult DialogResultToWindowsFormsDialogResult(MessageResult dialogResult)
        {
            switch (dialogResult)
            {
                case MessageResult.Ok:
                    return System.Windows.Forms.DialogResult.OK;
                case MessageResult.No:
                    return System.Windows.Forms.DialogResult.No;
                case MessageResult.Cancel:
                    return System.Windows.Forms.DialogResult.Cancel;
                default:
                    throw new NotSupportedException(string.Format("DialogResult value {0} is not supported", dialogResult));
            }
        }

        public new MessageResult ShowDialog () 
        {
            var result = base.ShowDialog();
            switch (result)
	        {
                case System.Windows.Forms.DialogResult.Ignore:    
                case System.Windows.Forms.DialogResult.Cancel:
                case System.Windows.Forms.DialogResult.None:
                    return MessageResult.Cancel;
                case System.Windows.Forms.DialogResult.Abort:
                case System.Windows.Forms.DialogResult.No:
                    return MessageResult.No;
                case System.Windows.Forms.DialogResult.OK:
                case System.Windows.Forms.DialogResult.Retry:
                case System.Windows.Forms.DialogResult.Yes:
                    return MessageResult.Ok;
                default:
                    throw new NotSupportedException(string.Format("DialogResult value {0} is not supported", result));
	        }
        }

        private void flowLayoutPanelButtonArea_Resize(object sender, EventArgs e)
        {
            flowLayoutPanelButtonArea.Location = new Point(Math.Max((this.ClientSize.Width - flowLayoutPanelButtonArea.Width) / 2,this.DefaultMargin.Left), flowLayoutPanelButtonArea.Top);
        }

    }

    public class DialogButton 
    {
        public string Text { get; set; }
        public FormDialog.MessageResult Result { get; set; }

        private DialogButton() { }

        public static DialogButton Ok(string buttonText = "&Ok")
        {
            return new DialogButton() { Text = buttonText, Result = FormDialog.MessageResult.Ok };
        }

        public static DialogButton No(string buttonText = "&No")
        {
            return new DialogButton() { Text = buttonText, Result = FormDialog.MessageResult.No };
        }

        public static DialogButton Cancel(string buttonText = "&Annulla")
        {
            return new DialogButton() { Text = buttonText, Result = FormDialog.MessageResult.Cancel };
        }
    }
}
