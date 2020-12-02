namespace SlimGym_winversion.UserControls
{
    partial class Schedule
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
            this.panelSchedule1 = new SlimGym_winversion.Objects.panelSchedule();
            this.SuspendLayout();
            // 
            // panelSchedule1
            // 
            this.panelSchedule1.BackColor = System.Drawing.Color.White;
            this.panelSchedule1.BorderColor = System.Drawing.Color.Transparent;
            this.panelSchedule1.BorderThickness = 0;
            this.panelSchedule1.Location = new System.Drawing.Point(5, 5);
            this.panelSchedule1.Name = "panelSchedule1";
            this.panelSchedule1.PanelRoundness = 15;
            this.panelSchedule1.Size = new System.Drawing.Size(1020, 635);
            this.panelSchedule1.TabIndex = 0;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.panelSchedule1);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(1030, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private Objects.panelSchedule panelSchedule1;
    }
}
