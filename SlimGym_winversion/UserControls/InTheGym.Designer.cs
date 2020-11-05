namespace SlimGym_winversion.UserControls
{
    partial class InTheGym
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.buttonBack = new SlimGym_winversion.Objects.buttonEllip();
            this.dataGridViewSearchUsers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entranceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelName.Location = new System.Drawing.Point(223, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(574, 85);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "Users In The Gym:";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.buttonBack.Location = new System.Drawing.Point(70, 553);
            this.buttonBack.MaximumSize = new System.Drawing.Size(600, 390);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.OnClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonBack.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonBack.Size = new System.Drawing.Size(115, 51);
            this.buttonBack.TabIndex = 14;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // dataGridViewSearchUsers
            // 
            this.dataGridViewSearchUsers.AllowUserToAddRows = false;
            this.dataGridViewSearchUsers.AllowUserToDeleteRows = false;
            this.dataGridViewSearchUsers.AllowUserToResizeColumns = false;
            this.dataGridViewSearchUsers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSearchUsers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewSearchUsers.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewSearchUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSearchUsers.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSearchUsers.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewSearchUsers.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSearchUsers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewSearchUsers.ColumnHeadersHeight = 33;
            this.dataGridViewSearchUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewSearchUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name2,
            this.surname,
            this.entranceTime,
            this.userId});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchUsers.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewSearchUsers.DoubleBuffered = true;
            this.dataGridViewSearchUsers.EnableHeadersVisualStyles = false;
            this.dataGridViewSearchUsers.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewSearchUsers.HeaderBgColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewSearchUsers.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.dataGridViewSearchUsers.Location = new System.Drawing.Point(77, 104);
            this.dataGridViewSearchUsers.MultiSelect = false;
            this.dataGridViewSearchUsers.Name = "dataGridViewSearchUsers";
            this.dataGridViewSearchUsers.ReadOnly = true;
            this.dataGridViewSearchUsers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewSearchUsers.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.Format = "E2";
            dataGridViewCellStyle4.NullValue = "0";
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewSearchUsers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewSearchUsers.RowHeadersVisible = false;
            this.dataGridViewSearchUsers.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewSearchUsers.RowTemplate.ReadOnly = true;
            this.dataGridViewSearchUsers.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewSearchUsers.Size = new System.Drawing.Size(876, 416);
            this.dataGridViewSearchUsers.TabIndex = 15;
            // 
            // name2
            // 
            this.name2.HeaderText = "Name:";
            this.name2.Name = "name2";
            this.name2.ReadOnly = true;
            // 
            // surname
            // 
            this.surname.HeaderText = "Surname:";
            this.surname.Name = "surname";
            this.surname.ReadOnly = true;
            // 
            // entranceTime
            // 
            this.entranceTime.HeaderText = "Entrance Time:";
            this.entranceTime.Name = "entranceTime";
            this.entranceTime.ReadOnly = true;
            // 
            // userId
            // 
            this.userId.HeaderText = "User ID:";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // InTheGym
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.dataGridViewSearchUsers);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelName);
            this.Name = "InTheGym";
            this.Size = new System.Drawing.Size(1030, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private Objects.buttonEllip buttonBack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewSearchUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn entranceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
    }
}
