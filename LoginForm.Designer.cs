
namespace SharpDesktopTraning
{
    partial class LoginForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Pass_TextBox = new System.Windows.Forms.TextBox();
            this.LogIn_TextBox = new System.Windows.Forms.TextBox();
            this.LogInBut = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registerTSM = new System.Windows.Forms.ToolStripMenuItem();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LogColPan1 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.closeLoginBut = new System.Windows.Forms.Button();
            this.SMbutton = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Pass_TextBox
            // 
            this.Pass_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Pass_TextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Pass_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.Pass_TextBox.Location = new System.Drawing.Point(35, 77);
            this.Pass_TextBox.Name = "Pass_TextBox";
            this.Pass_TextBox.Size = new System.Drawing.Size(226, 42);
            this.Pass_TextBox.TabIndex = 1;
            this.Pass_TextBox.Text = "Password";
            this.Pass_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Pass_TextBox.Enter += new System.EventHandler(this.Pass_TextBox_Enter);
            this.Pass_TextBox.Leave += new System.EventHandler(this.Pass_TextBox_Leave);
            // 
            // LogIn_TextBox
            // 
            this.LogIn_TextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogIn_TextBox.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogIn_TextBox.ForeColor = System.Drawing.Color.Gray;
            this.LogIn_TextBox.Location = new System.Drawing.Point(35, 15);
            this.LogIn_TextBox.Name = "LogIn_TextBox";
            this.LogIn_TextBox.Size = new System.Drawing.Size(226, 42);
            this.LogIn_TextBox.TabIndex = 1;
            this.LogIn_TextBox.Text = "Username";
            this.LogIn_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.LogIn_TextBox.Enter += new System.EventHandler(this.LogIn_TextBox_Enter);
            this.LogIn_TextBox.Leave += new System.EventHandler(this.LogIn_TextBox_Leave);
            // 
            // LogInBut
            // 
            this.LogInBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogInBut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(180)))), ((int)(((byte)(209)))));
            this.LogInBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogInBut.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(150)))), ((int)(((byte)(191)))));
            this.LogInBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogInBut.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LogInBut.Location = new System.Drawing.Point(35, 143);
            this.LogInBut.Name = "LogInBut";
            this.LogInBut.Size = new System.Drawing.Size(226, 92);
            this.LogInBut.TabIndex = 2;
            this.LogInBut.Text = "Login";
            this.LogInBut.UseVisualStyleBackColor = false;
            this.LogInBut.Click += new System.EventHandler(this.LogInBut_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Coral;
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registerTSM});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(294, 30);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseDown);
            this.menuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStrip1_MouseMove);
            // 
            // registerTSM
            // 
            this.registerTSM.Name = "registerTSM";
            this.registerTSM.Size = new System.Drawing.Size(90, 26);
            this.registerTSM.Text = "Register";
            this.registerTSM.Click += new System.EventHandler(this.registerTSM_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 30);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 0);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // LogColPan1
            // 
            this.LogColPan1.AutoSize = true;
            this.LogColPan1.Dock = System.Windows.Forms.DockStyle.Top;
            this.LogColPan1.Location = new System.Drawing.Point(0, 30);
            this.LogColPan1.Name = "LogColPan1";
            this.LogColPan1.Size = new System.Drawing.Size(294, 0);
            this.LogColPan1.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.AllowDrop = true;
            this.panel1.BackColor = System.Drawing.Color.Coral;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(294, 63);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(58, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(228, 43);
            this.label3.TabIndex = 0;
            this.label3.Text = "Authorization";
            // 
            // panel2
            // 
            this.panel2.AllowDrop = true;
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.LogInBut);
            this.panel2.Controls.Add(this.LogIn_TextBox);
            this.panel2.Controls.Add(this.Pass_TextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel2.Location = new System.Drawing.Point(0, 93);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(294, 247);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // closeLoginBut
            // 
            this.closeLoginBut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.closeLoginBut.BackColor = System.Drawing.Color.Coral;
            this.closeLoginBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeLoginBut.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.closeLoginBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeLoginBut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeLoginBut.Location = new System.Drawing.Point(262, 0);
            this.closeLoginBut.Name = "closeLoginBut";
            this.closeLoginBut.Size = new System.Drawing.Size(32, 30);
            this.closeLoginBut.TabIndex = 3;
            this.closeLoginBut.Text = "X";
            this.closeLoginBut.UseVisualStyleBackColor = false;
            this.closeLoginBut.Click += new System.EventHandler(this.closeBut_Click);
            // 
            // SMbutton
            // 
            this.SMbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SMbutton.BackColor = System.Drawing.Color.Coral;
            this.SMbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SMbutton.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.SMbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SMbutton.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SMbutton.Location = new System.Drawing.Point(229, 0);
            this.SMbutton.Name = "SMbutton";
            this.SMbutton.Size = new System.Drawing.Size(32, 30);
            this.SMbutton.TabIndex = 8;
            this.SMbutton.Text = "-";
            this.SMbutton.UseVisualStyleBackColor = false;
            this.SMbutton.Click += new System.EventHandler(this.SMbutton_Click);
            // 
            // LoginForm
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(294, 340);
            this.Controls.Add(this.SMbutton);
            this.Controls.Add(this.closeLoginBut);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.LogColPan1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.LoginForm_Load);
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
        private System.Windows.Forms.TextBox Pass_TextBox;
        private System.Windows.Forms.TextBox LogIn_TextBox;
        private System.Windows.Forms.Button LogInBut;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ToolStripMenuItem registerTSM;
        private System.Windows.Forms.Panel LogColPan1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeLoginBut;
        private System.Windows.Forms.Button SMbutton;
    }
}

