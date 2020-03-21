using AppointmentBook_Exercise7.dataAccess;
using AppointmentBook_Exercise7.model;
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
    public partial class CanceledAppointmentForm : Form
    {
        public CanceledAppointmentForm()
        {
            InitializeComponent();
        }

        private void InvitationsForm_Load(object sender, EventArgs e)
        {
            AppointmentContext context = new AppointmentContext();
            Repository<AppointmentData> repository = new Repository<AppointmentData>(context);
            int id = SessionContext.Instance.CurrentUser.Id;
            dataGridViewCanceled.DataSource = repository.GetAllInvitationCanceled(id);
        }
    }
}
