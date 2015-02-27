namespace GoodMood
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroTabControlSettings = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPageGeneral = new MetroFramework.Controls.MetroTabPage();
            this.metroCheckBoxLauchAtStartup = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxSetBackground = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBoxAutoUpdatePhoto = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControlSettings.SuspendLayout();
            this.metroTabPageGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControlSettings
            // 
            this.metroTabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControlSettings.Controls.Add(this.metroTabPageGeneral);
            this.metroTabControlSettings.Location = new System.Drawing.Point(22, 59);
            this.metroTabControlSettings.Name = "metroTabControlSettings";
            this.metroTabControlSettings.SelectedIndex = 0;
            this.metroTabControlSettings.Size = new System.Drawing.Size(292, 156);
            this.metroTabControlSettings.TabIndex = 0;
            // 
            // metroTabPageGeneral
            // 
            this.metroTabPageGeneral.Controls.Add(this.metroCheckBoxLauchAtStartup);
            this.metroTabPageGeneral.Controls.Add(this.metroCheckBoxSetBackground);
            this.metroTabPageGeneral.Controls.Add(this.metroCheckBoxAutoUpdatePhoto);
            this.metroTabPageGeneral.HorizontalScrollbarBarColor = true;
            this.metroTabPageGeneral.Location = new System.Drawing.Point(4, 35);
            this.metroTabPageGeneral.Name = "metroTabPageGeneral";
            this.metroTabPageGeneral.Size = new System.Drawing.Size(284, 117);
            this.metroTabPageGeneral.TabIndex = 0;
            this.metroTabPageGeneral.Text = "General";
            this.metroTabPageGeneral.VerticalScrollbarBarColor = true;
            // 
            // metroCheckBoxLauchAtStartup
            // 
            this.metroCheckBoxLauchAtStartup.AutoSize = true;
            this.metroCheckBoxLauchAtStartup.Location = new System.Drawing.Point(3, 88);
            this.metroCheckBoxLauchAtStartup.Name = "metroCheckBoxLauchAtStartup";
            this.metroCheckBoxLauchAtStartup.Size = new System.Drawing.Size(153, 15);
            this.metroCheckBoxLauchAtStartup.TabIndex = 2;
            this.metroCheckBoxLauchAtStartup.Text = "Run on Windows startup";
            this.metroCheckBoxLauchAtStartup.UseVisualStyleBackColor = true;
            this.metroCheckBoxLauchAtStartup.CheckedChanged += new System.EventHandler(this.metroCheckBoxLauchAtStartup_CheckedChanged);
            // 
            // metroCheckBoxSetBackground
            // 
            this.metroCheckBoxSetBackground.AutoSize = true;
            this.metroCheckBoxSetBackground.Location = new System.Drawing.Point(3, 55);
            this.metroCheckBoxSetBackground.Name = "metroCheckBoxSetBackground";
            this.metroCheckBoxSetBackground.Size = new System.Drawing.Size(281, 15);
            this.metroCheckBoxSetBackground.TabIndex = 2;
            this.metroCheckBoxSetBackground.Text = "Automatically set picture as desktop background";
            this.metroCheckBoxSetBackground.UseVisualStyleBackColor = true;
            this.metroCheckBoxSetBackground.CheckedChanged += new System.EventHandler(this.metroCheckBoxSetBackground_CheckedChanged);
            // 
            // metroCheckBoxAutoUpdatePhoto
            // 
            this.metroCheckBoxAutoUpdatePhoto.AutoSize = true;
            this.metroCheckBoxAutoUpdatePhoto.Location = new System.Drawing.Point(3, 18);
            this.metroCheckBoxAutoUpdatePhoto.Name = "metroCheckBoxAutoUpdatePhoto";
            this.metroCheckBoxAutoUpdatePhoto.Size = new System.Drawing.Size(219, 15);
            this.metroCheckBoxAutoUpdatePhoto.TabIndex = 2;
            this.metroCheckBoxAutoUpdatePhoto.Text = "Automatically check for new pictures";
            this.metroCheckBoxAutoUpdatePhoto.UseVisualStyleBackColor = true;
            this.metroCheckBoxAutoUpdatePhoto.CheckedChanged += new System.EventHandler(this.metroCheckBoxAutoUpdatePhoto_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 231);
            this.Controls.Add(this.metroTabControlSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Resizable = false;
            this.Text = "Settings";
            this.metroTabControlSettings.ResumeLayout(false);
            this.metroTabPageGeneral.ResumeLayout(false);
            this.metroTabPageGeneral.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControlSettings;
        private MetroFramework.Controls.MetroTabPage metroTabPageGeneral;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxLauchAtStartup;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSetBackground;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxAutoUpdatePhoto;
    }
}