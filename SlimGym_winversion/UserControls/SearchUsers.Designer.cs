namespace SlimGym_winversion.UserControls
{
    partial class SearchUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchUsers));
            this.labelName = new System.Windows.Forms.Label();
            this.labelSurname = new System.Windows.Forms.Label();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.labelPersonalID = new System.Windows.Forms.Label();
            this.dataGridViewSearchUsers = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.buttonSelect = new SlimGym_winversion.Objects.buttonEllip();
            this.buttonBack = new SlimGym_winversion.Objects.buttonEllip();
            this.buttonSearch = new SlimGym_winversion.Objects.buttonEllip();
            this.textBoxBithDate = new RoundTextBoxExample.textBoxEllip();
            this.textBoxPersonalID = new RoundTextBoxExample.textBoxEllip();
            this.textBoxSurname = new RoundTextBoxExample.textBoxEllip();
            this.textBoxName = new RoundTextBoxExample.textBoxEllip();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUsers)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelName.Location = new System.Drawing.Point(63, 25);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(120, 25);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name:";
            // 
            // labelSurname
            // 
            this.labelSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSurname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelSurname.Location = new System.Drawing.Point(63, 71);
            this.labelSurname.Name = "labelSurname";
            this.labelSurname.Size = new System.Drawing.Size(120, 25);
            this.labelSurname.TabIndex = 9;
            this.labelSurname.Text = "Surname:";
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBirthDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelBirthDate.Location = new System.Drawing.Point(464, 71);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(145, 25);
            this.labelBirthDate.TabIndex = 10;
            this.labelBirthDate.Text = "Birth Date:";
            // 
            // labelPersonalID
            // 
            this.labelPersonalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPersonalID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelPersonalID.Location = new System.Drawing.Point(464, 25);
            this.labelPersonalID.Name = "labelPersonalID";
            this.labelPersonalID.Size = new System.Drawing.Size(145, 25);
            this.labelPersonalID.TabIndex = 8;
            this.labelPersonalID.Text = "Personal ID:";
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
            this.dataGridViewSearchUsers.Location = new System.Drawing.Point(68, 137);
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
            this.dataGridViewSearchUsers.Size = new System.Drawing.Size(880, 392);
            this.dataGridViewSearchUsers.TabIndex = 1;
            // 
            // buttonSelect
            // 
            this.buttonSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSelect.BackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonSelect.BorderThickness = 6;
            this.buttonSelect.ButtonRoundness = 1;
            this.buttonSelect.FlatAppearance.BorderSize = 0;
            this.buttonSelect.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.buttonSelect.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonSelect.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSelect.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonSelect.Location = new System.Drawing.Point(885, 564);
            this.buttonSelect.MaximumSize = new System.Drawing.Size(600, 390);
            this.buttonSelect.Name = "buttonSelect";
            this.buttonSelect.OnClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonSelect.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonSelect.Size = new System.Drawing.Size(115, 51);
            this.buttonSelect.TabIndex = 6;
            this.buttonSelect.Text = "Select";
            this.buttonSelect.UseVisualStyleBackColor = false;
            this.buttonSelect.Click += new System.EventHandler(this.buttonSelect_Click);
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
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Back";
            this.buttonBack.UseVisualStyleBackColor = false;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderThickness = 6;
            this.buttonSearch.ButtonRoundness = 2;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(862, 20);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.OnClickTextColor = System.Drawing.Color.Transparent;
            this.buttonSearch.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Size = new System.Drawing.Size(86, 86);
            this.buttonSearch.TabIndex = 4;
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxBithDate
            // 
            this.textBoxBithDate.BackColor = System.Drawing.Color.Transparent;
            this.textBoxBithDate.BorderColor = System.Drawing.Color.Silver;
            this.textBoxBithDate.BorderSize = 1;
            this.textBoxBithDate.Br = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxBithDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBithDate.ForeColor = System.Drawing.Color.White;
            this.textBoxBithDate.Location = new System.Drawing.Point(614, 66);
            this.textBoxBithDate.Name = "textBoxBithDate";
            this.textBoxBithDate.PasswordChar = '\0';
            this.textBoxBithDate.Size = new System.Drawing.Size(200, 40);
            this.textBoxBithDate.TabIndex = 3;
            this.textBoxBithDate.textboxRadius = 15;
            this.textBoxBithDate.UseSystemPasswordChar = false;
            // 
            // textBoxPersonalID
            // 
            this.textBoxPersonalID.BackColor = System.Drawing.Color.Transparent;
            this.textBoxPersonalID.BorderColor = System.Drawing.Color.Silver;
            this.textBoxPersonalID.BorderSize = 1;
            this.textBoxPersonalID.Br = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxPersonalID.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPersonalID.ForeColor = System.Drawing.Color.White;
            this.textBoxPersonalID.Location = new System.Drawing.Point(614, 20);
            this.textBoxPersonalID.Name = "textBoxPersonalID";
            this.textBoxPersonalID.PasswordChar = '\0';
            this.textBoxPersonalID.Size = new System.Drawing.Size(200, 40);
            this.textBoxPersonalID.TabIndex = 2;
            this.textBoxPersonalID.textboxRadius = 15;
            this.textBoxPersonalID.UseSystemPasswordChar = false;
            // 
            // textBoxSurname
            // 
            this.textBoxSurname.BackColor = System.Drawing.Color.Transparent;
            this.textBoxSurname.BorderColor = System.Drawing.Color.Silver;
            this.textBoxSurname.BorderSize = 1;
            this.textBoxSurname.Br = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSurname.ForeColor = System.Drawing.Color.White;
            this.textBoxSurname.Location = new System.Drawing.Point(180, 66);
            this.textBoxSurname.Name = "textBoxSurname";
            this.textBoxSurname.PasswordChar = '\0';
            this.textBoxSurname.Size = new System.Drawing.Size(200, 40);
            this.textBoxSurname.TabIndex = 1;
            this.textBoxSurname.textboxRadius = 15;
            this.textBoxSurname.UseSystemPasswordChar = false;
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.Transparent;
            this.textBoxName.BorderColor = System.Drawing.Color.Silver;
            this.textBoxName.BorderSize = 1;
            this.textBoxName.Br = System.Drawing.SystemColors.ControlDarkDark;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxName.ForeColor = System.Drawing.Color.White;
            this.textBoxName.Location = new System.Drawing.Point(180, 20);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.PasswordChar = '\0';
            this.textBoxName.Size = new System.Drawing.Size(200, 40);
            this.textBoxName.TabIndex = 0;
            this.textBoxName.textboxRadius = 15;
            this.textBoxName.UseSystemPasswordChar = false;
            // 
            // SearchUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.buttonSelect);
            this.Controls.Add(this.dataGridViewSearchUsers);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.textBoxBithDate);
            this.Controls.Add(this.labelBirthDate);
            this.Controls.Add(this.textBoxPersonalID);
            this.Controls.Add(this.labelPersonalID);
            this.Controls.Add(this.textBoxSurname);
            this.Controls.Add(this.labelSurname);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Name = "SearchUsers";
            this.Size = new System.Drawing.Size(1030, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSearchUsers)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelName;
        private RoundTextBoxExample.textBoxEllip textBoxName;
        private RoundTextBoxExample.textBoxEllip textBoxSurname;
        private System.Windows.Forms.Label labelSurname;
        private RoundTextBoxExample.textBoxEllip textBoxBithDate;
        private System.Windows.Forms.Label labelBirthDate;
        private RoundTextBoxExample.textBoxEllip textBoxPersonalID;
        private System.Windows.Forms.Label labelPersonalID;
        private Objects.buttonEllip buttonSearch;
        private Objects.buttonEllip buttonBack;
        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewSearchUsers;
        private Objects.buttonEllip buttonSelect;
    }
}
