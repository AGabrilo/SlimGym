namespace SlimGym_winversion.UserControls
{
    partial class Records
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Records));
            this.dataGridViewRecords = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.name2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.entranceTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelRecords = new System.Windows.Forms.Label();
            this.panelFilter = new SlimGym_winversion.Objects.panelEllip();
            this.buttonSearch = new SlimGym_winversion.Objects.buttonEllip();
            this.label1 = new System.Windows.Forms.Label();
            this.datePickerEntrance = new Bunifu.Framework.UI.BunifuDatepicker();
            this.datePickerExit = new Bunifu.Framework.UI.BunifuDatepicker();
            this.labelDateEntrance = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.labelTimeEntrance = new System.Windows.Forms.Label();
            this.labelTimeExit = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.labelFilter = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).BeginInit();
            this.panelFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewRecords
            // 
            this.dataGridViewRecords.AllowUserToAddRows = false;
            this.dataGridViewRecords.AllowUserToDeleteRows = false;
            this.dataGridViewRecords.AllowUserToResizeColumns = false;
            this.dataGridViewRecords.AllowUserToResizeRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRecords.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewRecords.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRecords.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRecords.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewRecords.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRecords.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewRecords.ColumnHeadersHeight = 33;
            this.dataGridViewRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewRecords.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name2,
            this.surname,
            this.entranceTime,
            this.exitTime,
            this.userId});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecords.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewRecords.DoubleBuffered = true;
            this.dataGridViewRecords.EnableHeadersVisualStyles = false;
            this.dataGridViewRecords.GridColor = System.Drawing.Color.Silver;
            this.dataGridViewRecords.HeaderBgColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridViewRecords.HeaderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.dataGridViewRecords.Location = new System.Drawing.Point(77, 154);
            this.dataGridViewRecords.MultiSelect = false;
            this.dataGridViewRecords.Name = "dataGridViewRecords";
            this.dataGridViewRecords.ReadOnly = true;
            this.dataGridViewRecords.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridViewRecords.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.Format = "E2";
            dataGridViewCellStyle8.NullValue = "0";
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            this.dataGridViewRecords.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewRecords.RowHeadersVisible = false;
            this.dataGridViewRecords.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewRecords.RowTemplate.ReadOnly = true;
            this.dataGridViewRecords.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewRecords.Size = new System.Drawing.Size(876, 423);
            this.dataGridViewRecords.TabIndex = 17;
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
            // exitTime
            // 
            this.exitTime.HeaderText = "Exit Time:";
            this.exitTime.Name = "exitTime";
            this.exitTime.ReadOnly = true;
            // 
            // userId
            // 
            this.userId.HeaderText = "User ID:";
            this.userId.Name = "userId";
            this.userId.ReadOnly = true;
            // 
            // labelRecords
            // 
            this.labelRecords.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRecords.BackColor = System.Drawing.Color.Transparent;
            this.labelRecords.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F);
            this.labelRecords.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelRecords.Location = new System.Drawing.Point(360, 11);
            this.labelRecords.Name = "labelRecords";
            this.labelRecords.Size = new System.Drawing.Size(310, 38);
            this.labelRecords.TabIndex = 18;
            this.labelRecords.Text = "Record of Users:";
            this.labelRecords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFilter
            // 
            this.panelFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFilter.BackColor = System.Drawing.Color.Gray;
            this.panelFilter.Controls.Add(this.buttonSearch);
            this.panelFilter.Controls.Add(this.label1);
            this.panelFilter.Controls.Add(this.datePickerEntrance);
            this.panelFilter.Controls.Add(this.datePickerExit);
            this.panelFilter.Controls.Add(this.labelDateEntrance);
            this.panelFilter.Controls.Add(this.maskedTextBox2);
            this.panelFilter.Controls.Add(this.labelTimeEntrance);
            this.panelFilter.Controls.Add(this.labelTimeExit);
            this.panelFilter.Controls.Add(this.maskedTextBox1);
            this.panelFilter.Location = new System.Drawing.Point(77, 52);
            this.panelFilter.Name = "panelFilter";
            this.panelFilter.Size = new System.Drawing.Size(876, 96);
            this.panelFilter.TabIndex = 21;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.buttonSearch.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSearch.BackgroundImage")));
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.BorderColor = System.Drawing.Color.Transparent;
            this.buttonSearch.BorderThickness = 6;
            this.buttonSearch.ButtonRoundness = 2;
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Location = new System.Drawing.Point(758, 3);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.OnClickTextColor = System.Drawing.Color.Transparent;
            this.buttonSearch.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.buttonSearch.Size = new System.Drawing.Size(86, 86);
            this.buttonSearch.TabIndex = 26;
            this.buttonSearch.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.label1.Location = new System.Drawing.Point(31, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Date Exit:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // datePickerEntrance
            // 
            this.datePickerEntrance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerEntrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.datePickerEntrance.BorderRadius = 0;
            this.datePickerEntrance.ForeColor = System.Drawing.Color.White;
            this.datePickerEntrance.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerEntrance.FormatCustom = null;
            this.datePickerEntrance.Location = new System.Drawing.Point(207, 9);
            this.datePickerEntrance.Name = "datePickerEntrance";
            this.datePickerEntrance.Size = new System.Drawing.Size(230, 35);
            this.datePickerEntrance.TabIndex = 25;
            this.datePickerEntrance.Value = new System.DateTime(2020, 11, 4, 21, 31, 47, 465);
            // 
            // datePickerExit
            // 
            this.datePickerExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.datePickerExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.datePickerExit.BorderRadius = 0;
            this.datePickerExit.ForeColor = System.Drawing.Color.White;
            this.datePickerExit.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.datePickerExit.FormatCustom = null;
            this.datePickerExit.Location = new System.Drawing.Point(207, 50);
            this.datePickerExit.Name = "datePickerExit";
            this.datePickerExit.Size = new System.Drawing.Size(230, 35);
            this.datePickerExit.TabIndex = 23;
            this.datePickerExit.Value = new System.DateTime(2020, 11, 4, 21, 31, 47, 465);
            // 
            // labelDateEntrance
            // 
            this.labelDateEntrance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelDateEntrance.AutoSize = true;
            this.labelDateEntrance.BackColor = System.Drawing.Color.Transparent;
            this.labelDateEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDateEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelDateEntrance.Location = new System.Drawing.Point(31, 15);
            this.labelDateEntrance.Name = "labelDateEntrance";
            this.labelDateEntrance.Size = new System.Drawing.Size(170, 29);
            this.labelDateEntrance.TabIndex = 21;
            this.labelDateEntrance.Text = "Date Entrance:";
            this.labelDateEntrance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.AllowPromptAsInput = false;
            this.maskedTextBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox2.BackColor = System.Drawing.Color.Gray;
            this.maskedTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox2.Culture = new System.Globalization.CultureInfo("hr-HR");
            this.maskedTextBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.maskedTextBox2.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox2.Location = new System.Drawing.Point(644, 52);
            this.maskedTextBox2.Mask = "00:00";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.PromptChar = '-';
            this.maskedTextBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox2.Size = new System.Drawing.Size(82, 31);
            this.maskedTextBox2.TabIndex = 22;
            this.maskedTextBox2.Text = "0000";
            this.maskedTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox2.ValidatingType = typeof(System.DateTime);
            // 
            // labelTimeEntrance
            // 
            this.labelTimeEntrance.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeEntrance.AutoSize = true;
            this.labelTimeEntrance.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeEntrance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeEntrance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelTimeEntrance.Location = new System.Drawing.Point(462, 15);
            this.labelTimeEntrance.Name = "labelTimeEntrance";
            this.labelTimeEntrance.Size = new System.Drawing.Size(176, 29);
            this.labelTimeEntrance.TabIndex = 22;
            this.labelTimeEntrance.Text = "Time Entrance:";
            this.labelTimeEntrance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelTimeExit
            // 
            this.labelTimeExit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTimeExit.AutoSize = true;
            this.labelTimeExit.BackColor = System.Drawing.Color.Transparent;
            this.labelTimeExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTimeExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelTimeExit.Location = new System.Drawing.Point(462, 55);
            this.labelTimeExit.Name = "labelTimeExit";
            this.labelTimeExit.Size = new System.Drawing.Size(120, 29);
            this.labelTimeExit.TabIndex = 24;
            this.labelTimeExit.Text = "Time Exit:";
            this.labelTimeExit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTextBox1.BackColor = System.Drawing.Color.Gray;
            this.maskedTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.maskedTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.maskedTextBox1.ForeColor = System.Drawing.Color.White;
            this.maskedTextBox1.Location = new System.Drawing.Point(644, 12);
            this.maskedTextBox1.Mask = "00:00";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.PromptChar = '-';
            this.maskedTextBox1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.maskedTextBox1.Size = new System.Drawing.Size(82, 31);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.Text = "0000";
            this.maskedTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // labelFilter
            // 
            this.labelFilter.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelFilter.Location = new System.Drawing.Point(108, 35);
            this.labelFilter.Name = "labelFilter";
            this.labelFilter.Size = new System.Drawing.Size(80, 32);
            this.labelFilter.TabIndex = 23;
            this.labelFilter.Text = "Filter:";
            this.labelFilter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Records
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.labelFilter);
            this.Controls.Add(this.panelFilter);
            this.Controls.Add(this.labelRecords);
            this.Controls.Add(this.dataGridViewRecords);
            this.Name = "Records";
            this.Size = new System.Drawing.Size(1030, 645);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRecords)).EndInit();
            this.panelFilter.ResumeLayout(false);
            this.panelFilter.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid dataGridViewRecords;
        private System.Windows.Forms.Label labelRecords;
        private System.Windows.Forms.DataGridViewTextBoxColumn name2;
        private System.Windows.Forms.DataGridViewTextBoxColumn surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn entranceTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn userId;
        private Objects.panelEllip panelFilter;
        private Objects.buttonEllip buttonSearch;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerEntrance;
        private Bunifu.Framework.UI.BunifuDatepicker datePickerExit;
        private System.Windows.Forms.Label labelDateEntrance;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.Label labelTimeEntrance;
        private System.Windows.Forms.Label labelTimeExit;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Label labelFilter;
    }
}
