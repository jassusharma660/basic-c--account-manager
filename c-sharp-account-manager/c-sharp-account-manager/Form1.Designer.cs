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
            this.userIdContainer = new System.Windows.Forms.Panel();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.welcomeNoteLabel = new System.Windows.Forms.Label();
            this.appDevNameLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.minimiseIcon = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.loginImages = new System.Windows.Forms.PictureBox();
            this.userIdLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.passwordContainer = new System.Windows.Forms.Panel();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.userIdContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseIcon)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loginImages)).BeginInit();
            this.passwordContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
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
            this.userIdContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.userIdContainer_Paint);
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
            this.panel2.Controls.Add(this.loginImages);
            this.panel2.Location = new System.Drawing.Point(457, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(414, 503);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            // 
            // loginImages
            // 
            this.loginImages.Image = ((System.Drawing.Image)(resources.GetObject("loginImages.Image")));
            this.loginImages.Location = new System.Drawing.Point(121, 120);
            this.loginImages.Name = "loginImages";
            this.loginImages.Size = new System.Drawing.Size(200, 200);
            this.loginImages.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loginImages.TabIndex = 0;
            this.loginImages.TabStop = false;
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
            this.passwordContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.passwordContainer_Paint);
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
            this.Text = "Login";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.userIdContainer.ResumeLayout(false);
            this.userIdContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseIcon)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loginImages)).EndInit();
            this.passwordContainer.ResumeLayout(false);
            this.passwordContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.PictureBox minimiseIcon;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox loginImages;
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
    }
}

