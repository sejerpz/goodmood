namespace GoodMood.UI
{
    partial class FormDialog
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
            this.metroLabelInfo = new MetroFramework.Controls.MetroLabel();
            this.flowLayoutPanelButtonArea = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // metroLabelInfo
            // 
            this.metroLabelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLabelInfo.Location = new System.Drawing.Point(9, 54);
            this.metroLabelInfo.Name = "metroLabelInfo";
            this.metroLabelInfo.Size = new System.Drawing.Size(383, 19);
            this.metroLabelInfo.TabIndex = 6;
            this.metroLabelInfo.Text = "metroLabelInfo";
            this.metroLabelInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanelButtonArea
            // 
            this.flowLayoutPanelButtonArea.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.flowLayoutPanelButtonArea.AutoSize = true;
            this.flowLayoutPanelButtonArea.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanelButtonArea.Location = new System.Drawing.Point(152, 109);
            this.flowLayoutPanelButtonArea.Name = "flowLayoutPanelButtonArea";
            this.flowLayoutPanelButtonArea.Size = new System.Drawing.Size(0, 0);
            this.flowLayoutPanelButtonArea.TabIndex = 8;
            this.flowLayoutPanelButtonArea.Resize += new System.EventHandler(this.flowLayoutPanelButtonArea_Resize);
            // 
            // FormDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = MetroFramework.Drawing.MetroBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(400, 114);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanelButtonArea);
            this.Controls.Add(this.metroLabelInfo);
            this.MinimumSize = new System.Drawing.Size(400, 114);
            this.Name = "FormDialog";
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.SystemShadow;
            this.Style = MetroFramework.MetroColorStyle.Blue;
            this.Text = "FormInfo";
            this.TextAlign = System.Windows.Forms.VisualStyles.HorizontalAlign.Center;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLabel metroLabelInfo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelButtonArea;

    }
}