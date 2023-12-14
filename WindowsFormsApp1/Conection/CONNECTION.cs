using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BCrypt.Net;

namespace WindowsFormsApp1
{
    internal class Connection
    {
        private readonly SqlConnection con;
        private readonly string DataBase = "BANCOWILL";

        public Connection()
        {
            string stringConnection = @"Data Source=" + Environment.MachineName +
                @"\SQLEXPRESS;Initial Catalog=" + DataBase + ";Integrated Security=true";
            con = new SqlConnection(stringConnection);
            con.Open(); // Abrir a conexão com o banco de dados
        }

        public void CloseConnection()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }

        public SqlConnection ReturnConnection()
        {
            return con;
        }
    }
}
