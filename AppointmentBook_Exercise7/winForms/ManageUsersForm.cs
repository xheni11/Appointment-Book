using AppointmentBook_Exercise7.dataAccess;
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
    public partial class ManageUsersForm : Form
    {
        private int id;
        //private BindingSource bindingSourceUsers = new BindingSource();
        public ManageUsersForm()
        {
            InitializeComponent();
        }
        private string FirstName()
        {
            return textBoxFirstName.Text;
        }
        private string LastName()
        {
            return textBoxLastName.Text;
        }
        private string Gender()
        {
            if(radioButtonFemale.Checked)
            {
                return "F";
            }
            else
            {
                return "M";
            }
        }
        private string Username()
        {
            return textBoxUsername.Text;
        }
        private string Password()
        {
            return textBoxUsername.Text;
        }
        private int IdRole()
        {
            return (int)comboBoxRole.SelectedValue;
        }


        private void ManageUsersForm_Load(object sender, EventArgs e)
        {
            AppointmentContext context = new AppointmentContext();
            Repository<USER> repository = new Repository<USER>(context);
            userBindingSource.DataSource = repository.GetAllUsers();
            roleBindingSource.DataSource = repository.GetAllRoles();
        }
        private USER CreateNewUser()
        {
            return new USER
            {
                FirstName = this.FirstName(),
                LastName = this.LastName(),
                Username = this.Username(),
                Gender = this.Gender(),
                IdRole = this.IdRole(),
                Password = this.Password()
            };
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            USER user = CreateNewUser();
            
            AppointmentContext context = new AppointmentContext();
            Repository<USER> repository = new Repository<USER>(context);
            if (id > 0)
            {
                user.Id = id;
                repository.Update(user);
            }
            else
            {
                repository.Insert(user);
            }
            ClearView();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        private void ClearView()
        {
            id = 0;
            textBoxFirstName.Text = "";
            textBoxLastName.Text = "";
            textBoxUsername.Text = "";
            radioButtonFemale.Checked = true;
            comboBoxRole.SelectedIndex = 0;
            AppointmentContext context = new AppointmentContext();
            Repository<USER> repository = new Repository<USER>(context);
            userBindingSource.DataSource = repository.GetAllUsers();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            USER currentObject = (USER)dataGridView1.CurrentRow.DataBoundItem;
            
            textBoxFirstName.Text = currentObject.FirstName;
            textBoxLastName.Text = currentObject.LastName;
            textBoxUsername.Text = currentObject.Username;
            if( currentObject.Gender!=null && currentObject.Gender.Equals("M"))
            {
                radioButtonMale.Checked = true;
            }
            comboBoxRole.SelectedValue = currentObject.IdRole;
            id = currentObject.Id;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            USER currentObject = (USER)dataGridView1.CurrentRow.DataBoundItem;
            if (currentObject.Id != null)
            {
                AppointmentContext context = new AppointmentContext();
                Repository<USER> repository = new Repository<USER>(context);
                repository.Delete(currentObject.Id);
                ClearView();
            }
            else
            {
                MessageBox.Show("You should select a user first!");
            }

        }

        private void buttonNew_Click(object sender, EventArgs e)
        {
            ClearView();
        }
    }
}
