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
        public enum DialogStyle
        {
            Info,
            Query,
            Warning
        }

        private FormDialog()
        {
            InitializeComponent();
        }

        public FormDialog(DialogStyle dialogStyle, string message, string detail = "", string okButtonLabel = "&Ok")
            : this()
        {
            switch(dialogStyle)
            {
                case DialogStyle.Info:
                    this.Style = MetroFramework.MetroColorStyle.Blue;
                    break;
                case DialogStyle.Query:
                    this.Style = MetroFramework.MetroColorStyle.Green;
                    break;
                case DialogStyle.Warning:
                    this.Style = MetroFramework.MetroColorStyle.Orange;
                    break;
            }
            this.Text = message;
            this.metroLabelInfo.Visible = string.IsNullOrEmpty(detail);
            this.metroLabelInfo.Text = detail;
            this.metroButtonOk.Text = okButtonLabel;
        }
    }
}
