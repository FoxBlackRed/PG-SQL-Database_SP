
namespace SharpDesktopTraning
{
    partial class RegisterForm
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.closeRegBut = new System.Windows.Forms.Button();
            this.regSurnameBox = new System.Windows.Forms.TextBox();
            this.regLogInBox = new System.Windows.Forms.TextBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.regPassBox = new System.Windows.Forms.TextBox();
            this.regNameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SMbuttonReg = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(373, 0);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(373, 30);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(69, 26);
            this.logInToolStripMenuItem.Text = "LogIn";
            this.logInToolStripMenuItem.Click += new System.EventHandler(this.logInToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(373, 100);
            this.panel1.TabIndex = 11;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(67, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Registration";
            // 
            // closeRegBut
            // 
            this.closeRegBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeRegBut.BackColor = System.Drawing.Color.Coral;
            this.closeRegBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeRegBut.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.closeRegBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeRegBut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeRegBut.Location = new System.Drawing.Point(334, 0);
            this.closeRegBut.Name = "closeRegBut";
            this.closeRegBut.Size = new System.Drawing.Size(39, 39);
            this.closeRegBut.TabIndex = 13;
            this.closeRegBut.Text = "X";
            this.closeRegBut.UseVisualStyleBackColor = false;
            this.closeRegBut.Click += new System.EventHandler(this.closeRegBut_Click);
            // 
            // regSurnameBox
            // 
            this.regSurnameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regSurnameBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regSurnameBox.ForeColor = System.Drawing.Color.Gray;
            this.regSurnameBox.Location = new System.Drawing.Point(62, 51);
            this.regSurnameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regSurnameBox.Name = "regSurnameBox";
            this.regSurnameBox.Size = new System.Drawing.Size(242, 42);
            this.regSurnameBox.TabIndex = 9;
            this.regSurnameBox.Text = "Surname";
            this.regSurnameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regSurnameBox.Enter += new System.EventHandler(this.regSurnameBox_Enter);
            this.regSurnameBox.Leave += new System.EventHandler(this.regSurnameBox_Leave);
            // 
            // regLogInBox
            // 
            this.regLogInBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regLogInBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regLogInBox.ForeColor = System.Drawing.Color.Gray;
            this.regLogInBox.Location = new System.Drawing.Point(62, 127);
            this.regLogInBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regLogInBox.Name = "regLogInBox";
            this.regLogInBox.Size = new System.Drawing.Size(242, 42);
            this.regLogInBox.TabIndex = 1;
            this.regLogInBox.Text = "Username";
            this.regLogInBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regLogInBox.Enter += new System.EventHandler(this.regLogInBox_Enter);
            this.regLogInBox.Leave += new System.EventHandler(this.regLogInBox_Leave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(41, 247);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(288, 94);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Register";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // regPassBox
            // 
            this.regPassBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regPassBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regPassBox.ForeColor = System.Drawing.Color.Gray;
            this.regPassBox.Location = new System.Drawing.Point(62, 173);
            this.regPassBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regPassBox.Name = "regPassBox";
            this.regPassBox.Size = new System.Drawing.Size(242, 42);
            this.regPassBox.TabIndex = 1;
            this.regPassBox.Text = "Password";
            this.regPassBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regPassBox.Enter += new System.EventHandler(this.regPassBox_Enter);
            this.regPassBox.Leave += new System.EventHandler(this.regPassBox_Leave);
            // 
            // regNameBox
            // 
            this.regNameBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.regNameBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.regNameBox.ForeColor = System.Drawing.Color.Gray;
            this.regNameBox.Location = new System.Drawing.Point(62, 5);
            this.regNameBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.regNameBox.Name = "regNameBox";
            this.regNameBox.Size = new System.Drawing.Size(242, 42);
            this.regNameBox.TabIndex = 10;
            this.regNameBox.Text = "Name";
            this.regNameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.regNameBox.Enter += new System.EventHandler(this.regNameBox_Enter);
            this.regNameBox.Leave += new System.EventHandler(this.regNameBox_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.regNameBox);
            this.panel2.Controls.Add(this.regPassBox);
            this.panel2.Controls.Add(this.buttonRegister);
            this.panel2.Controls.Add(this.regLogInBox);
            this.panel2.Controls.Add(this.regSurnameBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 130);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(373, 365);
            this.panel2.TabIndex = 12;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // SMbuttonReg
            // 
            this.SMbuttonReg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMbuttonReg.BackColor = System.Drawing.Color.Coral;
            this.SMbuttonReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SMbuttonReg.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.SMbuttonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMbuttonReg.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMbuttonReg.Location = new System.Drawing.Point(290, 0);
            this.SMbuttonReg.Name = "SMbuttonReg";
            this.SMbuttonReg.Size = new System.Drawing.Size(39, 39);
            this.SMbuttonReg.TabIndex = 14;
            this.SMbuttonReg.Text = "-";
            this.SMbuttonReg.UseVisualStyleBackColor = false;
            this.SMbuttonReg.Click += new System.EventHandler(this.SMbuttonReg_Click);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 495);
            this.Controls.Add(this.SMbuttonReg);
            this.Controls.Add(this.closeRegBut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Регистрация";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button closeRegBut;
        private System.Windows.Forms.TextBox regSurnameBox;
        private System.Windows.Forms.TextBox regLogInBox;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox regPassBox;
        private System.Windows.Forms.TextBox regNameBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button SMbuttonReg;
    }
}