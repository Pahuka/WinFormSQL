using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DataBase
{
    static class Data
    {
        private static SqlConnection sqlConnection = new SqlConnection(
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\brylin_da\source\repos\WinFormSQL\Database1.mdf;Integrated Security=True");

        public static string DataPath { get; set; }

        public static void OpenConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Closed)
                sqlConnection.Open();
        }

        public static void CloseConnection()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open)
                sqlConnection.Close();
        }

        public static SqlConnection GetConnection()
        {
            return sqlConnection;
        }
    }
}
