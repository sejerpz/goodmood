/*
 * Copyright 2015 Andrea Del Signore sejerpz@gmail.com
 */

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
            metroLabelVersion.Text = string.Format("version {0}", Application.ProductVersion);
            metroLabelCopyRight.Text = string.Format("copyright © 2015 by {0}", Application.CompanyName);
            metroLinkWebSite.Text = "GoodMood Web Site";
        }

        private void FormAbout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroLinkWebSite_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://sejerpz.github.io/GoodMood/");
        }
    }
}
