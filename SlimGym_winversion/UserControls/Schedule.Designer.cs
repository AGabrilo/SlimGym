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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Schedule));
            this.buttonNext = new SlimGym_winversion.Objects.buttonEllip();
            this.datePicker = new SlimGym_winversion.Objects.datePickerEllip();
            this.panelSchedule = new SlimGym_winversion.Objects.panelEllipSchedule();
            this.buttonPrevious = new SlimGym_winversion.Objects.buttonEllip();
            this.SuspendLayout();
            // 
            // buttonNext
            // 
            this.buttonNext.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonNext.BackColor = System.Drawing.Color.Transparent;
            this.buttonNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonNext.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonNext.BorderThickness = 6;
            this.buttonNext.ButtonRoundness = 3;
            this.buttonNext.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonNext.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNext.Image = ((System.Drawing.Image)(resources.GetObject("buttonNext.Image")));
            this.buttonNext.Location = new System.Drawing.Point(765, 10);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.OnClickTextColor = System.Drawing.Color.Transparent;
            this.buttonNext.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.buttonNext.Size = new System.Drawing.Size(91, 75);
            this.buttonNext.TabIndex = 27;
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // datePicker
            // 
            this.datePicker.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.datePicker.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.datePicker.BorderRadius = 2;
            this.datePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datePicker.ForeColor = System.Drawing.Color.White;
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.FormatCustom = null;
            this.datePicker.Location = new System.Drawing.Point(383, 20);
            this.datePicker.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.datePicker.Name = "datePicker";
            this.datePicker.Roundness = 1;
            this.datePicker.Size = new System.Drawing.Size(264, 60);
            this.datePicker.TabIndex = 26;
            this.datePicker.Value = new System.DateTime(2020, 11, 5, 13, 47, 23, 0);
            // 
            // panelSchedule
            // 
            this.panelSchedule.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSchedule.BackColor = System.Drawing.Color.White;
            this.panelSchedule.BorderColor = System.Drawing.Color.Transparent;
            this.panelSchedule.BorderThickness = 0;
            this.panelSchedule.HorizontalLineLocationXAxis = 5;
            this.panelSchedule.Location = new System.Drawing.Point(20, 95);
            this.panelSchedule.MaximumSize = new System.Drawing.Size(1630, 884);
            this.panelSchedule.Name = "panelSchedule";
            this.panelSchedule.NumberOfHorizontalSegments = 17;
            this.panelSchedule.NumberOfVerticalSegments = 3;
            this.panelSchedule.PanelRoundness = 30;
            this.panelSchedule.Size = new System.Drawing.Size(990, 544);
            this.panelSchedule.TabIndex = 7;
            this.panelSchedule.VerticalLineLocationYAxis = 3;
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.buttonPrevious.BackColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPrevious.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonPrevious.BorderThickness = 6;
            this.buttonPrevious.ButtonRoundness = 3;
            this.buttonPrevious.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.buttonPrevious.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.buttonPrevious.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPrevious.Image = ((System.Drawing.Image)(resources.GetObject("buttonPrevious.Image")));
            this.buttonPrevious.Location = new System.Drawing.Point(174, 10);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.OnClickTextColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.OnHoverTextColor = System.Drawing.Color.Transparent;
            this.buttonPrevious.Size = new System.Drawing.Size(91, 75);
            this.buttonPrevious.TabIndex = 28;
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Controls.Add(this.buttonPrevious);
            this.Controls.Add(this.buttonNext);
            this.Controls.Add(this.datePicker);
            this.Controls.Add(this.panelSchedule);
            this.Name = "Schedule";
            this.Size = new System.Drawing.Size(1030, 645);
            this.ResumeLayout(false);

        }

        #endregion
        private Objects.panelEllipSchedule panelSchedule;
        private Objects.datePickerEllip datePicker;
        private Objects.buttonEllip buttonNext;
        private Objects.buttonEllip buttonPrevious;
    }
}
