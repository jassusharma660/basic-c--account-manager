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
    public partial class Register : Form
    {
        private bool dragging = false;
        private Point startPoint = new Point(0, 0);
   
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
        public Register()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            this.ActiveControl = awesomeNoteLabel;
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
        private void Register_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            startPoint = new Point(e.X, e.Y);
        }

        private void Register_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void Register_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point p = PointToScreen(e.Location);
                Location = new Point(p.X - this.startPoint.X, p.Y - this.startPoint.Y);
            }
        }

        private void loginButton_MouseEnter(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.Black;
            loginButtonLabel.ForeColor = Color.White;
        }

        private void loginButton_MouseLeave(object sender, EventArgs e)
        {
            loginButton.BackColor = Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(252)))));
            loginButtonLabel.ForeColor = Color.Black;
        }

        private void loginButtonLabel_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.AppStarting;
            Login l = new Login();
            this.Hide();
            l.Show();
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

        private void container_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Black,
            e.ClipRectangle.Left,
            e.ClipRectangle.Top,
            e.ClipRectangle.Width - 1,
            e.ClipRectangle.Height - 1);
            base.OnPaint(e);
        }

        private void registerFinal_Click(object sender, EventArgs e)
        {
            isFormDataValid();
            //select convert(varchar, getdate(), 106)
        }

        private bool isFormDataValid()
        {
            if (string.IsNullOrEmpty(uidTextBox.Text))
            {
                errorTextBox.Text = "User id can't be empty!";
                uidTextBox.Focus();
                return false;
            }
            else
            {
                if (!Regex.Match(uidTextBox.Text, @"^[a-zA-Z]+(?!\d+$)\w{7,20}$").Success)
                {
                    errorTextBox.Text = "Invalid User id!"+ Environment.NewLine + "(Allowed only 8-20 characters alphanumerics)";
                    uidTextBox.Focus();
                    return false;
                }
            }

            if (string.IsNullOrEmpty(emailTextbox.Text))
            {
                errorTextBox.Text = "Email id can't be empty!";
                emailTextbox.Focus();
                return false;
            }
            else
            {
                if (!Regex.Match(emailTextbox.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,6})+)$").Success)
                {
                    errorTextBox.Text = "Email not valid!)";
                    emailTextbox.Focus();
                    return false;
                }
            }
            if (string.IsNullOrEmpty(passwordTextBox.Text) || string.IsNullOrEmpty(repeatPasswordTextBox.Text))
            {
                errorTextBox.Text = "Password or Repeat Password can't be empty!";
                if (passwordTextBox.Text == "") passwordTextBox.Focus(); else repeatPasswordTextBox.Focus();
                return false;
            }
            if (!string.Equals(passwordTextBox.Text, repeatPasswordTextBox.Text))
            {
                errorTextBox.Text = "Password and Repeat Password must be same.";
                return false;
            }
            else
            {
                if (!Regex.Match(passwordTextBox.Text, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\da-zA-Z]).{8,30}$").Success)
                {
                    errorTextBox.Text = "Password not valid!"+ Environment.NewLine + "(8-30 chars with atleast 1 uppercase, lowercase, number and special char)";
                    passwordTextBox.Focus();
                    return false;
                }
            }
            if(!maleRadioButton.Checked && !femaleRadioButton.Checked && !nonBinaryRadioButton.Checked)
            {
                errorTextBox.Text = "Select a gender!";
                return false;
            }
            if(!acceptTerms.Checked)
            {
                errorTextBox.Text = "Please accept terms and conditions to continue.";
                return false;
            }
            errorTextBox.Text = "";
            return true;
        }
    }
}
