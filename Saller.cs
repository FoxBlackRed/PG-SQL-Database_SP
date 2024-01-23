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
	public class Saller
    {
        public int Id { get; set; }
        public string Second_Name { get; set; }
        public string Name { get; set; }
        public string Adress_Saller { get; set; }
        public string Phone_Saller { get; set; }

        public Saller(int Id_, string Second_Name_, string Name_, string Adress_Saller_, string Phone_Saller_)
        {
            this.Id = Id_;
            this.Second_Name = Second_Name_;
            this.Name = Name_;
            this.Adress_Saller = Adress_Saller_;
            this.Phone_Saller = Phone_Saller_;
        }

        public void SallerGrid(DataGridView thisgrid)
        {
            Data d = new Data();

            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Saller", d.GetConnection());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            thisgrid.DataSource = dt.DefaultView;
            thisgrid.AutoGenerateColumns = true;
            d.closeConnection();
        }

        public void SallerUpdate(DataGridView thisgrid, DataGridViewCellEventArgs e)
        {
            Data d = new Data();
            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Saller", d.GetConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetInsertCommand();
            builder.GetUpdateCommand();
            builder.GetDeleteCommand();
            DataSet set = new DataSet();
            adapter.Fill(set, "Saller");

            set.Tables["Saller"].Rows[e.RowIndex]["Id"] = thisgrid.Rows[e.RowIndex].Cells["Id"].Value;
            set.Tables["Saller"].Rows[e.RowIndex]["Second_Name"] = thisgrid.Rows[e.RowIndex].Cells["Second_Name"].Value;
            set.Tables["Saller"].Rows[e.RowIndex]["Name"] = thisgrid.Rows[e.RowIndex].Cells["Name"].Value;
            set.Tables["Saller"].Rows[e.RowIndex]["Adress_Saller"] = thisgrid.Rows[e.RowIndex].Cells["Adress_Saller"].Value;
            set.Tables["Saller"].Rows[e.RowIndex]["Phone_Saller"] = thisgrid.Rows[e.RowIndex].Cells["Phone_Saller"].Value;
            adapter.Update(set, "Saller");

            d.closeConnection();
        }

        public void SallerDel(DataGridView thisgrid, EventArgs e)
        {
            var temp = thisgrid.CurrentCell.RowIndex;
            thisgrid.Rows.RemoveAt(temp);
            thisgrid.Rows[temp].SetValues(0);
            Data d = new Data();
            d.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Saller WHERE Id = @row", d.GetConnection());
            command.Parameters.Add("@row", SqlDbType.Int).Value = temp + 1;
            command.ExecuteNonQuery();
            d.closeConnection();
        }
    }
}
