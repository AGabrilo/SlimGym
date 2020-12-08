namespace SlimGym_winversion.UserControls
{
    partial class ListGroups
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
            this.labelRecordOfUsers = new System.Windows.Forms.Label();
            this.panelGroups = new SlimGym_winversion.Objects.panelEllip();
            this.buttonBack = new SlimGym_winversion.Objects.buttonEllip();
            this.SuspendLayout();
            // 
            // labelRecordOfUsers
            // 
            this.labelRecordOfUsers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRecordOfUsers.BackColor = System.Drawing.Color.Transparent;
            this.labelRecordOfUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.labelRecordOfUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelRecordOfUsers.Location = new System.Drawing.Point(360, 11);
            this.labelRecordOfUsers.Name = "labelRecordOfUsers";
            this.labelRecordOfUsers.Size = new System.Drawing.Size(310, 38);
            this.labelRecordOfUsers.TabIndex = 25;
            this.labelRecordOfUsers.Text = "List of Groups:";
            this.labelRecordOfUsers.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelGroups
            // 
            this.panelGroups.AutoScroll = true;
            this.panelGroups.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelGroups.BorderColor = System.Drawing.Color.Transparent;
            this.panelGroups.BorderThickness = 0;
            this.panelGroups.Location = new System.Drawing.Point(0, 50);
            this.panelGroups.Name = "panelGroups";
            this.panelGroups.PanelRoundness = 0;
            this.panelGroups.Size = new System.Drawing.Size(1013, 500);
            this.panelGroups.TabIndex = 24;
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
            this.buttonBack.TabIndex = 23;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            // 
            // ListGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.labelRecordOfUsers);
            this.Controls.Add(this.panelGroups);
            this.Controls.Add(this.buttonBack);
            this.Name = "ListGroups";
            this.Size = new System.Drawing.Size(1030, 645);
            this.ResumeLayout(false);

        }

        #endregion

        private Objects.buttonEllip buttonBack;
        private Objects.panelEllip panelGroups;
        private System.Windows.Forms.Label labelRecordOfUsers;
    }
}
