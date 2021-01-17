namespace SlimGym_winversion.UserControls
{
    partial class AddMembership
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
            this.panelMemberships = new SlimGym_winversion.Objects.panelEllip();
            this.labelMemberships = new System.Windows.Forms.Label();
            this.buttonBack = new SlimGym_winversion.Objects.buttonEllip();
            this.SuspendLayout();
            // 
            // panelMemberships
            // 
            this.panelMemberships.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelMemberships.AutoScroll = true;
            this.panelMemberships.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelMemberships.BorderColor = System.Drawing.Color.Transparent;
            this.panelMemberships.BorderThickness = 0;
            this.panelMemberships.Location = new System.Drawing.Point(0, 50);
            this.panelMemberships.Name = "panelMemberships";
            this.panelMemberships.PanelRoundness = 0;
            this.panelMemberships.Size = new System.Drawing.Size(1020, 500);
            this.panelMemberships.TabIndex = 1;
            // 
            // labelMemberships
            // 
            this.labelMemberships.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelMemberships.BackColor = System.Drawing.Color.Transparent;
            this.labelMemberships.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.labelMemberships.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelMemberships.Location = new System.Drawing.Point(350, 11);
            this.labelMemberships.Name = "labelMemberships";
            this.labelMemberships.Size = new System.Drawing.Size(330, 38);
            this.labelMemberships.TabIndex = 3;
            this.labelMemberships.Text = "List of Memberships";
            this.labelMemberships.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack
            // 
            this.buttonBack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonBack.BackColor = System.Drawing.Color.Transparent;
            this.buttonBack.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonBack.BorderThickness = 6;
            this.buttonBack.ButtonRoundness = 1;
            this.buttonBack.FlatAppearance.BorderSize = 0;
            this.buttonBack.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonBack.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonBack.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBack.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBack.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonBack.Location = new System.Drawing.Point(30, 564);
            this.buttonBack.MaximumSize = new System.Drawing.Size(600, 390);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.OnClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonBack.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonBack.Size = new System.Drawing.Size(115, 51);
            this.buttonBack.TabIndex = 2;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // AddMembership
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelMemberships);
            this.Controls.Add(this.panelMemberships);
            this.Name = "AddMembership";
            this.Size = new System.Drawing.Size(1030, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private Objects.panelEllip panelMemberships;
        private System.Windows.Forms.Label labelMemberships;
        private Objects.buttonEllip buttonBack;
    }
}
