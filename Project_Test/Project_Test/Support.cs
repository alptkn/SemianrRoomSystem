using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Project_Test
{
    public partial class Support : Form
    {
        Room room = new Room();
        Reservation reservation = new Reservation();
        SupportClass support = new SupportClass();
        public Support()
        {

            InitializeComponent();
        }

        private void Support_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = support.getlist();
            comboBoxRoomID.DataSource = reservation.getRoomId();
            comboBoxRoomID.DisplayMember = "room_id";
            comboBoxRoomID.ValueMember = "room_id";
        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxSupportID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            comboBoxRoomID.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxIssue.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonAddNewSupport_Click(object sender, EventArgs e)
        {
            int roomId = Convert.ToInt32(comboBoxRoomID.Text);
            string issue = textBoxIssue.Text;
            bool insert = support.insertSupport(roomId, issue);
            if (insert)
            {
                dataGridView1.DataSource = support.getlist();
                MessageBox.Show("Issue Inserted Succesfully", "Insert Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MailAddress from = new MailAddress("seminarroomsystem@gmail.com");
                MailAddress to = new MailAddress("alptknheat@gmail.com");
                MailMessage message = new MailMessage(from, to);
                message.Subject = comboBoxRoomID.Text + " technical support";
                message.Body = textBoxIssue.Text;
                message.BodyEncoding = System.Text.Encoding.UTF8;
                message.IsBodyHtml = true;
                SmtpClient client = new SmtpClient("smtp.gmail.com",587);
                client.UseDefaultCredentials = false;
                client.EnableSsl = true;
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential("seminarroomsystem@gmail.com", "seminarroom12345");


                     
                try
                {
                    client.Send(message);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Issue not Inserted", "Insert Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void buttonEditSupport_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxSupportID.Text);
                int roomId = Convert.ToInt32(comboBoxRoomID.Text);
                string issue = textBoxIssue.Text;
                bool edit = support.editSupport(id, roomId, issue);
                if (edit)
                {
                    dataGridView1.DataSource = support.getlist();
                    MessageBox.Show("Issue Updated Succesfully", "Update Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Issue not Updated", "Edit Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveSupport_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(textBoxSupportID.Text);
                bool remove = support.remmoveSupport(id);
                if (remove)
                {
                    dataGridView1.DataSource = support.getlist();
                    MessageBox.Show("Issue Deleted Succesfully", "Remove Issue", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Issue not Deleted", "Remove Issue", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxSupportID.Text = "";
            comboBoxRoomID.SelectedIndex = 0;
            textBoxIssue.Text = "";
        }

    }
}
