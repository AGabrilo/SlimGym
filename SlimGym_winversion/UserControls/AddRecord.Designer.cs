namespace SlimGym_winversion.UserControls
{
    partial class AddRecord
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
            this.buttonAddEntrance = new SlimGym_winversion.Objects.buttonEllip();
            this.buttonAddExit = new SlimGym_winversion.Objects.buttonEllip();
            this.SuspendLayout();
            // 
            // buttonAddEntrance
            // 
            this.buttonAddEntrance.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddEntrance.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddEntrance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddEntrance.BorderThickness = 10;
            this.buttonAddEntrance.ButtonRoundness = 3;
            this.buttonAddEntrance.FlatAppearance.BorderSize = 0;
            this.buttonAddEntrance.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonAddEntrance.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAddEntrance.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddEntrance.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEntrance.Font = new System.Drawing.Font("Tw Cen MT Condensed", 70F, System.Drawing.FontStyle.Bold);
            this.buttonAddEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddEntrance.Location = new System.Drawing.Point(40, 40);
            this.buttonAddEntrance.Name = "buttonAddEntrance";
            this.buttonAddEntrance.OnClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddEntrance.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAddEntrance.Size = new System.Drawing.Size(455, 565);
            this.buttonAddEntrance.TabIndex = 0;
            this.buttonAddEntrance.Text = "Add Entrance";
            this.buttonAddEntrance.UseVisualStyleBackColor = false;
            this.buttonAddEntrance.Click += new System.EventHandler(this.buttonAddEntrance_Click);
            // 
            // buttonAddExit
            // 
            this.buttonAddExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddExit.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddExit.BorderThickness = 10;
            this.buttonAddExit.ButtonRoundness = 3;
            this.buttonAddExit.FlatAppearance.BorderSize = 0;
            this.buttonAddExit.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonAddExit.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonAddExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddExit.Font = new System.Drawing.Font("Tw Cen MT Condensed", 70F, System.Drawing.FontStyle.Bold);
            this.buttonAddExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddExit.Location = new System.Drawing.Point(535, 40);
            this.buttonAddExit.Name = "buttonAddExit";
            this.buttonAddExit.OnClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonAddExit.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonAddExit.Size = new System.Drawing.Size(455, 565);
            this.buttonAddExit.TabIndex = 1;
            this.buttonAddExit.Text = "Add Exit";
            this.buttonAddExit.UseVisualStyleBackColor = false;
            this.buttonAddExit.Click += new System.EventHandler(this.buttonAddExit_Click);
            // 
            // AddRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.buttonAddExit);
            this.Controls.Add(this.buttonAddEntrance);
            this.Name = "AddRecord";
            this.Size = new System.Drawing.Size(1030, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private Objects.buttonEllip buttonAddEntrance;
        private Objects.buttonEllip buttonAddExit;
    }
}
