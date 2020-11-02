namespace SlimGym_winversion.UserControls
{
    partial class UserInfo
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelPersonalID = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelUserID = new System.Windows.Forms.Label();
            this.labelMembership = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelName.Location = new System.Drawing.Point(50, 40);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(101, 33);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.AutoSize = true;
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelSurname.Location = new System.Drawing.Point(50, 83);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(141, 33);
            this.labelSurname.TabIndex = 1;
            this.labelSurname.Text = "Surname:";
            // 
            // labelPersonalID
            // 
            this.labelPersonalID.AutoSize = true;
            this.labelPersonalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelPersonalID.Location = new System.Drawing.Point(395, 40);
            this.labelPersonalID.Name = "labelPersonalID";
            this.labelPersonalID.Size = new System.Drawing.Size(175, 33);
            this.labelPersonalID.TabIndex = 2;
            this.labelPersonalID.Text = "Personal ID:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelBirthDate.Location = new System.Drawing.Point(395, 83);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(152, 33);
            this.labelBirthDate.TabIndex = 3;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelUserID
            // 
            this.labelUserID.AutoSize = true;
            this.labelUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUserID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelUserID.Location = new System.Drawing.Point(727, 40);
            this.labelUserID.Name = "labelUserID";
            this.labelUserID.Size = new System.Drawing.Size(122, 33);
            this.labelUserID.TabIndex = 4;
            this.labelUserID.Text = "User ID:";
            // 
            // labelMembership
            // 
            this.labelMembership.AutoSize = true;
            this.labelMembership.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMembership.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelMembership.Location = new System.Drawing.Point(727, 83);
            this.labelMembership.Name = "labelMembership";
            this.labelMembership.Size = new System.Drawing.Size(184, 33);
            this.labelMembership.TabIndex = 5;
            this.labelMembership.Text = "Membership:";
            // 
            // UserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.labelMembership);
            this.Controls.Add(this.labelUserID);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.labelPersonalID);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.labelName);
            this.Name = "UserInfo";
            this.Size = new System.Drawing.Size(1030, 645);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelSurname;
        private System.Windows.Forms.Label labelPersonalID;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.Label labelUserID;
        private System.Windows.Forms.Label labelMembership;
    }
}
