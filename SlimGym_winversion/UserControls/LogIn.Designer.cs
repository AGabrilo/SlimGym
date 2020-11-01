namespace SlimGym_winversion
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.panelLogIn = new System.Windows.Forms.Panel();
            this.buttonLogIn = new SlimGym_winversion.Objects.buttonEllip();
            this.linkLabelForgotPassword = new System.Windows.Forms.LinkLabel();
            this.panelDumbellIcon = new System.Windows.Forms.Panel();
            this.textBoxPassword = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogIn.BackColor = System.Drawing.Color.White;
            this.panelLogIn.Controls.Add(this.buttonLogIn);
            this.panelLogIn.Controls.Add(this.linkLabelForgotPassword);
            this.panelLogIn.Controls.Add(this.panelDumbellIcon);
            this.panelLogIn.Controls.Add(this.textBoxPassword);
            this.panelLogIn.Controls.Add(this.labelPassword);
            this.panelLogIn.Controls.Add(this.textboxUsername);
            this.panelLogIn.Controls.Add(this.labelUsername);
            this.panelLogIn.Controls.Add(this.bunifuCustomLabel1);
            this.panelLogIn.Location = new System.Drawing.Point(440, 60);
            this.panelLogIn.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(400, 475);
            this.panelLogIn.TabIndex = 0;
            // 
            // buttonLogIn
            // 
            this.buttonLogIn.BackColor = System.Drawing.Color.Transparent;
            this.buttonLogIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonLogIn.BorderThickness = 6;
            this.buttonLogIn.ButtonRoundness = 1;
            this.buttonLogIn.FlatAppearance.BorderSize = 0;
            this.buttonLogIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.buttonLogIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonLogIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogIn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonLogIn.Location = new System.Drawing.Point(210, 373);
            this.buttonLogIn.Name = "buttonLogIn";
            this.buttonLogIn.OnClickTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.buttonLogIn.OnHoverTextColor = System.Drawing.Color.White;
            this.buttonLogIn.Size = new System.Drawing.Size(149, 54);
            this.buttonLogIn.TabIndex = 6;
            this.buttonLogIn.Text = "Log In";
            this.buttonLogIn.UseVisualStyleBackColor = false;
            this.buttonLogIn.Click += new System.EventHandler(this.buttonLogIn_Click);
            // 
            // linkLabelForgotPassword
            // 
            this.linkLabelForgotPassword.AutoSize = true;
            this.linkLabelForgotPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabelForgotPassword.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.linkLabelForgotPassword.Location = new System.Drawing.Point(37, 392);
            this.linkLabelForgotPassword.Name = "linkLabelForgotPassword";
            this.linkLabelForgotPassword.Size = new System.Drawing.Size(128, 20);
            this.linkLabelForgotPassword.TabIndex = 5;
            this.linkLabelForgotPassword.TabStop = true;
            this.linkLabelForgotPassword.Text = "Forgot password";
            // 
            // panelDumbellIcon
            // 
            this.panelDumbellIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelDumbellIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDumbellIcon.BackgroundImage")));
            this.panelDumbellIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDumbellIcon.Location = new System.Drawing.Point(249, 31);
            this.panelDumbellIcon.Margin = new System.Windows.Forms.Padding(2);
            this.panelDumbellIcon.Name = "panelDumbellIcon";
            this.panelDumbellIcon.Size = new System.Drawing.Size(110, 65);
            this.panelDumbellIcon.TabIndex = 1;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBoxPassword.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.textBoxPassword.ForeColor = System.Drawing.Color.DimGray;
            this.textBoxPassword.HintForeColor = System.Drawing.Color.Empty;
            this.textBoxPassword.HintText = "";
            this.textBoxPassword.isPassword = true;
            this.textBoxPassword.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.textBoxPassword.LineIdleColor = System.Drawing.Color.Gray;
            this.textBoxPassword.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.textBoxPassword.LineThickness = 5;
            this.textBoxPassword.Location = new System.Drawing.Point(39, 280);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(250, 50);
            this.textBoxPassword.TabIndex = 4;
            this.textBoxPassword.Text = "tonija";
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tw Cen MT", 20F);
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelPassword.Location = new System.Drawing.Point(35, 254);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(123, 31);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            // 
            // textboxUsername
            // 
            this.textboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxUsername.Font = new System.Drawing.Font("Tw Cen MT", 16F);
            this.textboxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.textboxUsername.HintForeColor = System.Drawing.Color.Transparent;
            this.textboxUsername.HintText = "";
            this.textboxUsername.isPassword = false;
            this.textboxUsername.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.textboxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxUsername.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.textboxUsername.LineThickness = 6;
            this.textboxUsername.Location = new System.Drawing.Point(40, 171);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(4);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(250, 50);
            this.textboxUsername.TabIndex = 2;
            this.textboxUsername.Text = "toni";
            this.textboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Tw Cen MT", 20F);
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelUsername.Location = new System.Drawing.Point(35, 145);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(127, 31);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(33, 49);
            this.bunifuCustomLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(194, 47);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "SlimGym";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panelLogIn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(1280, 645);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBoxPassword;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUsername;
        private System.Windows.Forms.Panel panelDumbellIcon;
        private System.Windows.Forms.LinkLabel linkLabelForgotPassword;
        private Objects.buttonEllip buttonLogIn;
    }
}
