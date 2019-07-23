using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project_Test
{
    
    class Clients
    {
        Connect conn = new Connect();
        Connect conn2 = new Connect();

        // create a function to get all clients list 
        public DataTable getClients()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM  user",conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        // Thiis function takes name and surname of the client and create anaother column in data table
        // by merging name and surname 
        public DataTable getClientName()
        {

            MySqlCommand command = new MySqlCommand("SELECT first_name,last_name FROM user ", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            table.Columns.Add("FullName", typeof(string), "first_name + ' ' + last_name");
            return table;
        }

        /*
         When click datagridview, this function takes the client id  
         brings the name amd surname of the client from user table 
        */

        public string[] getClientNameFromID(string idString)
        {

            int id = Convert.ToInt32(idString);
            MySqlCommand command = new MySqlCommand("SELECT first_name,last_name FROM user WHERE id=@id", conn2.getConnection());    // reader cannot use same connection with ExecuteNonQuery
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            conn2.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            string[] name = new string[2];
            while (reader.Read())
            {
                name[0] = reader.GetString(0);
                name[1] = reader.GetString(1);
            }
            reader.Close();                 // to use method again, reader must be close 
            conn2.closeConnection();
            return name;

        }

        

        public bool inserClient(string fname, string lname)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO user (first_name,last_name) VALUES (@fnm,@lnm)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            conn.openConnection();

            if(command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
            
        }

        public bool editClient(int id, string fname, string lname)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "UPDATE user SET first_name=@fnm, last_name=@lnm WHERE id=@id";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@fnm", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lnm", MySqlDbType.VarChar).Value = lname;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }

        public bool removeClient(int id)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "DELETE FROM user WHERE id = @id";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            conn.openConnection();

            if (command.ExecuteNonQuery() == 1)
            {
                conn.closeConnection();
                return true;
            }
            else
            {
                conn.closeConnection();
                return false;
            }
        }
    }

   
}
