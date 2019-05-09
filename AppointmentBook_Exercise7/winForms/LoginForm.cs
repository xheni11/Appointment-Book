using AppointmentBook_Exercise7.dataAccess;
using AppointmentBook_Exercise7.winForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointmentBook_Exercise7.model;
namespace AppointmentBook_Exercise7
{
    public partial class LoginForm : Form
    {
        AppointmentContext context = new AppointmentContext();

        public LoginForm()
        {
            InitializeComponent();
        }
        public string Username()
        {
            return textBoxUsername.Text;
        }
        public string Password()
        {
            return textBoxPassword.Text;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Repository<USER> repository = new Repository<USER>(context);
            
            if (string.IsNullOrWhiteSpace(Username())|| string.IsNullOrWhiteSpace(Password()))
            {
                MessageBox.Show("Please fill the fields!");
            }
            else
            {
                USER user= repository.GetByUsernameAndPassword(Username(),Password());

                if (user != null)
                {
                    SessionContext.Instance.OnLogIn(user);
                    Redirect(user.IdRole);
                } 
            }
        }
        private void Redirect(int role)
        {
            Repository<T> repository = new Repository<T>(context);
            var idRoleManager = repository.GetAllRoles().Where(r => r.Name == "Manager").Select(r => r.Id);
            foreach (var id in idRoleManager)
            {
                if (id==role)
            
                RedirectToManagerForm();

            }
            var idRoleUser = repository.GetAllRoles().Where(r => r.Name == "User").Select(r => r.Id);
            foreach (var id in idRoleUser)
            {
                if (id == role)

                    RedirectToUserForm();

            }


        }

        public void RedirectToUserForm()
        {
            UserForm userForm = new UserForm
            {
                MdiParent = MdiParent,
                Dock = DockStyle.Fill
            };
            Hide();
            userForm.Show();

        }
        public void RedirectToManagerForm()
        {
            ManagerForm menagerForm = new ManagerForm
            {
                MdiParent = MdiParent,
                Dock = DockStyle.Fill
            };
            Hide();
            menagerForm.Show();

        }
    }
}
