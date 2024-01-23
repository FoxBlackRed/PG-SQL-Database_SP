using System;
using System.Data;
using System.Windows.Forms;
using System.Drawing;
using System.Data.SqlClient;

namespace SharpDesktopTraning
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void LogInBut_Click(object sender, EventArgs e)
        {
            Users U = new Users(0, String.Empty, String.Empty, LogIn_TextBox.Text, Pass_TextBox.Text, false);
            U.loginLoad();
            this.Hide();
        }

        private void registerTSM_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterForm registerform = new RegisterForm();
            registerform.Show();
        }
        private void closeBut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LogIn_TextBox_Enter(object sender, EventArgs e)
        {
            LogIn_TextBox.Text = String.Empty;
            LogIn_TextBox.ForeColor = Color.Black;
        }
        private void LogIn_TextBox_Leave(object sender, EventArgs e)
        {
            if (LogIn_TextBox.Text == String.Empty)
            {
                LogIn_TextBox.Text = "Username";
                LogIn_TextBox.ForeColor = Color.Gray;
            }
        }
        private void Pass_TextBox_Enter(object sender, EventArgs e)
        {
            Pass_TextBox.UseSystemPasswordChar = true;
            Pass_TextBox.Text = String.Empty;
            Pass_TextBox.ForeColor = Color.Black;
        }
        private void Pass_TextBox_Leave(object sender, EventArgs e)
        {
            if (Pass_TextBox.Text == String.Empty)
            {
                Pass_TextBox.Text = "Password";
                Pass_TextBox.ForeColor = Color.Gray;
                Pass_TextBox.UseSystemPasswordChar = false;
            }
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
        private void SMbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
