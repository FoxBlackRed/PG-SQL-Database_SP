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
	public class Clients
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surename { get; set; }
        public string Phone { get; set; }
        public string Adress { get; set; }
        public bool Inst { get; set; }

        public Clients(int Id_, string Name_, string Surename_, string Phone_, string Adress_, bool Inst_)
        {
            this.Id = Id_;
            this.Name = Name_;
            this.Surename = Surename_;
            this.Phone = Phone_;
            this.Adress = Adress_;
            this.Inst = Inst_;
        }

        public void ClientGrid(DataGridView thisgrid)
        {
            Data d = new Data();

            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clients", d.GetConnection());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            thisgrid.DataSource = dt.DefaultView;
            thisgrid.AutoGenerateColumns = true;
            d.closeConnection();
        }
        public void ClientUpdate(DataGridView thisgrid, DataGridViewCellEventArgs e)
        {
            Data d = new Data();
            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Clients", d.GetConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetInsertCommand();
            builder.GetUpdateCommand();
            builder.GetDeleteCommand();
            DataSet set = new DataSet();
            adapter.Fill(set, "Clients");

            set.Tables["Clients"].Rows[e.RowIndex]["Id"] = thisgrid.Rows[e.RowIndex].Cells["Id"].Value;
            set.Tables["Clients"].Rows[e.RowIndex]["Surname"] = thisgrid.Rows[e.RowIndex].Cells["Surname"].Value;
            set.Tables["Clients"].Rows[e.RowIndex]["Phone"] = thisgrid.Rows[e.RowIndex].Cells["Phone"].Value;
            set.Tables["Clients"].Rows[e.RowIndex]["Adress"] = thisgrid.Rows[e.RowIndex].Cells["Adress"].Value;
            set.Tables["Clients"].Rows[e.RowIndex]["Inst"] = thisgrid.Rows[e.RowIndex].Cells["Inst"].Value;
            adapter.Update(set, "Clients");

            d.closeConnection();
        }
        public void ClientDel(DataGridView thisgrid, EventArgs e)
        {
            var temp = thisgrid.CurrentCell.RowIndex;
            thisgrid.Rows.RemoveAt(temp);
            thisgrid.Rows[temp].SetValues(0);
            Data d = new Data();
            d.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Clients WHERE Id = @row", d.GetConnection());
            command.Parameters.Add("@row", SqlDbType.Int).Value = temp + 1;
            command.ExecuteNonQuery();
            d.closeConnection();
        }
    }
}
