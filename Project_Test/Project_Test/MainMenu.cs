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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void manageClientsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageClients manageCF = new ManageClients();
            manageCF.ShowDialog();
        }

        private void manageRoomsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageRooms manageRF = new ManageRooms();
            manageRF.ShowDialog();
        }

        private void manageReservationsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManageReservation reservation = new ManageReservation();
            reservation.ShowDialog();
        }

        private void technicalSupportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Support support = new Support();
            support.ShowDialog();
        }
    }
}
