using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GoodMood.Extensions;

namespace GoodMood
{
    public partial class FormError : MetroForm
    {
        private Exception exception;

        private FormError()
        {
            InitializeComponent();
            this.Height = 110;
        }

        public FormError(Exception ex, bool showSendBugReportButton = true)
            : this()
        {
            this.exception = ex;
            metroTextBoxDetails.Text = ex.ToString();
            this.metroLinkReportSend.Visible = showSendBugReportButton;
            this.metroLinkReportSend.Tag = "";
        }

        private void metroButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void metroCheckBoxShowDetails_CheckedChanged(object sender, EventArgs e)
        {
            this.Resizable = metroCheckBoxShowDetails.Checked;
            if (metroCheckBoxShowDetails.Checked)
            {
                this.Height = 440;
                metroTextBoxDetails.Height = 300;
            }
            else
            {
                this.Height = 110;
                this.Width = 410;
            }
        }

        private void metroButtonSendBugReport_Click(object sender, EventArgs e)
        {
            SendBugReport();
        }

        private async void SendBugReport()
        {
            this.Enabled = false;
            try
            {
                var request = WebRequest.CreateHttp(new Uri(Properties.Settings.Default.CrashReportURL));
                var payload = string.Format("{{\"application\": \"{0}\", \"version\": \"{1}\", \"title\": \"{0} Crash Report\", \"report\": \"{2}\"}}",
                    Application.ProductName.JsonEscape(), Application.ProductVersion.JsonEscape(), exception.ToString().JsonEscape());

                var requestBody = Encoding.UTF8.GetBytes(payload);
                request.PreAuthenticate = true;
                request.Credentials = new NetworkCredential("goodmood", "77A6649d-A834-46af-Aa2e-7F434b60f914");
                request.ContentType = "application/json";
                request.UserAgent = "GoodMood/" + Application.ProductVersion;
                request.Method = "POST";
                request.GetRequestStream().Write(requestBody, 0, requestBody.Length);
                request.ServerCertificateValidationCallback = new System.Net.Security.RemoteCertificateValidationCallback(this.ValidateCertificate);
                var response = await request.GetResponseAsync();
                string responseMessage;

                using (var reader = new StreamReader(response.GetResponseStream()))
                {
                    responseMessage = reader.ReadToEnd();
                }

                if (response.Headers["Location"] != null)
                {
                    string url = response.Headers["Location"].Replace("api.", "").Replace("repos/","");
                    this.metroLinkReportSend.Tag = url;
                    this.metroLinkReportSend.Text = "View report...";
                }
                else
                {
                    this.metroLinkReportSend.Visible = false;
                }
                
                Interaction.Info(responseMessage);
            }
            catch (WebException ex)
            {
                Interaction.Warning(string.Format("Cannot send crash report.\n{0} ({1})", ex.Message, ex.Status));
            }
            catch (Exception ex)
            {
                Interaction.CriticalError(ex);
            }
            finally
            {
                this.Enabled = true;
            }
        }

        private bool ValidateCertificate(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, System.Net.Security.SslPolicyErrors sslPolicyErrors)
        {
            return certificate.Subject == "CN=colori.no-ip.org, O=Colori, L=Recanati, S=Macerata, C=IT";
        }

        private void metroLinkReportSend_Click(object sender, EventArgs e)
        {
            string url = metroLinkReportSend.Tag as string;

            if (string.IsNullOrEmpty(url))
            {
                SendBugReport();
            }
            else
            {
                System.Diagnostics.Process.Start(url);
            }
        }
    }
}
