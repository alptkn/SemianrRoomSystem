using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project_Test
{
    class Room
    {
        Connect conn = new Connect();
        

        public DataTable getList()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM rooms", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

        public DataTable getRoomTypes()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM types", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable getType()
        {
            MySqlCommand command = new MySqlCommand("SELECT type FROM rooms WHERE status = 'Free'", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable getRoomID()
        {
            MySqlCommand command = new MySqlCommand("SELECT id FROM rooms WHERE status = 'Free'", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public int getRoomIdfromReservID(int id)
        {
            int result = 0;
            MySqlCommand command = new MySqlCommand("SELECT room_id FROM reservations WHERE reserv_id = @id",conn.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            conn.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                result = reader.GetInt32(0);
            }
            reader.Close();
            conn.closeConnection();


            return result;
        }

        public string getRoomTypeFromId(string IDstring)
        {
            int id = Convert.ToInt32(IDstring);
            MySqlCommand command = new MySqlCommand("SELECT type FROM rooms WHERE id=@id", conn.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            conn.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            string type = "";
            while (reader.Read())
            {
                type = reader.GetString(0);
            }
            reader.Close();
            conn.closeConnection();
            return type;
        }

        public bool statusFreeToReserved(int id)
        {
            MySqlCommand command = new MySqlCommand("UPDATE rooms SET status = 'Reserved' WHERE id = @id",conn.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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

         public bool statusReservedToFree(int id)
        {
            
            MySqlCommand command = new MySqlCommand();
            string query = "UPDATE rooms SET status = 'Free' WHERE id= @id ";
            command.CommandText = query;
            command.Connection = conn.getConnection();
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
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
        
        public bool insertRoom(string type, string status)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "INSERT INTO rooms (type,status) VALUES (@type,@status)";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
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

        public bool editRoom(int id, string type, string status)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "UPDATE rooms SET type=@type,status=@status WHERE id=@id ";
            command.CommandText = insertQuery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            command.Parameters.Add("@type", MySqlDbType.VarChar).Value = type;
            command.Parameters.Add("@status", MySqlDbType.VarChar).Value = status;
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

        public bool removeRoom(int id)
        {
            MySqlCommand command = new MySqlCommand();
            string insertQuery = "DELETE FROM rooms WHERE id=@id ";
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
