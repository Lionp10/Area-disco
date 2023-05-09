using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sistemaArea
{
    public abstract class ConexionDB
    {
        private readonly string connectionString;
        public ConexionDB()
        {
            connectionString = "Data Source=LIONEL\\SQLEXPRESS;DataBase=sistemaArea;integrated security=true;";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
}
