using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project_Test
{
    class Reservation
    {

        Connect conn = new Connect();


        public DataTable getlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM reservations", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        
        public DataTable getRoomId()
        {
            MySqlCommand command = new MySqlCommand("SELECT room_id FROM reservations WHERE 1", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }


        public int[] getResevationID()
        {
            int[] id = new int[30];
            int count = 0;
            MySqlCommand command = new MySqlCommand("SELECT reserv_id FROM reservations WHERE 1",conn.getConnection());
            conn.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                id[count] = reader.GetInt32(0);
                count = count + 1;
            }
            reader.Close();
            conn.closeConnection();
            return id;
        }

        public DateTime getDateOut(int id)
        {
            DateTime date = default(DateTime);
            MySqlCommand command = new MySqlCommand("SELECT date_out FROM reservations WHERE reserv_id = @id", conn.getConnection());
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
            conn.openConnection();
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                date = reader.GetDateTime(0);
            }
            reader.Close();
            conn.closeConnection();
            return date;

        }

        public bool insertReservation(string fname,string lname, int RoomId, DateTime DateIn, DateTime Dateout)
        {
            MySqlCommand command = new MySqlCommand();
            string insertquery = "   INSERT INTO reservations(client_id, room_id, date_in, date_out) SELECT id, @roomId, @dateIn, @dateOut FROM user WHERE first_name = @fname AND last_name = @lname AND NOT EXISTS( SELECT * FROM reservations  WHERE date_out >= @dateIn  AND date_in <= @dateOut ) ";
            command.CommandText = insertquery;
            command.Connection = conn.getConnection();

            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@roomId", MySqlDbType.Int32).Value = RoomId;
            command.Parameters.Add("@dateIn", MySqlDbType.DateTime).Value = DateIn;
            command.Parameters.Add("@dateOut", MySqlDbType.DateTime).Value = Dateout;
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

        public bool editReservstion(int id,DateTime dateIn,DateTime dateOut)
        {
            MySqlCommand command = new MySqlCommand("UPDATE reservations SET date_in = @dateIn, date_out = @dateOut WHERE reserv_id = @id AND (@dateOut >= date_out  AND @dateOut <= date_in) ", conn.getConnection());
            command.Parameters.Add("@dateIn", MySqlDbType.DateTime).Value = dateIn;
            command.Parameters.Add("@dateOut", MySqlDbType.DateTime).Value = dateOut;
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

        public bool removeReservation(int reservid)
        {
            MySqlCommand command = new MySqlCommand();
            string removeQuery = "DELETE FROM reservations WHERE reserv_id = @id ";
            command.CommandText = removeQuery;
            command.Connection = conn.getConnection();
            command.Parameters.Add("@id", MySqlDbType.Int32).Value = reservid;
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

        
    }

    
}


