namespace c_sharp_account_manager
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.minimiseIcon = new System.Windows.Forms.PictureBox();
            this.closeIcon = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.loginButton = new System.Windows.Forms.Panel();
            this.loginButtonLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.regImage = new System.Windows.Forms.PictureBox();
            this.copyrightLabel = new System.Windows.Forms.Label();
            this.appNameLabel = new System.Windows.Forms.Label();
            this.logoImage = new System.Windows.Forms.PictureBox();
            this.welcomeNoteLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.minimiseIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).BeginInit();
            this.panel1.SuspendLayout();
            this.loginButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // minimiseIcon
            // 
            this.minimiseIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimiseIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.minimiseIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minimiseIcon.Image = ((System.Drawing.Image)(resources.GetObject("minimiseIcon.Image")));
            this.minimiseIcon.Location = new System.Drawing.Point(806, 15);
            this.minimiseIcon.Name = "minimiseIcon";
            this.minimiseIcon.Size = new System.Drawing.Size(22, 22);
            this.minimiseIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minimiseIcon.TabIndex = 4;
            this.minimiseIcon.TabStop = false;
            this.minimiseIcon.Click += new System.EventHandler(this.minimiseIcon_Click);
            // 
            // closeIcon
            // 
            this.closeIcon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.closeIcon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeIcon.Image = ((System.Drawing.Image)(resources.GetObject("closeIcon.Image")));
            this.closeIcon.Location = new System.Drawing.Point(832, 15);
            this.closeIcon.Name = "closeIcon";
            this.closeIcon.Size = new System.Drawing.Size(22, 22);
            this.closeIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closeIcon.TabIndex = 3;
            this.closeIcon.TabStop = false;
            this.closeIcon.Click += new System.EventHandler(this.closeIcon_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.loginButton);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.regImage);
            this.panel1.Controls.Add(this.copyrightLabel);
            this.panel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(483, -3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 608);
            this.panel1.TabIndex = 5;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Register_MouseUp);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(34, 120);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(274, 42);
            this.textBox1.TabIndex = 17;
            this.textBox1.TabStop = false;
            this.textBox1.Text = "You are a step away from becoming a TestApp member.";
            // 
            // loginButton
            // 
            this.loginButton.Controls.Add(this.loginButtonLabel);
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Location = new System.Drawing.Point(192, 192);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(64, 25);
            this.loginButton.TabIndex = 16;
            this.loginButton.Click += new System.EventHandler(this.loginButtonLabel_Click);
            this.loginButton.Paint += new System.Windows.Forms.PaintEventHandler(this.loginButton_Paint);
            this.loginButton.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButton.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // loginButtonLabel
            // 
            this.loginButtonLabel.AutoSize = true;
            this.loginButtonLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButtonLabel.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButtonLabel.Location = new System.Drawing.Point(14, 6);
            this.loginButtonLabel.Name = "loginButtonLabel";
            this.loginButtonLabel.Size = new System.Drawing.Size(39, 13);
            this.loginButtonLabel.TabIndex = 0;
            this.loginButtonLabel.Text = "Log in";
            this.loginButtonLabel.Click += new System.EventHandler(this.loginButtonLabel_Click);
            this.loginButtonLabel.MouseEnter += new System.EventHandler(this.loginButton_MouseEnter);
            this.loginButtonLabel.MouseLeave += new System.EventHandler(this.loginButton_MouseLeave);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 21);
            this.label1.TabIndex = 15;
            this.label1.Text = "Aready a member?";
            // 
            // regImage
            // 
            this.regImage.Image = ((System.Drawing.Image)(resources.GetObject("regImage.Image")));
            this.regImage.Location = new System.Drawing.Point(34, 251);
            this.regImage.Name = "regImage";
            this.regImage.Size = new System.Drawing.Size(300, 300);
            this.regImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.regImage.TabIndex = 14;
            this.regImage.TabStop = false;
            // 
            // copyrightLabel
            // 
            this.copyrightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.copyrightLabel.AutoSize = true;
            this.copyrightLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyrightLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyrightLabel.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.copyrightLabel.Location = new System.Drawing.Point(290, 581);
            this.copyrightLabel.Name = "copyrightLabel";
            this.copyrightLabel.Size = new System.Drawing.Size(87, 13);
            this.copyrightLabel.TabIndex = 13;
            this.copyrightLabel.Text = "© Jassu Sharma";
            this.copyrightLabel.Click += new System.EventHandler(this.copyrightLabel_Click);
            // 
            // appNameLabel
            // 
            this.appNameLabel.AutoSize = true;
            this.appNameLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.appNameLabel.Location = new System.Drawing.Point(59, 18);
            this.appNameLabel.Name = "appNameLabel";
            this.appNameLabel.Size = new System.Drawing.Size(83, 25);
            this.appNameLabel.TabIndex = 7;
            this.appNameLabel.Text = "TestApp";
            // 
            // logoImage
            // 
            this.logoImage.Image = ((System.Drawing.Image)(resources.GetObject("logoImage.Image")));
            this.logoImage.Location = new System.Drawing.Point(22, 15);
            this.logoImage.Name = "logoImage";
            this.logoImage.Size = new System.Drawing.Size(35, 35);
            this.logoImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoImage.TabIndex = 6;
            this.logoImage.TabStop = false;
            // 
            // welcomeNoteLabel
            // 
            this.welcomeNoteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.welcomeNoteLabel.AutoSize = true;
            this.welcomeNoteLabel.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeNoteLabel.Location = new System.Drawing.Point(120, 122);
            this.welcomeNoteLabel.Name = "welcomeNoteLabel";
            this.welcomeNoteLabel.Size = new System.Drawing.Size(220, 37);
            this.welcomeNoteLabel.TabIndex = 8;
            this.welcomeNoteLabel.Text = "Welcome Back!";
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(872, 600);
            this.Controls.Add(this.welcomeNoteLabel);
            this.Controls.Add(this.appNameLabel);
            this.Controls.Add(this.logoImage);
            this.Controls.Add(this.minimiseIcon);
            this.Controls.Add(this.closeIcon);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Register_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Register_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Register_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.minimiseIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeIcon)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.loginButton.ResumeLayout(false);
            this.loginButton.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.regImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox minimiseIcon;
        private System.Windows.Forms.PictureBox closeIcon;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label copyrightLabel;
        private System.Windows.Forms.PictureBox regImage;
        private System.Windows.Forms.Label appNameLabel;
        private System.Windows.Forms.PictureBox logoImage;
        private System.Windows.Forms.Panel loginButton;
        private System.Windows.Forms.Label loginButtonLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label welcomeNoteLabel;
    }
}