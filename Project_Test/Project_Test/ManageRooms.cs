using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Test
{
    public partial class ManageRooms : Form
    {
        Room room = new Room();

        public ManageRooms()
        {
            InitializeComponent();
        }

        private void ManageRooms_Load(object sender, EventArgs e)
        {
            comboBoxRoomType.DataSource = room.getRoomTypes();
            comboBoxRoomType.DisplayMember = "type";
            comboBoxRoomType.ValueMember = "id";
            dataGridView1.DataSource = room.getList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxRoomID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomType.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxRoomStatus.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();

        }

        private void buttonAddNewRoom_Click(object sender, EventArgs e)
        {
            string type = comboBoxRoomType.Text;
            string status = textBoxRoomStatus.Text;
            bool insert = room.insertRoom(type,status);

            if (type.Trim().Equals("") || status.Trim().Equals(""))
            {

                MessageBox.Show("Required Fields Room type & Room status", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (insert)
                {
                    dataGridView1.DataSource = room.getList();
                    MessageBox.Show("New Room Inserted Successfully", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Room Not Inserted", "Add Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonEditRoom_Click(object sender, EventArgs e)
        {
            int id;
            string type = comboBoxRoomType.Text;
            string status = textBoxRoomStatus.Text;
            try
            {
                id = Convert.ToInt32(textBoxRoomID.Text);
                if (type.Trim().Equals("") || status.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields Room type & Room status", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool edit = room.editRoom(id, type, status);
                    if (edit)
                    {
                        dataGridView1.DataSource = room.getList();
                        MessageBox.Show("Room Updated Successfully", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Room Not Edited", "Edit Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveRoom_Click(object sender, EventArgs e)
        {
            int id;
            try
            {
                id = Convert.ToInt32(textBoxRoomID.Text);
                
               
                bool remove = room.removeRoom(id);
                if (remove)
                {
                    dataGridView1.DataSource = room.getList();
                    MessageBox.Show("Room Deleted Successfully", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Room Not Deleted", "Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxRoomID.Text = "";
            comboBoxRoomType.SelectedIndex = 0;
            textBoxRoomStatus.Text = "";
        }
    }        
}
