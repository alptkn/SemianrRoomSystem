using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project_Test
{
    // make connection between our app and mysql database 
    class Connect
    {
        private MySqlConnection Connection = new MySqlConnection("database = test; Server = localhost; port = 3306; user id = root; pwd = 12345;");

        // create a function to return our connection
        public MySqlConnection getConnection()
        {
            return Connection;
        }

        // create function to open connection 
        public void openConnection()
        {
            if(Connection.State == ConnectionState.Closed)
            {
                Connection.Open();
            }
        }

        // create a function to close connection 
        public void closeConnection()
        {
            if(Connection.State == ConnectionState.Open)
            {
                Connection.Close();
            }
        }
    }
}
