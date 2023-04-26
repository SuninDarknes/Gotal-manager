using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gotal_manager
{
    internal class DatabaseManager
    {
        private static string connectionString = "server=localhost;database=gotal-manager;uid=root;password=root1119;";
        private static MySqlConnection? connection;


        public static MySqlConnection Connection
        {
            get
            {
                if (connection == null)
                {
                    connection = new MySqlConnection(connectionString);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }

                return connection;
            }
        }
    }
}
