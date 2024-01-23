using System;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SharpDesktopTraning
{
    public partial class DatabaseObserver : Form
    {
        public DatabaseObserver()
        {
            InitializeComponent();
            
        }

        private int select = 0;
        private void closeDBBut_Click(object sender, EventArgs e)
        {
            DialogResult closedialog = MessageBox.Show("Do you really want to close?", "Close", MessageBoxButtons.YesNo);
            if (closedialog == DialogResult.Yes)
            {
                Application.Exit();
            }
            else if (closedialog == DialogResult.No) { }
        }

        private void MSbutton_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public bool BL { get; set; }

        public void dp()
        {
            if (BL == true)
            {
                adminPanelToolStripMenuItem.Visible = true;
            }
            else
            {
                adminPanelToolStripMenuItem.Visible = false;
            }
        }

        private void DatabaseObserver_Load(object sender, EventArgs e)
        {
            dp();
        }
        private bool flag = false;
        private void WindBut_Click(object sender, EventArgs e)
        {
            if (!flag)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
            flag = !flag;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }

        private void UsergridToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w = "UserGridBut";
            Users us = new Users(0, "","","","",false);
            dataGridView1.Columns.Clear();
            us.admUsGrid(dataGridView1);
        }

        private string w;
        Point lginpoint;
        private void menuStripDB_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lginpoint.X;
                this.Top += e.Y - lginpoint.Y;
            }
        }
        private void menuStripDB_MouseDown(object sender, MouseEventArgs e)
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

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            switch (w)
            {
                case "ClientsBut":
                {
                    Clients c = new Clients(0, "", "", "", "", false);
                    c.ClientUpdate(dataGridView1, e);
                    break;
                }
                case "ProductBut":
                {
                    Product p = new Product(0,"",0,0,0);
                    p.ProductGridUpdate(dataGridView1, e);
                    break;
                }
                case "UserGridBut":
                {
                    Users u = new Users(0, "", "", "", "", false);
                    u.admUsGridUpdate(dataGridView1, e);
                    break;
                }
                case "SuppliersBut":
                {
                    Supplie s = new Supplie(0, "", "", "", "", "", "");
                    s.SupplieUpdate(dataGridView1, e);
                    break;
                }
                case "SallersBut":
                {
                    Saller sel = new Saller(0, "", "", "", "");
                    sel.SallerUpdate(dataGridView1, e);
                    break;
                }
                default:
                    MessageBox.Show("Ошибка редактирования файла файла");
                    break;
            }
        }

        private void ClientsBut_Click(object sender, EventArgs e)
        {
            w = "ClientsBut";
            Clients cln = new Clients(0, "","","","",false);
            dataGridView1.Columns.Clear();
            cln.ClientGrid(dataGridView1);
        }

        private void DelEntBut_Click(object sender, EventArgs e)
        {
            switch (w)
            {
                case "ClientsBut":
                {
                    Clients c = new Clients(0,"","","","",false);
                    c.ClientDel(dataGridView1, e);
                    break;
                }
                    
                case "ProductBut":
                {
                    Product p = new Product(0,"",0,0,0);
                    p.ProductGridDel(dataGridView1, e);
                    break;
                }
                
                case "UserGridBut":
                {
                    Users u = new Users(0, "", "", "", "", false);
                    u.admUsGridDel(dataGridView1, e);
                    break;
                }
                case "SuppliersBut":
                {
                    Supplie s = new Supplie(0, "", "", "", "", "", "");
                    s.SupplieDel(dataGridView1, e);
                    break;
                }
                case "SallersBut":
                {
                    Saller sel = new Saller(0, "", "", "", "");
                    sel.SallerDel(dataGridView1, e);
                    break;
                }
                default:
                    MessageBox.Show("Ошибка удаления файла файла");
                    break;
            }
        }

        private void dataGridView1_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.StateChanged != DataGridViewElementStates.Selected) return;
            @select = e.Row.Index;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            @select = dataGridView1.CurrentCell.RowIndex;
        }

        private void ProductBut_Click(object sender, EventArgs e)
        {
            w = "ProductBut";
            Product p = new Product(0,"",0,0,0);
            dataGridView1.Columns.Clear();
            p.ProductGrid(dataGridView1);
        }

        private void suppliersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w = "SuppliersBut";
            Supplie s = new Supplie(0,"","","","","","");
            dataGridView1.Columns.Clear();
            s.SupplieGrid(dataGridView1);
        }

        private void sallersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            w = "SallersBut";
            Saller sel = new Saller(0,"","","","");
            dataGridView1.Columns.Clear();
            sel.SallerGrid(dataGridView1);
        }
    }
}
