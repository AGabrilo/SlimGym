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
            this.bunifuMaterialTextbox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelPassword = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textboxUsername = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelUsername = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panelDumbellIcon = new System.Windows.Forms.Panel();
            this.btnLogin = new ePOSOne.btnProduct.Button_WOC();
            this.panelLogIn.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogIn
            // 
            this.panelLogIn.BackColor = System.Drawing.Color.White;
            this.panelLogIn.Controls.Add(this.btnLogin);
            this.panelLogIn.Controls.Add(this.panelDumbellIcon);
            this.panelLogIn.Controls.Add(this.bunifuMaterialTextbox1);
            this.panelLogIn.Controls.Add(this.labelPassword);
            this.panelLogIn.Controls.Add(this.textboxUsername);
            this.panelLogIn.Controls.Add(this.labelUsername);
            this.panelLogIn.Controls.Add(this.bunifuCustomLabel1);
            this.panelLogIn.Location = new System.Drawing.Point(440, 60);
            this.panelLogIn.Name = "panelLogIn";
            this.panelLogIn.Size = new System.Drawing.Size(400, 500);
            this.panelLogIn.TabIndex = 0;
            // 
            // bunifuMaterialTextbox1
            // 
            this.bunifuMaterialTextbox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox1.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuMaterialTextbox1.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuMaterialTextbox1.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox1.HintText = "";
            this.bunifuMaterialTextbox1.isPassword = false;
            this.bunifuMaterialTextbox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox1.LineThickness = 4;
            this.bunifuMaterialTextbox1.Location = new System.Drawing.Point(54, 284);
            this.bunifuMaterialTextbox1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.bunifuMaterialTextbox1.Name = "bunifuMaterialTextbox1";
            this.bunifuMaterialTextbox1.Size = new System.Drawing.Size(292, 57);
            this.bunifuMaterialTextbox1.TabIndex = 4;
            this.bunifuMaterialTextbox1.Text = "tonija";
            this.bunifuMaterialTextbox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuMaterialTextbox1.OnValueChanged += new System.EventHandler(this.bunifuMaterialTextbox1_OnValueChanged);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelPassword.Location = new System.Drawing.Point(48, 257);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(125, 33);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Password:";
            this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // textboxUsername
            // 
            this.textboxUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textboxUsername.Font = new System.Drawing.Font("Tw Cen MT", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textboxUsername.ForeColor = System.Drawing.Color.DimGray;
            this.textboxUsername.HintForeColor = System.Drawing.Color.Empty;
            this.textboxUsername.HintText = "";
            this.textboxUsername.isPassword = false;
            this.textboxUsername.LineFocusedColor = System.Drawing.Color.Blue;
            this.textboxUsername.LineIdleColor = System.Drawing.Color.Gray;
            this.textboxUsername.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textboxUsername.LineThickness = 4;
            this.textboxUsername.Location = new System.Drawing.Point(54, 163);
            this.textboxUsername.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.textboxUsername.Name = "textboxUsername";
            this.textboxUsername.Size = new System.Drawing.Size(292, 57);
            this.textboxUsername.TabIndex = 2;
            this.textboxUsername.Text = "toni";
            this.textboxUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textboxUsername.OnValueChanged += new System.EventHandler(this.textboxUsername_OnValueChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Tw Cen MT", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.labelUsername.Location = new System.Drawing.Point(48, 134);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(130, 33);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Username:";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(51, 50);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(194, 47);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "SlimGym";
            this.bunifuCustomLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelDumbellIcon
            // 
            this.panelDumbellIcon.BackColor = System.Drawing.Color.Transparent;
            this.panelDumbellIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelDumbellIcon.BackgroundImage")));
            this.panelDumbellIcon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelDumbellIcon.Location = new System.Drawing.Point(251, 38);
            this.panelDumbellIcon.Name = "panelDumbellIcon";
            this.panelDumbellIcon.Size = new System.Drawing.Size(109, 59);
            this.panelDumbellIcon.TabIndex = 1;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.Transparent;
            this.btnLogin.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.btnLogin.ButtonColor = System.Drawing.Color.White;
            this.btnLogin.FlatAppearance.BorderSize = 0;
            this.btnLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(192, 396);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.btnLogin.OnHoverButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.btnLogin.OnHoverTextColor = System.Drawing.Color.White;
            this.btnLogin.Size = new System.Drawing.Size(168, 72);
            this.btnLogin.TabIndex = 1;
            this.btnLogin.Text = "Log In";
            this.btnLogin.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(180)))), ((int)(((byte)(30)))));
            this.btnLogin.UseVisualStyleBackColor = false;
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.panelLogIn);
            this.Name = "LogIn";
            this.Size = new System.Drawing.Size(1280, 645);
            this.panelLogIn.ResumeLayout(false);
            this.panelLogIn.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLogIn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox1;
        private Bunifu.Framework.UI.BunifuCustomLabel labelPassword;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textboxUsername;
        private Bunifu.Framework.UI.BunifuCustomLabel labelUsername;
        private System.Windows.Forms.Panel panelDumbellIcon;
        private ePOSOne.btnProduct.Button_WOC btnLogin;
    }
}
