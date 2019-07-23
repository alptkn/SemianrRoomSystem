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
    public partial class ManageClients : Form
    {
        public ManageClients()
        {
            InitializeComponent();
        }
        Clients client = new Clients();
        

        private void ManageClients_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.getClients();
        }

      

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxClientID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            textBoxFirstName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBoxLastName.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
        }

        private void buttonAddNewClient_Click(object sender, EventArgs e)
        {
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;
            bool insert = client.inserClient(fname, lname);

            if(fname.Trim().Equals("") || lname.Trim().Equals(""))
            {
                
                MessageBox.Show("Required Fields First name & Last name", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (insert)
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("New Client Inserted Successfully", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Inserted", "Add Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClearFields_Click(object sender, EventArgs e)
        {
            textBoxClientID.Text = "";
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            int id;
            string fname = textBoxFirstName.Text;
            string lname = textBoxLastName.Text;

            try
            {
                id = Convert.ToInt32(textBoxClientID.Text);
                if(fname.Trim().Equals("") || lname.Trim().Equals(""))
                {
                    MessageBox.Show("Required Fields First name & Last name", "Empty Fields", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    bool edit = client.editClient(id, fname, lname);
                    if (edit)
                    {
                        dataGridView1.DataSource = client.getClients();
                        MessageBox.Show("Client Updated Successfully", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("ERROR - Client Not Edited", "Edit Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonRemoveClient_Click(object sender, EventArgs e)
        {
            int id;

            try
            {
                id = Convert.ToInt32(textBoxClientID.Text);
                if (client.removeClient(id))
                {
                    dataGridView1.DataSource = client.getClients();
                    MessageBox.Show("Client Deleted Successfully", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("ERROR - Client Not Deleted", "Delete Client", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "ID Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
