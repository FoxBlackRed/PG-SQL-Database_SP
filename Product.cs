using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SharpDesktopTraning
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int id_supplie { get; set; }

        public Product(int Id_, string Name_, decimal Price_, int Count_, int id_supplie_)
        {
            this.Id = Id_;
            this.Name = Name_;
            this.Price = Price_;
            this.Count = Count_;
            this.id_supplie = id_supplie_;
        }

        public void ProductGrid(DataGridView thisgrid)
        {
            Data d = new Data();

            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", d.GetConnection());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            thisgrid.DataSource = dt.DefaultView;
            thisgrid.AutoGenerateColumns = true;
            d.closeConnection();
        }
        public void ProductGridUpdate(DataGridView thisgrid, DataGridViewCellEventArgs e)
        {
            Data d = new Data();
            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Product", d.GetConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetInsertCommand();
            builder.GetUpdateCommand();
            builder.GetDeleteCommand();
            DataSet set = new DataSet();
            adapter.Fill(set, "Product");

            set.Tables["Product"].Rows[e.RowIndex]["Id"] = thisgrid.Rows[e.RowIndex].Cells["Id"].Value;
            set.Tables["Product"].Rows[e.RowIndex]["Name"] = thisgrid.Rows[e.RowIndex].Cells["Name"].Value;
            set.Tables["Product"].Rows[e.RowIndex]["Price"] = thisgrid.Rows[e.RowIndex].Cells["Price"].Value;
            set.Tables["Product"].Rows[e.RowIndex]["Count"] = thisgrid.Rows[e.RowIndex].Cells["Count"].Value;
            set.Tables["Product"].Rows[e.RowIndex]["id_supplie"] = thisgrid.Rows[e.RowIndex].Cells["id_supplie"].Value;
            adapter.Update(set, "Product");

            d.closeConnection();
        }
        public void ProductGridDel(DataGridView thisgrid, EventArgs e)
        {
            var temp = thisgrid.CurrentCell.RowIndex;
            thisgrid.Rows.RemoveAt(temp);
            thisgrid.Rows[temp].SetValues(0);
            Data d = new Data();
            d.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Product WHERE Id = @row", d.GetConnection());
            command.Parameters.Add("@row", SqlDbType.Int).Value = temp + 1;
            command.ExecuteNonQuery();
            d.closeConnection();
        }
    }
}
