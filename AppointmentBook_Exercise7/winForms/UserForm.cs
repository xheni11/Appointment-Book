using AppointmentBook_Exercise7.dataAccess;
using AppointmentBook_Exercise7.winForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppointmentBook_Exercise7
{
    public partial class UserForm : Form
    {
        
        public UserForm()
        {
            InitializeComponent();
        }

        private void buttonAppointment_Click(object sender, EventArgs e)
        {
            UserAppointmentForm userAppointment = new UserAppointmentForm();
            userAppointment.FlagInvitationForm = 0;
            userAppointment.Show();
        }

        private void buttonInvitation_Click(object sender, EventArgs e)
        {
            UserAppointmentForm invitations = new UserAppointmentForm();
            invitations.FlagInvitationForm = 1;
            invitations.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonCanceled_Click(object sender, EventArgs e)
        {
            CanceledAppointmentForm canceledAppointmentForm = new CanceledAppointmentForm();
            canceledAppointmentForm.Show();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            Thread.Sleep(2000);
        }
    }
}
