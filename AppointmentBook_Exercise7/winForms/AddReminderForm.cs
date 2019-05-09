using AppointmentBook_Exercise7.dataAccess;
using AppointmentBook_Exercise7.enums;
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
    public partial class AddReminderForm : Form
    {
        public int idAppointment;
        public AddReminderForm()
        {
            InitializeComponent();
        }
        private int IdUser()
        {
            return SessionContext.Instance.CurrentUser.Id;
        }
        private int IdAppointment()
        {
            return idAppointment;
        }
        private int ReminderTime()
        {
            return (int)comboBoxReminderTime.SelectedValue;
        }
        private int Snooze()
        {
            return (int)comboBoxSnooze.SelectedValue;
        }
        private bool HasSound()
        {
            return checkBoxHasSound.Checked;
        }
        private REMINDER GetREMINDER()
        {
            return new REMINDER
            {
                IdAppointment = this.IdAppointment(),
                IdUser = this.IdUser(),
                ReminderTime = this.ReminderTime(),
                Snooze = this.Snooze(),
                HasSound = this.HasSound()

            };
        }
        private void AddReminderForm_Load(object sender, EventArgs e)
        {
            comboBoxReminderTime.DataSource= Enum.GetValues(typeof(MinutesReminder));
            comboBoxSnooze.DataSource = Enum.GetValues(typeof(MinutesReminder));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            AppointmentContext context = new AppointmentContext();
            Repository<REMINDER> repository = new Repository<REMINDER>(context);
            REMINDER reminder = GetREMINDER();
            repository.Insert(reminder);
            this.Close();
        }
    }
}
