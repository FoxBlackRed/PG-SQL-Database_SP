
namespace SharpDesktopTraning
{
    partial class DatabaseObserver
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
            this.closeDBBut = new System.Windows.Forms.Button();
            this.menuStripDB = new System.Windows.Forms.MenuStrip();
            this.userToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UsergridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suppliersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sallersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MSbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ItemonsaleBut = new System.Windows.Forms.Button();
            this.ProductBut = new System.Windows.Forms.Button();
            this.DelEntBut = new System.Windows.Forms.Button();
            this.ClientsBut = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.WindBut = new System.Windows.Forms.Button();
            this.menuStripDB.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // closeDBBut
            // 
            this.closeDBBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeDBBut.BackColor = System.Drawing.Color.Coral;
            this.closeDBBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeDBBut.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.closeDBBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeDBBut.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeDBBut.Location = new System.Drawing.Point(1286, -1);
            this.closeDBBut.Name = "closeDBBut";
            this.closeDBBut.Size = new System.Drawing.Size(32, 36);
            this.closeDBBut.TabIndex = 14;
            this.closeDBBut.Text = "X";
            this.closeDBBut.UseVisualStyleBackColor = false;
            this.closeDBBut.Click += new System.EventHandler(this.closeDBBut_Click);
            // 
            // menuStripDB
            // 
            this.menuStripDB.BackColor = System.Drawing.Color.Coral;
            this.menuStripDB.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStripDB.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripDB.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userToolStripMenuItem,
            this.adminPanelToolStripMenuItem});
            this.menuStripDB.Location = new System.Drawing.Point(0, 0);
            this.menuStripDB.Name = "menuStripDB";
            this.menuStripDB.Size = new System.Drawing.Size(1318, 35);
            this.menuStripDB.TabIndex = 15;
            this.menuStripDB.Text = "menuStrip1";
            this.menuStripDB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.menuStripDB_MouseDown);
            this.menuStripDB.MouseMove += new System.Windows.Forms.MouseEventHandler(this.menuStripDB_MouseMove);
            // 
            // userToolStripMenuItem
            // 
            this.userToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.userToolStripMenuItem.Name = "userToolStripMenuItem";
            this.userToolStripMenuItem.Size = new System.Drawing.Size(70, 31);
            this.userToolStripMenuItem.Text = "User";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(167, 32);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // adminPanelToolStripMenuItem
            // 
            this.adminPanelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UsergridToolStripMenuItem,
            this.suppliersToolStripMenuItem,
            this.sallersToolStripMenuItem});
            this.adminPanelToolStripMenuItem.Name = "adminPanelToolStripMenuItem";
            this.adminPanelToolStripMenuItem.Size = new System.Drawing.Size(145, 31);
            this.adminPanelToolStripMenuItem.Text = "AdminPanel";
            this.adminPanelToolStripMenuItem.Visible = false;
            // 
            // UsergridToolStripMenuItem
            // 
            this.UsergridToolStripMenuItem.Name = "UsergridToolStripMenuItem";
            this.UsergridToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.UsergridToolStripMenuItem.Text = "Users Grid";
            this.UsergridToolStripMenuItem.Click += new System.EventHandler(this.UsergridToolStripMenuItem_Click);
            // 
            // suppliersToolStripMenuItem
            // 
            this.suppliersToolStripMenuItem.Name = "suppliersToolStripMenuItem";
            this.suppliersToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.suppliersToolStripMenuItem.Text = "Suppliers";
            this.suppliersToolStripMenuItem.Click += new System.EventHandler(this.suppliersToolStripMenuItem_Click);
            // 
            // sallersToolStripMenuItem
            // 
            this.sallersToolStripMenuItem.Name = "sallersToolStripMenuItem";
            this.sallersToolStripMenuItem.Size = new System.Drawing.Size(200, 32);
            this.sallersToolStripMenuItem.Text = "Sallers";
            this.sallersToolStripMenuItem.Click += new System.EventHandler(this.sallersToolStripMenuItem_Click);
            // 
            // MSbutton
            // 
            this.MSbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MSbutton.BackColor = System.Drawing.Color.Coral;
            this.MSbutton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MSbutton.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.MSbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MSbutton.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MSbutton.Location = new System.Drawing.Point(1217, 0);
            this.MSbutton.Name = "MSbutton";
            this.MSbutton.Size = new System.Drawing.Size(34, 35);
            this.MSbutton.TabIndex = 16;
            this.MSbutton.Text = "-";
            this.MSbutton.UseVisualStyleBackColor = false;
            this.MSbutton.Click += new System.EventHandler(this.MSbutton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.ItemonsaleBut);
            this.panel1.Controls.Add(this.ProductBut);
            this.panel1.Controls.Add(this.DelEntBut);
            this.panel1.Controls.Add(this.ClientsBut);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 35);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1318, 531);
            this.panel1.TabIndex = 17;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // ItemonsaleBut
            // 
            this.ItemonsaleBut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ItemonsaleBut.Location = new System.Drawing.Point(337, 14);
            this.ItemonsaleBut.Name = "ItemonsaleBut";
            this.ItemonsaleBut.Size = new System.Drawing.Size(156, 52);
            this.ItemonsaleBut.TabIndex = 1;
            this.ItemonsaleBut.Text = "Items on sale";
            this.ItemonsaleBut.UseVisualStyleBackColor = true;
            // 
            // ProductBut
            // 
            this.ProductBut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ProductBut.Location = new System.Drawing.Point(175, 14);
            this.ProductBut.Name = "ProductBut";
            this.ProductBut.Size = new System.Drawing.Size(156, 52);
            this.ProductBut.TabIndex = 1;
            this.ProductBut.Text = "Prodcut";
            this.ProductBut.UseVisualStyleBackColor = true;
            this.ProductBut.Click += new System.EventHandler(this.ProductBut_Click);
            // 
            // DelEntBut
            // 
            this.DelEntBut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DelEntBut.Location = new System.Drawing.Point(1134, 14);
            this.DelEntBut.Name = "DelEntBut";
            this.DelEntBut.Size = new System.Drawing.Size(156, 52);
            this.DelEntBut.TabIndex = 1;
            this.DelEntBut.Text = "Delete Entry";
            this.DelEntBut.UseVisualStyleBackColor = true;
            this.DelEntBut.Click += new System.EventHandler(this.DelEntBut_Click);
            // 
            // ClientsBut
            // 
            this.ClientsBut.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientsBut.Location = new System.Drawing.Point(12, 14);
            this.ClientsBut.Name = "ClientsBut";
            this.ClientsBut.Size = new System.Drawing.Size(157, 52);
            this.ClientsBut.TabIndex = 1;
            this.ClientsBut.Text = "Clients";
            this.ClientsBut.UseVisualStyleBackColor = true;
            this.ClientsBut.Click += new System.EventHandler(this.ClientsBut_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 85);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 398);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dataGridView1_RowStateChanged);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // WindBut
            // 
            this.WindBut.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.WindBut.BackColor = System.Drawing.Color.Coral;
            this.WindBut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WindBut.FlatAppearance.BorderColor = System.Drawing.Color.Coral;
            this.WindBut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WindBut.Font = new System.Drawing.Font("Trebuchet MS", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindBut.Location = new System.Drawing.Point(1257, -1);
            this.WindBut.Name = "WindBut";
            this.WindBut.Size = new System.Drawing.Size(33, 35);
            this.WindBut.TabIndex = 16;
            this.WindBut.Text = "□";
            this.WindBut.UseVisualStyleBackColor = false;
            this.WindBut.Click += new System.EventHandler(this.WindBut_Click);
            // 
            // DatabaseObserver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1318, 566);
            this.Controls.Add(this.closeDBBut);
            this.Controls.Add(this.WindBut);
            this.Controls.Add(this.MSbutton);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStripDB);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStripDB;
            this.Name = "DatabaseObserver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DatabaseObserver";
            this.Load += new System.EventHandler(this.DatabaseObserver_Load);
            this.menuStripDB.ResumeLayout(false);
            this.menuStripDB.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button closeDBBut;
        private System.Windows.Forms.MenuStrip menuStripDB;
        private System.Windows.Forms.ToolStripMenuItem userToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Button MSbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button ItemonsaleBut;
        private System.Windows.Forms.Button ProductBut;
        private System.Windows.Forms.Button DelEntBut;
        private System.Windows.Forms.Button ClientsBut;
        private System.Windows.Forms.ToolStripMenuItem UsergridToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminPanelToolStripMenuItem;
        private System.Windows.Forms.Button WindBut;
        private System.Windows.Forms.ToolStripMenuItem suppliersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sallersToolStripMenuItem;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}