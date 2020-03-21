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
    public partial class ManageLocationsForm : Form
    {
        int id;
        public ManageLocationsForm()
        {
            InitializeComponent();
        }
        private string NameL()
        {
            return textBoxName.Text;
        }
        private string Description()
        {
            return textBoxDescription.Text;
        }

        private void ManageLocationsForm_Load(object sender, EventArgs e)
        {
            AppointmentContext context = new AppointmentContext();
            Repository<LOCATION> repository = new Repository<LOCATION>(context);
            
            bindingSourceLocation.DataSource = repository.GetAllLocations();
            
        }
        private LOCATION CreateNewLocation()
        {
            return new LOCATION
            {
                Name = this.NameL(),
                Description = this.Description()

            };
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            LOCATION location = CreateNewLocation();

            AppointmentContext context = new AppointmentContext();
            Repository<LOCATION> repository = new Repository<LOCATION>(context);
            if (id > 0)
            {
                location.Id = id;
                repository.Update(location);
            }
            else
            {
                repository.Insert(location);
            }
            ClearView();
        }
        private void ClearView()
        {
            id = 0;
            textBoxName.Text = "";
            textBoxDescription.Text = "";

            AppointmentContext context = new AppointmentContext();
            Repository<LOCATION> repository = new Repository<LOCATION>(context);
            bindingSourceLocation.DataSource = repository.GetAllLocations();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            LOCATION currentObject = (LOCATION)dataGridView1.CurrentRow.DataBoundItem;

            textBoxName.Text = currentObject.Name;
            textBoxDescription.Text = currentObject.Description;
            id = currentObject.Id;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            LOCATION currentObject = (LOCATION)dataGridView1.CurrentRow.DataBoundItem;
            if (id != 0)
            {
                AppointmentContext context = new AppointmentContext();
                Repository<LOCATION> repository = new Repository<LOCATION>(context);
                repository.Delete(id);
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
