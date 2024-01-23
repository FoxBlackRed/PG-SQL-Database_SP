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
	public class Supplie
    {
        public int Id { get; set; }
        public string Name_Suplie { get; set; }
        public string Addres_Supplie { get; set; }
        public string Email_supl { get; set; }
        public string requiz { get; set; }
        public string Phone_Supl { get; set; }
        public string Face_supplie { get; set; }

        public Supplie(int Id_, string Name_Suplie_, string Addres_Supplie_, string Email_supl_, string requiz_, string Phone_Supl_, string Face_supplie_)
        {
            this.Id = Id_;
            this.Name_Suplie = Name_Suplie_;
            this.Addres_Supplie = Addres_Supplie_;
            this.Email_supl = Email_supl_;
            this.requiz = requiz_;
            this.Phone_Supl = Phone_Supl_;
            this.Face_supplie = Face_supplie_;
        }

        public void SupplieGrid(DataGridView thisgrid)
        {
            Data d = new Data();
            
            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Supplie", d.GetConnection());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            thisgrid.DataSource = dt.DefaultView;
            thisgrid.AutoGenerateColumns = true;
            d.closeConnection();
        }

        public void SupplieUpdate(DataGridView thisgrid, DataGridViewCellEventArgs e)
        {
            Data d = new Data();
            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Supplie", d.GetConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetInsertCommand();
            builder.GetUpdateCommand();
            builder.GetDeleteCommand();
            DataSet set = new DataSet();
            adapter.Fill(set, "Supplie");

            set.Tables["Supplie"].Rows[e.RowIndex]["Id"] = thisgrid.Rows[e.RowIndex].Cells["Id"].Value;
            set.Tables["Supplie"].Rows[e.RowIndex]["Name_Supplie"] = thisgrid.Rows[e.RowIndex].Cells["Name_Supplie"].Value;
            set.Tables["Supplie"].Rows[e.RowIndex]["Addres_Supplie"] = thisgrid.Rows[e.RowIndex].Cells["Addres_Supplie"].Value;
            set.Tables["Supplie"].Rows[e.RowIndex]["Email_supl"] = thisgrid.Rows[e.RowIndex].Cells["Email_supl"].Value;
            set.Tables["Supplie"].Rows[e.RowIndex]["requiz"] = thisgrid.Rows[e.RowIndex].Cells["requiz"].Value;
            set.Tables["Supplie"].Rows[e.RowIndex]["Phone_Supl"] = thisgrid.Rows[e.RowIndex].Cells["Phone_Supl"].Value;
            set.Tables["Supplie"].Rows[e.RowIndex]["Face_supplie"] = thisgrid.Rows[e.RowIndex].Cells["Face_supplie"].Value;
            adapter.Update(set, "Supplie");

            d.closeConnection();
        }

        public void SupplieDel(DataGridView thisgrid, EventArgs e)
        {
            var temp = thisgrid.CurrentCell.RowIndex;
            thisgrid.Rows.RemoveAt(temp);
            thisgrid.Rows[temp].SetValues(0);
            Data d = new Data();
            d.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Supplie WHERE Id = @row", d.GetConnection());
            command.Parameters.Add("@row", SqlDbType.Int).Value = temp + 1;
            command.ExecuteNonQuery();
            d.closeConnection();
        }
    }
}
