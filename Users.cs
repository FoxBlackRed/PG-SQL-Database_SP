using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Xml.Schema;

namespace SharpDesktopTraning
{
	public class Users
	{
		public int Id { get; set; }
		public string Name { private get ; set; }
		public string Surname { private get; set; }
		public string Username { private get; set; }
		public string Password { private get; set; }
		public bool Promote { get; set; }

		public Users(int Id_, string Name_, string Surname_, string Username_, string Password_, bool Promote_)
		{
			this.Id = Id_;
			this.Name = Name_;
			this.Surname = Surname_;
			this.Username = Username_;
			this.Password = Password_;
			this.Promote = Promote_;
		}
		public void registerLoad() 
		{
            if (userExists())
            {
                return;
            }

            Data DB = new Data();

            SqlCommand command = new SqlCommand("INSERT INTO [Users] (Name, Surname, Username, Password, Promote) VALUES (@Name, @Surname, @LogInReg, @PassReg, 0)", DB.GetConnection());

            command.Parameters.Add("@Name", SqlDbType.VarChar).Value = Name;
            command.Parameters.Add("@Surname", SqlDbType.VarChar).Value = Surname;
            command.Parameters.Add("@LogInReg", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@PassReg", SqlDbType.VarChar).Value = Password;

            DB.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                if (MessageBox.Show("Регистрацияя успешна") == DialogResult.OK)
                {
                    LoginForm loginform = new LoginForm();
                    loginform.Show();
                }
            }
            else
            {
                MessageBox.Show("Ошибка регистрации");
            }

            DB.closeConnection();
		}
        private Boolean userExists()
        {
            Data D = new Data();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE Username = @uLogIn", D.GetConnection());
            command.Parameters.Add("@uLogIn", SqlDbType.VarChar).Value = Username;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Такой логин уже используется");
                return true;
            }
            else
            {
                return false;
            }
        }

        public void loginLoad()
        {
            Data D = new Data();
            DataTable dt = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand("SELECT * FROM [Users] WHERE Username = @uLogIn AND Password= @uPass", D.GetConnection());
            command.Parameters.Add("@uLogIn", SqlDbType.VarChar).Value = Username;
            command.Parameters.Add("@uPass", SqlDbType.VarChar).Value = Password;

            adapter.SelectCommand = command;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                foreach (DataRow tesr in dt.Rows)
                {
                    if (tesr.ItemArray[5].ToString() == "True")
                    {
                        LoginForm lg = new LoginForm();
                        lg.Hide();
                        DatabaseObserver dbo = new DatabaseObserver();
                        dbo.BL = true;
                        dbo.Show();
                    }
                    else
                    {
                        LoginForm lg = new LoginForm();
                        lg.Hide();
                        DatabaseObserver dbo = new DatabaseObserver();
                        dbo.BL = false;
                        dbo.Show();
                    }
                }
            }
            else
            {
                MessageBox.Show("Не верный логин или пароль");
                LoginForm lg = new LoginForm();
                lg.Show();
            }
        }
        public void admUsGrid(DataGridView thisgrid)
        {
            Data d = new Data();
          
            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", d.GetConnection());

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            thisgrid.DataSource = dt.DefaultView;
            thisgrid.AutoGenerateColumns = true;
            d.closeConnection();
        }
        public void admUsGridUpdate(DataGridView thisgrid, DataGridViewCellEventArgs e)
        {
            Data d = new Data();
            d.openConnection();
            SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Users", d.GetConnection());
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            builder.GetInsertCommand();
            builder.GetUpdateCommand();
            builder.GetDeleteCommand();
            DataSet set = new DataSet();
            adapter.Fill(set, "Users");

            set.Tables["Users"].Rows[e.RowIndex]["Id"] = thisgrid.Rows[e.RowIndex].Cells["Id"].Value;
            set.Tables["Users"].Rows[e.RowIndex]["Name"] = thisgrid.Rows[e.RowIndex].Cells["Name"].Value;
            set.Tables["Users"].Rows[e.RowIndex]["Surname"] = thisgrid.Rows[e.RowIndex].Cells["Surname"].Value;
            set.Tables["Users"].Rows[e.RowIndex]["Username"] = thisgrid.Rows[e.RowIndex].Cells["Username"].Value;
            set.Tables["Users"].Rows[e.RowIndex]["Password"] = thisgrid.Rows[e.RowIndex].Cells["Password"].Value;
            set.Tables["Users"].Rows[e.RowIndex]["Promote"] = thisgrid.Rows[e.RowIndex].Cells["Promote"].Value;
            adapter.Update(set, "Users");


            d.closeConnection();
        }
        
        public void admUsGridDel(DataGridView thisgrid, EventArgs e)
        {
            var temp = thisgrid.CurrentCell.RowIndex;
            thisgrid.Rows.RemoveAt(temp);
            thisgrid.Rows[temp].SetValues(0);
            Data d = new Data();
            d.openConnection();
            SqlCommand command = new SqlCommand("DELETE FROM Users WHERE Id = @row", d.GetConnection());
            command.Parameters.Add("@row", SqlDbType.Int).Value = temp + 1;
            command.ExecuteNonQuery();
            d.closeConnection();
        }
    }
}
