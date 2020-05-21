using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace c_sharp_account_manager
{
    class Connection
    {
        static SqlConnection connection;
        static string connectionString;

        Connection()
        {
            connectionString = ConfigurationManager.ConnectionStrings["c_sharp_account_manager.Properties.Settings.UsersConnectionString"].ConnectionString;
        }

        public static SqlConnection getConnection()
        {
            using (connection = new SqlConnection(connectionString))
            {
                connection.Open();

                return connection;
            }

        }
    }
}
