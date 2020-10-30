namespace SlimGym_winversion
{
    partial class SlimGym
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SlimGym));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.panelDumbellIcon = new System.Windows.Forms.Panel();
            this.labelTitle = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelBody = new System.Windows.Forms.Panel();
            this.panelFooter = new System.Windows.Forms.Panel();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelFooter.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(220)))), ((int)(((byte)(30)))));
            this.panelHeader.Controls.Add(this.buttonMinimize);
            this.panelHeader.Controls.Add(this.buttonExit);
            this.panelHeader.Controls.Add(this.buttonMaximize);
            this.panelHeader.Controls.Add(this.panelDumbellIcon);
            this.panelHeader.Controls.Add(this.labelTitle);
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Margin = new System.Windows.Forms.Padding(2);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1280, 50);
            this.panelHeader.TabIndex = 0;
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMinimize.BackgroundImage")));
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(180)))), ((int)(((byte)(25)))));
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(1130, 0);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(50, 50);
            this.buttonMinimize.TabIndex = 4;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonExit.BackgroundImage")));
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1230, 0);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(50, 50);
            this.buttonExit.TabIndex = 3;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonMaximize.BackgroundImage")));
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.buttonMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(165)))), ((int)(((byte)(25)))));
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Location = new System.Drawing.Point(1180, 0);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(50, 50);
            this.buttonMaximize.TabIndex = 0;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // panelDumbellIcon
            // 
            this.panelDumbellIcon.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelDumbellIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelDumbellIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDumbellIcon.BackgroundImage")));
            this.panelDumbellIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDumbellIcon.Location = new System.Drawing.Point(693, 0);
            this.panelDumbellIcon.Margin = new System.Windows.Forms.Padding(2);
            this.panelDumbellIcon.Name = "panelDumbellIcon";
            this.panelDumbellIcon.Size = new System.Drawing.Size(85, 50);
            this.panelDumbellIcon.TabIndex = 2;
            // 
            // labelTitle
            // 
            this.labelTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelTitle.BackColor = System.Drawing.Color.Transparent;
            this.labelTitle.Font = new System.Drawing.Font("Century Gothic", 27F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Black;
            this.labelTitle.Location = new System.Drawing.Point(502, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(190, 50);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "SlimGym";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelBody
            // 
            this.panelBody.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBody.BackColor = System.Drawing.Color.White;
            this.panelBody.Location = new System.Drawing.Point(0, 50);
            this.panelBody.Margin = new System.Windows.Forms.Padding(2);
            this.panelBody.Name = "panelBody";
            this.panelBody.Size = new System.Drawing.Size(1280, 645);
            this.panelBody.TabIndex = 1;
            // 
            // panelFooter
            // 
            this.panelFooter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelFooter.BackColor = System.Drawing.Color.Silver;
            this.panelFooter.Controls.Add(this.labelTime);
            this.panelFooter.Controls.Add(this.labelDate);
            this.panelFooter.Location = new System.Drawing.Point(0, 695);
            this.panelFooter.Margin = new System.Windows.Forms.Padding(2);
            this.panelFooter.Name = "panelFooter";
            this.panelFooter.Size = new System.Drawing.Size(1280, 25);
            this.panelFooter.TabIndex = 2;
            // 
            // labelTime
            // 
            this.labelTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.Location = new System.Drawing.Point(105, 0);
            this.labelTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(105, 20);
            this.labelTime.TabIndex = 4;
            this.labelTime.Text = "Time: 23:59:59";
            this.labelTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelDate
            // 
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDate.Location = new System.Drawing.Point(0, 0);
            this.labelDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(105, 20);
            this.labelDate.TabIndex = 2;
            this.labelDate.Text = "Date: 21.10.2020.";
            this.labelDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.panelFooter);
            this.Controls.Add(this.panelBody);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SlimGym";
            this.panelHeader.ResumeLayout(false);
            this.panelFooter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelBody;
        private System.Windows.Forms.Panel panelFooter;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private Bunifu.Framework.UI.BunifuCustomLabel labelTitle;
        private System.Windows.Forms.Panel panelDumbellIcon;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonMaximize;
    }
}

