using AppointmentBook_Exercise7.dataAccess;
using AppointmentBook_Exercise7.enums;
using AppointmentBook_Exercise7.statistics;
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
    public partial class ManagerAppointments : Form
    {
        Statistics statistics = new Statistics(); 
        public ManagerAppointments()
        {
            InitializeComponent();
        }

        private void ManagerAppointments_Load(object sender, EventArgs e)
        {
            AppointmentContext context = new AppointmentContext();
            Repository<APPOINTMENT> repository = new Repository<APPOINTMENT>(context);


            dataGridViewAppointmens.DataSource = repository.GetAllAppointment();
            comboBoxStatistics.DataSource= Enum.GetValues(typeof(StatisticsEnum));
            comboBoxUsers.DataSource = repository.GetAllUsers();

        }

        private void buttonGeneric_Click(object sender, EventArgs e)
        {
            USER person = (USER)comboBoxUsers.SelectedItem;
            AppointmentContext context = new AppointmentContext();
            Repository<APPOINTMENT> repository = new Repository<APPOINTMENT>(context);
            switch (comboBoxStatistics.SelectedIndex)
            {

                case 0:
                    dataGridViewAppointmens.DataSource = statistics.Longest_User_Appointment(person.Id);
                    break;
                case 1:
                    dataGridViewAppointmens.DataSource = statistics.Earliest_Appointment_Of_User(person.Id);
                    break;
                //case 2:
                //    labelShowStatistic.Text = "Appointments number for " + person.FirstName + ": " + statistics.Appointments_Number_For_User(person.Id);
                //    break;
                //case 3:
                //    dataGridViewAppointmens.DataSource = statistics.Longest_Day_Appointment(dateTimePicker.Value);
                //    break;
                //case 4:
                //    dataGridViewAppointmens.DataSource = statistics.Earliest_Appointment_Of_Day(dateTimePicker.Value);
                //    break;
                //case 5:
                //    labelShowStatistic.Text = "APpointments number for " + dateTimePicker.Value.Day + ":" + statistics.Appointments_Number_For_Day(dateTimePicker.Value);
                //    break;
                //case 6:
                //    dataGridViewAppointmens.DataSource = statistics.Largest_Number_Of_Attendees();
                //    break;
                //case 8:
                //    labelShowStatistic.Text = "Average duartion of appointment in " + dateTimePicker.Value.Day + ": " + statistics.Average_Duration_Of_Appointments_Of_Day(dateTimePicker.Value);
                //    break;
                default:
                    dataGridViewAppointmens.DataSource = repository.GetAllAppointment();
                    break;
            }
        }
    }
}
