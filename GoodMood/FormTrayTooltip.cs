using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoodMood
{
    public partial class FormTrayTooltip : MetroForm
    {
        private System.Threading.Timer timer;
        private int counter = 2;

        public FormTrayTooltip()
        {
            InitializeComponent();
            timer = new System.Threading.Timer(new System.Threading.TimerCallback((state) =>
            {
                this.Invoke(new Action(() => {
                    if (counter == 0)
                    {
                        this.Dispose();
                    }
                    else
                    {
                        counter--;
                        this.Opacity = Math.Min(1.0, 0.5 + counter * 0.15);
                        timer.Change(1000, Timeout.Infinite);
                    }
                }));
            }));
            timer.Change(2000, Timeout.Infinite);
        }

        public void StayVisible()
        {
            counter = 2;
            this.Opacity = 1.0;
        }

        public void UpdateInfo(Image image, string tooltip)
        {
            pictureBoxImage.Image = image;
            labelTooltip.Text = tooltip;
        }
    }
}
