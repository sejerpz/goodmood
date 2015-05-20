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

namespace GoodMood.UI
{
    public partial class FormTrayTooltip : MetroForm
    {
        private const int CounterSteps = 4;
        private const int HideTimeout = 500;

        private System.Threading.Timer timer;
        private int counter = CounterSteps;

        public FormTrayTooltip()
        {
            InitializeComponent();
            this.HandleCreated += FormTrayTooltip_HandleCreated;
            timer = new System.Threading.Timer(new System.Threading.TimerCallback((state) =>
            {
                this.Invoke(new Action(() => {
                    if (counter == 0)
                    {
                        this.Hide();
                    }
                    else
                    {
                        var rec = new Rectangle(new Point(0, 0), this.Size);

                        if (rec.Contains(this.PointToClient(Control.MousePosition)))
                        {
                             ResetVisibilityState();
                        }
                        else
                        {
                            counter--;
                            this.Opacity = Math.Min(1.0, 0.4 + counter * (0.6 / CounterSteps));
                        }
                        timer.Change(HideTimeout, Timeout.Infinite);
                    }
                }));
            }));
        }

        void FormTrayTooltip_HandleCreated(object sender, EventArgs e)
        {
            timer.Change(HideTimeout, Timeout.Infinite);
        }
        
        public void StayVisible()
        {
            ResetVisibilityState();
            timer.Change(HideTimeout, Timeout.Infinite);
        }

        private void ResetVisibilityState()
        {
            counter = CounterSteps;
            this.Opacity = 1.0;
        }

        public void UpdateInfo(Image image, string tooltip)
        {
            pictureBoxImage.Image = image;
            labelTooltip.Text = tooltip;
        }
    }
}
