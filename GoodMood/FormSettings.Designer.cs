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
            this.metroTabPagePhoto = new MetroFramework.Controls.MetroTabPage();
            this.metroRadioButtonFillColorModeDark = new MetroFramework.Controls.MetroRadioButton();
            this.metroRadioButtonFillColorModeBright = new MetroFramework.Controls.MetroRadioButton();
            this.metroCheckBoxFillBackground = new MetroFramework.Controls.MetroCheckBox();
            this.metroTabControlSettings.SuspendLayout();
            this.metroTabPageGeneral.SuspendLayout();
            this.metroTabPagePhoto.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControlSettings
            // 
            this.metroTabControlSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTabControlSettings.Controls.Add(this.metroTabPageGeneral);
            this.metroTabControlSettings.Controls.Add(this.metroTabPagePhoto);
            this.metroTabControlSettings.Location = new System.Drawing.Point(22, 59);
            this.metroTabControlSettings.Name = "metroTabControlSettings";
            this.metroTabControlSettings.SelectedIndex = 0;
            this.metroTabControlSettings.Size = new System.Drawing.Size(381, 145);
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
            this.metroTabPageGeneral.Size = new System.Drawing.Size(373, 106);
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
            // metroTabPagePhoto
            // 
            this.metroTabPagePhoto.Controls.Add(this.metroRadioButtonFillColorModeDark);
            this.metroTabPagePhoto.Controls.Add(this.metroRadioButtonFillColorModeBright);
            this.metroTabPagePhoto.Controls.Add(this.metroCheckBoxFillBackground);
            this.metroTabPagePhoto.HorizontalScrollbarBarColor = true;
            this.metroTabPagePhoto.Location = new System.Drawing.Point(4, 35);
            this.metroTabPagePhoto.Name = "metroTabPagePhoto";
            this.metroTabPagePhoto.Size = new System.Drawing.Size(373, 106);
            this.metroTabPagePhoto.TabIndex = 1;
            this.metroTabPagePhoto.Text = "Photo";
            this.metroTabPagePhoto.VerticalScrollbarBarColor = true;
            // 
            // metroRadioButtonFillColorModeDark
            // 
            this.metroRadioButtonFillColorModeDark.AutoSize = true;
            this.metroRadioButtonFillColorModeDark.Location = new System.Drawing.Point(23, 88);
            this.metroRadioButtonFillColorModeDark.Name = "metroRadioButtonFillColorModeDark";
            this.metroRadioButtonFillColorModeDark.Size = new System.Drawing.Size(131, 15);
            this.metroRadioButtonFillColorModeDark.TabIndex = 4;
            this.metroRadioButtonFillColorModeDark.TabStop = true;
            this.metroRadioButtonFillColorModeDark.Text = "Prefere darker colors";
            this.metroRadioButtonFillColorModeDark.UseVisualStyleBackColor = true;
            this.metroRadioButtonFillColorModeDark.CheckedChanged += new System.EventHandler(this.metroRadioButtonFillColorMode_CheckedChanged);
            // 
            // metroRadioButtonFillColorModeBright
            // 
            this.metroRadioButtonFillColorModeBright.AutoSize = true;
            this.metroRadioButtonFillColorModeBright.Location = new System.Drawing.Point(23, 54);
            this.metroRadioButtonFillColorModeBright.Name = "metroRadioButtonFillColorModeBright";
            this.metroRadioButtonFillColorModeBright.Size = new System.Drawing.Size(140, 15);
            this.metroRadioButtonFillColorModeBright.TabIndex = 3;
            this.metroRadioButtonFillColorModeBright.TabStop = true;
            this.metroRadioButtonFillColorModeBright.Text = "Prefere brighter colors";
            this.metroRadioButtonFillColorModeBright.UseVisualStyleBackColor = true;
            this.metroRadioButtonFillColorModeBright.CheckedChanged += new System.EventHandler(this.metroRadioButtonFillColorMode_CheckedChanged);
            // 
            // metroCheckBoxFillBackground
            // 
            this.metroCheckBoxFillBackground.AutoSize = true;
            this.metroCheckBoxFillBackground.Checked = true;
            this.metroCheckBoxFillBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxFillBackground.Location = new System.Drawing.Point(3, 22);
            this.metroCheckBoxFillBackground.Name = "metroCheckBoxFillBackground";
            this.metroCheckBoxFillBackground.Size = new System.Drawing.Size(344, 15);
            this.metroCheckBoxFillBackground.TabIndex = 2;
            this.metroCheckBoxFillBackground.Text = "Center photo on screen and fill borders with a matched color";
            this.metroCheckBoxFillBackground.UseVisualStyleBackColor = true;
            this.metroCheckBoxFillBackground.CheckedChanged += new System.EventHandler(this.metroCheckBoxFillBackground_CheckedChanged);
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 220);
            this.Controls.Add(this.metroTabControlSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Resizable = false;
            this.Text = "Settings";
            this.metroTabControlSettings.ResumeLayout(false);
            this.metroTabPageGeneral.ResumeLayout(false);
            this.metroTabPageGeneral.PerformLayout();
            this.metroTabPagePhoto.ResumeLayout(false);
            this.metroTabPagePhoto.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControlSettings;
        private MetroFramework.Controls.MetroTabPage metroTabPageGeneral;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxLauchAtStartup;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxSetBackground;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxAutoUpdatePhoto;
        private MetroFramework.Controls.MetroTabPage metroTabPagePhoto;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonFillColorModeDark;
        private MetroFramework.Controls.MetroRadioButton metroRadioButtonFillColorModeBright;
        private MetroFramework.Controls.MetroCheckBox metroCheckBoxFillBackground;
    }
}