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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSettings));
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
            resources.ApplyResources(this.metroTabControlSettings, "metroTabControlSettings");
            this.metroTabControlSettings.Controls.Add(this.metroTabPageGeneral);
            this.metroTabControlSettings.Controls.Add(this.metroTabPagePhoto);
            this.metroTabControlSettings.Name = "metroTabControlSettings";
            this.metroTabControlSettings.SelectedIndex = 0;
            // 
            // metroTabPageGeneral
            // 
            resources.ApplyResources(this.metroTabPageGeneral, "metroTabPageGeneral");
            this.metroTabPageGeneral.Controls.Add(this.metroCheckBoxLauchAtStartup);
            this.metroTabPageGeneral.Controls.Add(this.metroCheckBoxSetBackground);
            this.metroTabPageGeneral.Controls.Add(this.metroCheckBoxAutoUpdatePhoto);
            this.metroTabPageGeneral.HorizontalScrollbarBarColor = true;
            this.metroTabPageGeneral.Name = "metroTabPageGeneral";
            this.metroTabPageGeneral.VerticalScrollbarBarColor = true;
            // 
            // metroCheckBoxLauchAtStartup
            // 
            resources.ApplyResources(this.metroCheckBoxLauchAtStartup, "metroCheckBoxLauchAtStartup");
            this.metroCheckBoxLauchAtStartup.Name = "metroCheckBoxLauchAtStartup";
            this.metroCheckBoxLauchAtStartup.UseVisualStyleBackColor = true;
            this.metroCheckBoxLauchAtStartup.CheckedChanged += new System.EventHandler(this.metroCheckBoxLauchAtStartup_CheckedChanged);
            // 
            // metroCheckBoxSetBackground
            // 
            resources.ApplyResources(this.metroCheckBoxSetBackground, "metroCheckBoxSetBackground");
            this.metroCheckBoxSetBackground.Name = "metroCheckBoxSetBackground";
            this.metroCheckBoxSetBackground.UseVisualStyleBackColor = true;
            this.metroCheckBoxSetBackground.CheckedChanged += new System.EventHandler(this.metroCheckBoxSetBackground_CheckedChanged);
            // 
            // metroCheckBoxAutoUpdatePhoto
            // 
            resources.ApplyResources(this.metroCheckBoxAutoUpdatePhoto, "metroCheckBoxAutoUpdatePhoto");
            this.metroCheckBoxAutoUpdatePhoto.Name = "metroCheckBoxAutoUpdatePhoto";
            this.metroCheckBoxAutoUpdatePhoto.UseVisualStyleBackColor = true;
            this.metroCheckBoxAutoUpdatePhoto.CheckedChanged += new System.EventHandler(this.metroCheckBoxAutoUpdatePhoto_CheckedChanged);
            // 
            // metroTabPagePhoto
            // 
            resources.ApplyResources(this.metroTabPagePhoto, "metroTabPagePhoto");
            this.metroTabPagePhoto.Controls.Add(this.metroRadioButtonFillColorModeDark);
            this.metroTabPagePhoto.Controls.Add(this.metroRadioButtonFillColorModeBright);
            this.metroTabPagePhoto.Controls.Add(this.metroCheckBoxFillBackground);
            this.metroTabPagePhoto.HorizontalScrollbarBarColor = true;
            this.metroTabPagePhoto.Name = "metroTabPagePhoto";
            this.metroTabPagePhoto.VerticalScrollbarBarColor = true;
            // 
            // metroRadioButtonFillColorModeDark
            // 
            resources.ApplyResources(this.metroRadioButtonFillColorModeDark, "metroRadioButtonFillColorModeDark");
            this.metroRadioButtonFillColorModeDark.Name = "metroRadioButtonFillColorModeDark";
            this.metroRadioButtonFillColorModeDark.TabStop = true;
            this.metroRadioButtonFillColorModeDark.UseVisualStyleBackColor = true;
            this.metroRadioButtonFillColorModeDark.CheckedChanged += new System.EventHandler(this.metroRadioButtonFillColorMode_CheckedChanged);
            // 
            // metroRadioButtonFillColorModeBright
            // 
            resources.ApplyResources(this.metroRadioButtonFillColorModeBright, "metroRadioButtonFillColorModeBright");
            this.metroRadioButtonFillColorModeBright.Name = "metroRadioButtonFillColorModeBright";
            this.metroRadioButtonFillColorModeBright.TabStop = true;
            this.metroRadioButtonFillColorModeBright.UseVisualStyleBackColor = true;
            this.metroRadioButtonFillColorModeBright.CheckedChanged += new System.EventHandler(this.metroRadioButtonFillColorMode_CheckedChanged);
            // 
            // metroCheckBoxFillBackground
            // 
            resources.ApplyResources(this.metroCheckBoxFillBackground, "metroCheckBoxFillBackground");
            this.metroCheckBoxFillBackground.Checked = true;
            this.metroCheckBoxFillBackground.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBoxFillBackground.Name = "metroCheckBoxFillBackground";
            this.metroCheckBoxFillBackground.UseVisualStyleBackColor = true;
            this.metroCheckBoxFillBackground.CheckedChanged += new System.EventHandler(this.metroCheckBoxFillBackground_CheckedChanged);
            // 
            // FormSettings
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroTabControlSettings);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormSettings";
            this.Resizable = false;
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