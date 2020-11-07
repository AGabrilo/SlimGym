namespace SlimGym_winversion.UserControls
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelEllip1 = new SlimGym_winversion.Objects.panelEllip();
            this.SuspendLayout();
            // 
            // panelEllip1
            // 
            this.panelEllip1.BackColor = System.Drawing.Color.White;
            this.panelEllip1.BorderColor = System.Drawing.Color.Transparent;
            this.panelEllip1.BorderThickness = 0;
            this.panelEllip1.Location = new System.Drawing.Point(30, 32);
            this.panelEllip1.Name = "panelEllip1";
            this.panelEllip1.PanelRoundness = 15;
            this.panelEllip1.Size = new System.Drawing.Size(952, 579);
            this.panelEllip1.TabIndex = 0;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panelEllip1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(1030, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private Objects.panelEllip panelEllip1;
    }
}
