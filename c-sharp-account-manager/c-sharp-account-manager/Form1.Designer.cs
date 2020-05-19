namespace c_sharp_account_manager
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.panel1 = new System.Windows.Forms.Panel();
            this.forgotPasswordLabel = new System.Windows.Forms.Label();
            this.loginButtonPanel = new System.Windows.Forms.Panel();
            this.loginButtonLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordContainer = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.userIdContainer = new System.Windows.Forms.Panel();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.welcomeNoteLabel = new System.Windows.Forms.Label();
            this.appDevNameLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.minimiseIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.signUpButton = new System.Windows.Forms.Panel();
            this.signUpButtonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.loginImage = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.loginButtonPanel.SuspendLayout();
            this.passwordContainer.SuspendLayout();
            this.userIdContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseIcon)).BeginInit();
            this.panel2.SuspendLayout();
            this.signUpButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.forgotPasswordLabel);
            this.panel1.Controls.Add(this.loginButtonPanel);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Controls.Add(this.passwordContainer);
            this.panel1.Controls.Add(this.userIdLabel);
            this.panel1.Controls.Add(this.userIdContainer);
            this.panel1.Controls.Add(this.welcomeNoteLabel);
            this.panel1.Controls.Add(this.appDevNameLabel);
            this.panel1.Controls.Add(this.appNameLabel);
            this.panel1.Controls.Add(this.logoImage);
            this.panel1.Location = new System.Drawing.Point(1, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(469, 506);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // forgotPasswordLabel
            // 
            this.forgotPasswordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.forgotPasswordLabel.AutoSize = true;
            this.forgotPasswordLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.forgotPasswordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forgotPasswordLabel.ForeColor = System.Drawing.Color.Black;
            this.forgotPasswordLabel.Location = new System.Drawing.Point(253, 427);
            this.forgotPasswordLabel.Name = "forgotPasswordLabel";
            this.forgotPasswordLabel.Size = new System.Drawing.Size(125, 13);
            this.forgotPasswordLabel.TabIndex = 11;
            this.forgotPasswordLabel.Text = "Forgot your password?";
            // 
            // loginButtonPanel
            // 
            this.loginButtonPanel.BackColor = System.Drawing.Color.Black;
            this.loginButtonPanel.Controls.Add(this.loginButtonLabel);
            this.loginButtonPanel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtonPanel.Location = new System.Drawing.Point(82, 372);
            this.loginButtonPanel.Name = "loginButtonPanel";
            this.loginButtonPanel.Size = new System.Drawing.Size(296, 35);
            this.loginButtonPanel.TabIndex = 10;
            this.loginButtonPanel.MouseEnter += new System.EventHandler(this.loginButtonPanel_MouseEnter);
            this.loginButtonPanel.MouseLeave += new System.EventHandler(this.loginButtonPanel_MouseLeave);
            // 
            // loginButtonLabel
            // 
            this.loginButtonLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.loginButtonLabel.AutoSize = true;
            this.loginButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtonLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButtonLabel.ForeColor = System.Drawing.Color.White;
            this.loginButtonLabel.Location = new System.Drawing.Point(123, 9);
            this.loginButtonLabel.Name = "loginButtonLabel";
            this.loginButtonLabel.Size = new System.Drawing.Size(47, 17);
            this.loginButtonLabel.TabIndex = 0;
            this.loginButtonLabel.Text = "Log in";
            this.loginButtonLabel.MouseEnter += new System.EventHandler(this.loginButtonPanel_MouseEnter);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.Location = new System.Drawing.Point(79, 297);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(55, 13);
            this.passwordLabel.TabIndex = 10;
            this.passwordLabel.Text = "Password";
            // 
            // passwordContainer
            // 
            this.passwordContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordContainer.Controls.Add(this.passwordTextBox);
            this.passwordContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordContainer.Location = new System.Drawing.Point(82, 317);
            this.passwordContainer.Name = "passwordContainer";
            this.passwordContainer.Padding = new System.Windows.Forms.Padding(1);
            this.passwordContainer.Size = new System.Drawing.Size(296, 35);
            this.passwordContainer.TabIndex = 9;
            this.passwordContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.passwordTextBox.Location = new System.Drawing.Point(14, 7);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(265, 20);
            this.passwordTextBox.TabIndex = 6;
            this.passwordTextBox.Text = "Enter password";
            this.passwordTextBox.Enter += new System.EventHandler(this.passwordTextBox_Enter);
            this.passwordTextBox.Leave += new System.EventHandler(this.passwordTextBox_Leave);
            // 
            // userIdLabel
            // 
            this.userIdLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.userIdLabel.AutoSize = true;
            this.userIdLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userIdLabel.Location = new System.Drawing.Point(79, 220);
            this.userIdLabel.Name = "userIdLabel";
            this.userIdLabel.Size = new System.Drawing.Size(44, 13);
            this.userIdLabel.TabIndex = 8;
            this.userIdLabel.Text = "User ID";
            // 
            // userIdContainer
            // 
            this.userIdContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.userIdContainer.Controls.Add(this.uidTextBox);
            this.userIdContainer.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.userIdContainer.Location = new System.Drawing.Point(82, 240);
            this.userIdContainer.Name = "userIdContainer";
            this.userIdContainer.Padding = new System.Windows.Forms.Padding(1);
            this.userIdContainer.Size = new System.Drawing.Size(296, 35);
            this.userIdContainer.TabIndex = 7;
            this.userIdContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            // 
            // uidTextBox
            // 
            this.uidTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.uidTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.uidTextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidTextBox.ForeColor = System.Drawing.Color.DimGray;
            this.uidTextBox.Location = new System.Drawing.Point(14, 7);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(265, 20);
            this.uidTextBox.TabIndex = 6;
            this.uidTextBox.Text = "Enter user ID";
            this.uidTextBox.Enter += new System.EventHandler(this.uidTextBox_Enter);
            this.uidTextBox.Leave += new System.EventHandler(this.uidTextBox_Leave);
            // 
            // welcomeNoteLabel
            // 
            this.welcomeNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeNoteLabel.AutoSize = true;
            this.welcomeNoteLabel.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeNoteLabel.Location = new System.Drawing.Point(121, 135);
            this.welcomeNoteLabel.Name = "welcomeNoteLabel";
            this.welcomeNoteLabel.Size = new System.Drawing.Size(220, 37);
            this.welcomeNoteLabel.TabIndex = 5;
            this.welcomeNoteLabel.Text = "Welcome Back!";
            // 
            // appDevNameLabel
            // 
            this.appDevNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appDevNameLabel.AutoSize = true;
            this.appDevNameLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appDevNameLabel.Location = new System.Drawing.Point(207, 102);
            this.appDevNameLabel.Name = "appDevNameLabel";
            this.appDevNameLabel.Size = new System.Drawing.Size(90, 13);
            this.appDevNameLabel.TabIndex = 4;
            this.appDevNameLabel.Text = "by Jassu Sharma";
            // 
            // appNameLabel
            // 
            this.appNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(203, 72);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(92, 30);
            this.appNameLabel.TabIndex = 3;
            this.appNameLabel.Text = "TestApp";
            // 
            // logoImage
            // 
            this.logoImage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(151, 70);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(50, 50);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 1;
            this.logoImage.TabStop = false;
            // 
            // closeIcon
            // 
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeIcon.Image = ((System.Drawing.Image)(resources.GetObject("closeIcon.Image")));
            this.closeIcon.Location = new System.Drawing.Point(832, 15);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(22, 22);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 1;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // minimiseIcon
            // 
            this.minimiseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimiseIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.minimiseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimiseIcon.Image = ((System.Drawing.Image)(resources.GetObject("minimiseIcon.Image")));
            this.minimiseIcon.Location = new System.Drawing.Point(806, 15);
            this.minimiseIcon.Name = "minimiseIcon";
            this.minimiseIcon.Size = new System.Drawing.Size(22, 22);
            this.minimiseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimiseIcon.TabIndex = 2;
            this.minimiseIcon.TabStop = false;
            this.minimiseIcon.Click += new System.EventHandler(this.minimiseIcon_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.copyrightLabel);
            this.panel2.Controls.Add(this.signUpButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.loginImage);
            this.panel2.Location = new System.Drawing.Point(457, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 503);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyrightLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copyrightLabel.Location = new System.Drawing.Point(307, 481);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(87, 13);
            this.copyrightLabel.TabIndex = 12;
            this.copyrightLabel.Text = "© Jassu Sharma";
            this.copyrightLabel.Click += new System.EventHandler(this.copyrightLabel_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.Controls.Add(this.signUpButtonLabel);
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Location = new System.Drawing.Point(307, 151);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(64, 25);
            this.signUpButton.TabIndex = 12;
            this.signUpButton.Click += new System.EventHandler(this.signUpButtonLabel_Click);
            this.signUpButton.Paint += new System.Windows.Forms.PaintEventHandler(this.container_Paint);
            this.signUpButton.MouseEnter += new System.EventHandler(this.signUpButton_MouseEnter);
            this.signUpButton.MouseLeave += new System.EventHandler(this.signUpButton_MouseLeave);
            // 
            // signUpButtonLabel
            // 
            this.signUpButtonLabel.AutoSize = true;
            this.signUpButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButtonLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButtonLabel.Location = new System.Drawing.Point(10, 6);
            this.signUpButtonLabel.Name = "signUpButtonLabel";
            this.signUpButtonLabel.Size = new System.Drawing.Size(45, 13);
            this.signUpButtonLabel.TabIndex = 0;
            this.signUpButtonLabel.Text = "SignUp";
            this.signUpButtonLabel.Click += new System.EventHandler(this.signUpButtonLabel_Click);
            this.signUpButtonLabel.MouseEnter += new System.EventHandler(this.signUpButton_MouseEnter);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(200, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 21);
            this.label1.TabIndex = 11;
            this.label1.Text = "Don\'t have an account?";
            // 
            // loginImage
            // 
            this.loginImage.Image = ((System.Drawing.Image)(resources.GetObject("loginImage.Image")));
            this.loginImage.Location = new System.Drawing.Point(78, 240);
            this.loginImage.Name = "loginImage";
            this.loginImage.Size = new System.Drawing.Size(200, 200);
            this.loginImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginImage.TabIndex = 0;
            this.loginImage.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 500);
            this.Controls.Add(this.minimiseIcon);
            this.Controls.Add(this.closeIcon);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginButtonPanel.ResumeLayout(false);
            this.loginButtonPanel.PerformLayout();
            this.passwordContainer.ResumeLayout(false);
            this.passwordContainer.PerformLayout();
            this.userIdContainer.ResumeLayout(false);
            this.userIdContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.signUpButton.ResumeLayout(false);
            this.signUpButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.PictureBox minimiseIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox loginImage;
        private System.Windows.Forms.Label appDevNameLabel;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Label welcomeNoteLabel;
        private System.Windows.Forms.TextBox uidTextBox;
        private System.Windows.Forms.Panel userIdContainer;
        private System.Windows.Forms.Label userIdLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel passwordContainer;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel signUpButton;
        private System.Windows.Forms.Label signUpButtonLabel;
        private System.Windows.Forms.Panel loginButtonPanel;
        private System.Windows.Forms.Label loginButtonLabel;
        private System.Windows.Forms.Label forgotPasswordLabel;
        private System.Windows.Forms.Label copyrightLabel;
    }
}

