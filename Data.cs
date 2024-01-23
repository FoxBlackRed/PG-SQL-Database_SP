using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace SharpDesktopTraning
{
    class Data
    {
        private SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\wycct\source\repos\SharpDesktopTraning\DataBases\MainDataBase.mdf;Integrated Security=True");
        //TODO: private SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["MainDataBase"].ConnectionString);
        public void openConnection() 
        {
            if (con.State == ConnectionState.Closed) { con.Open(); }
        }

        public void closeConnection()
        {
            if (con.State == ConnectionState.Open) { con.Close(); }
        }
        public SqlConnection GetConnection() 
        {
            return con;
        }
    }
}
