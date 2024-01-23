using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace SharpDesktopTraning
{
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            if (regNameBox.Text == "Name")
            {
                MessageBox.Show("Enter Name");
                return;
            }

            if (regSurnameBox.Text == "Surname")
            {
                MessageBox.Show("Enter Surname");
                return;
            }

            if (regLogInBox.Text == "Username")
            {
                MessageBox.Show("Enter Username");
                return;
            }

            if (regPassBox.Text == "Password")
            {
                MessageBox.Show("Enter Password");
                return;
            }
            
            Users U = new Users(0, regNameBox.Text, regSurnameBox.Text, regLogInBox.Text, regPassBox.Text, false);
            U.registerLoad();
            this.Close();
        }

        private void closeRegBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = new LoginForm();
            loginform.Show();
        }

        private void regNameBox_Enter(object sender, EventArgs e)
        {
            regNameBox.Text = String.Empty;
            regNameBox.ForeColor = Color.Black;
        }
        private void regNameBox_Leave(object sender, EventArgs e)
        {
            if (regNameBox.Text == String.Empty)
            {
                regNameBox.Text = "Name";
                regNameBox.ForeColor = Color.Gray;
            }
        }
        private void regSurnameBox_Enter(object sender, EventArgs e)
        {
            regSurnameBox.Text = String.Empty;
            regSurnameBox.ForeColor = Color.Black;
        }
        private void regSurnameBox_Leave(object sender, EventArgs e)
        {
            if (regSurnameBox.Text == String.Empty)
            {
                regSurnameBox.Text = "Surname";
                regSurnameBox.ForeColor = Color.Gray;
            }
        }
        private void regLogInBox_Enter(object sender, EventArgs e)
        {
            regLogInBox.Text = String.Empty;
            regLogInBox.ForeColor = Color.Black;
        }
        private void regLogInBox_Leave(object sender, EventArgs e)
        {
            if (regLogInBox.Text == String.Empty)
            {
                regLogInBox.Text = "Username";
                regLogInBox.ForeColor = Color.Gray;
            }
        }
        private void regPassBox_Enter(object sender, EventArgs e)
        {
            regPassBox.UseSystemPasswordChar = true;
            regPassBox.Text = String.Empty;
            regPassBox.ForeColor = Color.Black;
        }
        private void regPassBox_Leave(object sender, EventArgs e)
        {
            if (regPassBox.Text == String.Empty)
            {
                regPassBox.Text = "Password";
                regPassBox.ForeColor = Color.Gray;
                regPassBox.UseSystemPasswordChar = false;
            }
        }
        private void SMbuttonReg_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        Point lginpoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lginpoint.X;
                this.Top += e.Y - lginpoint.Y;
            }
        }
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            lginpoint = new Point(e.X, e.Y);
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lginpoint.X;
                this.Top += e.Y - lginpoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lginpoint = new Point(e.X, e.Y);
        }
        private void menuStrip1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lginpoint.X;
                this.Top += e.Y - lginpoint.Y;
            }
        }
        private void menuStrip1_MouseDown(object sender, MouseEventArgs e)
        {
            lginpoint = new Point(e.X, e.Y);
        }
    }
}
