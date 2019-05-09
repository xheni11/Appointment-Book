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
    public partial class UserAppointmentForm : Form
    {
        public int idAppointment;
        public int FlagInvitationForm;
        public UserAppointmentForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserAppointmentForm_Load(object sender, EventArgs e)
        {
            AppointmentContext context = new AppointmentContext();
            Repository<APPOINTMENT> repository = new Repository<APPOINTMENT>(context);
            int id = SessionContext.Instance.CurrentUser.Id;
            if (FlagInvitationForm == 1)
            {
                dataGridViewAppointment.DataSource = repository.GetAllInvitationUser(id);
                StartDatePicker.Enabled = false;
                EndDatePicker.Enabled = false;
                SubjectTextBox.Enabled = false;
                comboBoxLocation.Enabled = false;
                listBoxAttendees.Enabled = false;
                buttonCancel.Visible = false;
                buttonNew.Visible = false;
                label1.Text = "List of invitations that are waitting for accepting";
            }
            else
            {
                dataGridViewAppointment.DataSource = repository.GetAllAppointmentUser(id);
                comboBoxLocation.DataSource = repository.GetAllLocations().ToList();
                listBoxAttendees.DataSource = repository.GetAllUsers();
                checkBoxAccept.Visible = false;
            }
            ClearView();

        }
        private APPOINTMENT GetAppointment()
        {
            return new APPOINTMENT()
            {
                
                StartDate = this.StartDate(),
                EndDate = this.EndDate(),
                CreatedDate = this.CreatedDate(),
                ModifiedDate = this.ModifiedDate(),
                Subject = this.Subject(),
                IdLocation = this.AppointmentLocation(),
                IdScheduler = SessionContext.Instance.CurrentUser.Id,
                Status=1


            };
        }
        private Boolean ValidateAppointDurationTime()
        {

            if ((EndDatePicker.Value - StartDatePicker.Value).TotalMinutes < 15)
            {
                MessageBox.Show("The appointment duration should be at least 15 minutes!");
                return false;
            }
            else
            {
                return true;
            }
        }
        private DateTime StartDate()
        {
            return StartDatePicker.Value;
        }

        private DateTime EndDate()
        {
            return EndDatePicker.Value;
        }
        private DateTime CreatedDate()
        {
            return DateTime.UtcNow;
        }

        private DateTime ModifiedDate()
        {
            return DateTime.UtcNow;
        }

        private string Subject()
        {
            return SubjectTextBox.Text;
        }

        private int AppointmentLocation()
        {
            return (int)comboBoxLocation.SelectedValue;
        }

        private void AddAttendees()
        {
            AppointmentContext context = new AppointmentContext();
            Repository<ATTENDEES_APPOINTMENT> repository = new Repository<ATTENDEES_APPOINTMENT>(context);
            foreach (var item in listBoxAttendees.SelectedItems)
            {
                ATTENDEES_APPOINTMENT attendee = new ATTENDEES_APPOINTMENT();
                attendee.IdAppointment = context.APPOINTMENTs.Select(a => a.Id).Max();
                USER person = (USER)item;
                attendee.IdUser = person.Id;
                attendee.Accepted = false;
                attendee.HasReminder = false;
                repository.Insert(attendee);
            }

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            AppointmentContext context = new AppointmentContext();

            if (FlagInvitationForm == 1)
            {
                Repository<ATTENDEES_APPOINTMENT> repository = new Repository<ATTENDEES_APPOINTMENT>(context);
                AppointmentData currentObject = (AppointmentData)dataGridViewAppointment.CurrentRow.DataBoundItem;
                ATTENDEES_APPOINTMENT attendesAppointment = repository.GetAttende(currentObject.Id,SessionContext.Instance.CurrentUser.Id);
                if (idAppointment > 0)
                {
                    attendesAppointment.Note = NotesTextBox.Text;
                    attendesAppointment.Accepted = checkBoxAccept.Checked;
                    repository.Update(attendesAppointment);
                    dataGridViewAppointment.DataSource = repository.GetAllInvitationUser(idAppointment);
                }
            }
            else
            {
                if (ValidateAppointDurationTime())
                {
                    APPOINTMENT appointment = GetAppointment();
                    Repository<APPOINTMENT> repository = new Repository<APPOINTMENT>(context);

                    if (idAppointment > 0)
                    {
                        appointment.Id = idAppointment;
                        repository.Update(appointment);
                    }
                    else
                    {
                        
                        repository.Insert(appointment);
                    }
                    
                    AddAttendees();
                    ClearView();
                    dataGridViewAppointment.DataSource = repository.GetAllAppointmentUser(idAppointment);
                }
            }
   
        }
        private void ClearView()
        {
            idAppointment = 0;

            StartDatePicker.Value = DateTime.Now;
            EndDatePicker.Value = DateTime.Now;
            SubjectTextBox.Text ="";
            NotesTextBox.Text = "";
            comboBoxLocation.SelectedIndex = 0;
            listBoxAttendees.SelectedValue = 0;
            StartDatePicker.Enabled = true;
            EndDatePicker.Enabled = true;

        }
        private void dataGridViewAppointment_DoubleClick(object sender, EventArgs e)
        {
            AppointmentData currentObject = (AppointmentData)dataGridViewAppointment.CurrentRow.DataBoundItem;
            AppointmentContext context = new AppointmentContext();
            Repository<ATTENDEES_APPOINTMENT> repository = new Repository<ATTENDEES_APPOINTMENT>(context);
            List<ATTENDEES_APPOINTMENT> aTTENDEEs = repository.GetAllAttendees().ToList();
            StartDatePicker.Value = currentObject.StartDate;
            EndDatePicker.Value = currentObject.EndDate;
            StartDatePicker.Enabled = false;
            EndDatePicker.Enabled = false;
            SubjectTextBox.Text = currentObject.Subject;
            comboBoxLocation.SelectedValue = currentObject.Location.Id;
            foreach (var item in aTTENDEEs )
            {
                if (item.IdAppointment==currentObject.Id)
                {
                    listBoxAttendees.SelectedValue = item.IdUser;
                    NotesTextBox.Text = NotesTextBox.Text + "\n" + item.Note;
                }
            }
            idAppointment = currentObject.Id;

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearView();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            APPOINTMENT appointment = GetAppointment();
            AppointmentContext context = new AppointmentContext();
            Repository<APPOINTMENT> repository = new Repository<APPOINTMENT>(context);
            if (idAppointment > 0)
            {
                appointment.Id = idAppointment;
                appointment.Status = 0;
                repository.Update(appointment);
                ClearView();
                dataGridViewAppointment.DataSource = repository.GetAllAppointmentUser(idAppointment);
            }
            else
            {
                MessageBox.Show("You should select an appointment first!");
            }
        }

        private void buttonReminder_Click(object sender, EventArgs e)
        {
            AddReminderForm addReminder = new AddReminderForm();
            addReminder.idAppointment =this. idAppointment;
            addReminder.Show();
        }
    }
}
