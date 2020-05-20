using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace c_sharp_account_manager
{
    public partial class Login : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0,0);
        
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        public Login()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.ActiveControl = welcomeNoteLabel;
        }
        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        private void minimiseIcon_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void closeIcon_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {
            if(dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X-this.startPoint.X, p.Y-this.startPoint.Y);
            }
        }

        private void uidTextBox_Enter(object sender, EventArgs e)
        {
            if (uidTextBox.Text== "Enter user ID")
                uidTextBox.Text = "";

            uidTextBox.ForeColor = Color.Black;
        }

        private void uidTextBox_Leave(object sender, EventArgs e)
        {
            if (uidTextBox.Text == "")
                uidTextBox.Text = "Enter user ID";

            uidTextBox.ForeColor = Color.Gray;
        }

        private void container_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void passwordTextBox_Enter(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "Enter password")
                passwordTextBox.Text = "";

            passwordTextBox.ForeColor = Color.Black;

        }

        private void passwordTextBox_Leave(object sender, EventArgs e)
        {
            if (passwordTextBox.Text == "")
                passwordTextBox.Text = "Enter password";

            passwordTextBox.ForeColor = Color.Gray;

        }
        private void signUpButton_MouseEnter(object sender, EventArgs e)
        {
            signUpButtonLabel.ForeColor = Color.White;
            signUpButton.BackColor = Color.Black;
        }

        private void signUpButton_MouseLeave(object sender, EventArgs e)
        {
            signUpButtonLabel.ForeColor = Color.Black;
            signUpButton.BackColor = Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(236)))), ((int)(((byte)(255)))));
        }

        private void loginButtonPanel_MouseEnter(object sender, EventArgs e)
        {
            loginButtonPanel.BackColor = Color.FromArgb(((int)(((byte)(84)))), ((int)(((byte)(86)))), ((int)(((byte)(254)))));
        }

        private void loginButtonPanel_MouseLeave(object sender, EventArgs e)
        {
            loginButtonPanel.BackColor = Color.Black;
        }

        private void signUpButtonLabel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            Register reg = new Register();
            this.Hide();
            reg.Show();
        }
        private void copyrightLabel_Click(object sender, EventArgs e)
        {
            this.Opacity -= .1;
            this.Cursor = Cursors.AppStarting;
            About a = new About();
            a.ShowDialog();
            if (a.IsDisposed)
            {
                this.Cursor = Cursors.Default;
                this.Opacity += .1;
            }
        }
        private void loginFinal_Click(object sender, EventArgs e)
        {
            isFormDataValid();
        }

        private bool isFormDataValid()
        {
            if (string.IsNullOrEmpty(uidTextBox.Text) || uidTextBox.Text == "Enter user ID")
            {
                errorTextBox.Text = "User id can't be empty!";
                uidTextBox.Focus();
                return false;
            }
            else
            {
                if (!Regex.Match(uidTextBox.Text, @"^[a-zA-Z]+(?!\d+$)\w{7,20}$").Success)
                {
                    errorTextBox.Text = "Invalid User id!" + Environment.NewLine + "(Allowed only 8-20 characters alphanumerics)";
                    uidTextBox.Focus();
                    return false;
                }
            }
            
            if (string.IsNullOrEmpty(passwordTextBox.Text) || passwordTextBox.Text == "Enter password")
            {
                errorTextBox.Text = "Password can't be empty!";
                passwordTextBox.Focus();
                return false;
            }
            else
            {
                if (!Regex.Match(passwordTextBox.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$").Success)
                {
                    errorTextBox.Text = "Password not valid!" + Environment.NewLine + "(8-30 chars with atleast 1 uppercase, lowercase, number and special char)";
                    passwordTextBox.Focus();
                    return false;
                }
            }
            
            errorTextBox.Text = "";
            return true;
        }
        
    }
}
