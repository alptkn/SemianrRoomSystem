using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Project_Test
{
    class SupportClass
    {
        Connect conn = new Connect();
        public DataTable getlist()
        {
            MySqlCommand command = new MySqlCommand("SELECT * FROM support ", conn.getConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public bool insertSupport(int roomId,string issue)
        {
            MySqlCommand command = new MySqlCommand("INSERT INTO support (room_id,issue) VALUES (@roomId,@issue)",conn.getConnection());
            command.Parameters.Add("@roomId", MySqlDbType.Int32).Value = roomId;
            command.Parameters.Add("issue", MySqlDbType.VarChar).Value = issue;
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

        public bool editSupport(int id,int roomId,string issue)
        {
            MySqlCommand command = new MySqlCommand("UPDATE support SET room_id = @roomId, issue = @issue WHERE support_id = @id",conn.getConnection());
            command.Parameters.Add("@roomId", MySqlDbType.Int32).Value = roomId;
            command.Parameters.Add("issue", MySqlDbType.VarChar).Value = issue;
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

        public bool remmoveSupport(int id)
        {
            MySqlCommand command = new MySqlCommand("DELETE FROM support WHERE support_id = @id", conn.getConnection());
            command.Parameters.Add("id", MySqlDbType.Int32).Value = id;
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
