using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentBook_Exercise7.winForms
{
    public partial class ManagerForm : Form
    {
        public ManagerForm()
        {
            InitializeComponent();
        }

        private void buttonUsers_Click(object sender, EventArgs e)
        {
            ManageUsersForm manageUsers = new ManageUsersForm();
            manageUsers.Show();
        }

        private void buttonLocations_Click(object sender, EventArgs e)
        {
            ManageLocationsForm manageLocations =new ManageLocationsForm();
            manageLocations.Show();
        }

        private void buttonAppointments_Click(object sender, EventArgs e)
        {
            ManagerAppointments managerAppointments = new ManagerAppointments();
            managerAppointments.Show();
        }
    }
}
