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
    public partial class ManageReservation : Form
    {
        public ManageReservation()
        {
            InitializeComponent();
        }

        Reservation reservation = new Reservation();
        Clients client = new Clients();
        Room room = new Room();

        private void ManageReservation_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = reservation.getlist();
            comboBoxRoomType.DataSource = room.getType();
            comboBoxRoomType.DisplayMember = "type";
            comboBoxRoomType.ValueMember = "type";


            comboBoxRoomID.DataSource = room.getRoomID();
            comboBoxRoomID.DisplayMember = "id";
            comboBoxRoomID.ValueMember = "id";

            comboBoxClientName.DataSource = client.getClientName();
            comboBoxClientName.DisplayMember = "FullName";
            comboBoxClientName.ValueMember = "Fullname";

            int[] reserv_id = new int[30];
            reserv_id = reservation.getResevationID();
            int lenght = reserv_id.Length;
            for (int i = 0; i < lenght; i++)
            {
                if (reservation.getDateOut(reserv_id[i]) < DateTime.Now)
                {
                    int room_id = room.getRoomIdfromReservID(reserv_id[i]);
                    room.statusReservedToFree(room_id);
                    reservation.removeReservation(reserv_id[i]);
                }
            }

        }

        private void buttonAddNewReservation_Click(object sender, EventArgs e)
        {
            var name = comboBoxClientName.Text.Split(new[] {' '});               // split vakue in the comboboxClientname to name and surname for sql query 
            int roomID = Convert.ToInt32(comboBoxRoomID.Text);
            DateTime dateIn = dateTimePickerDateIn.Value;
            DateTime dateOut = dateTimePickerDateOut.Value;
           

            if (dateIn < DateTime.Now)
            {
                MessageBox.Show("The Date In Must Be = or > Today Date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (dateOut < dateIn)
            {
                MessageBox.Show("The Date Out Must Be = or > The Date In", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
              
              
                 if (reservation.insertReservation(name[0], name[1], roomID, dateIn, dateOut))
                 {
                      int id = Convert.ToInt32(comboBoxRoomID.Text);
                      room.statusFreeToReserved(id);
                      dataGridView1.DataSource = reservation.getlist();

                      MessageBox.Show("New Reservation Added", "Add Resevation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 }
                 else
                 {
                      MessageBox.Show("Reservation Not Added", "Add Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 }
                
            }
            
        }
        private void buttonEditReservation_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxReservID.Text);
                DateTime dateIn = dateTimePickerDateIn.Value;
                DateTime dateOut = dateTimePickerDateOut.Value;

                bool edit = reservation.editReservstion(id,dateIn,dateOut);
                if (dateIn < DateTime.Now)
                {
                    MessageBox.Show("The Date In Must Be = or > Today Date", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (dateOut < dateIn)
                {
                    MessageBox.Show("The Date Out Must Be = or > The Date In", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (edit)
                    {

                        dataGridView1.DataSource = reservation.getlist();
                        MessageBox.Show("Reservation Updated Successfully", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Reservation not Updated", "Edit Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveReservation_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                int reserv_id = Convert.ToInt32(textBoxReservID.Text);
                int room_id = room.getRoomIdfromReservID(reserv_id);
                bool remove = reservation.removeReservation(reserv_id);
                if (remove)
                {
                    room.statusReservedToFree(room_id);
                    
                    dataGridView1.DataSource = reservation.getlist();
                    MessageBox.Show("Reservation Deleted Successfully", "Remove Reservation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Reservation not Deleted", "Reomove Reservation", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxReservID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string[] name = new string[2];
            name = client.getClientNameFromID(dataGridView1.CurrentRow.Cells[1].Value.ToString());
            comboBoxClientName.Text = name[0] + " " + name[1];
            comboBoxRoomID.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            comboBoxRoomType.Text = room.getRoomTypeFromId(dataGridView1.CurrentRow.Cells[2].Value.ToString());
            dateTimePickerDateIn.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            dateTimePickerDateOut.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

       
    }
}
