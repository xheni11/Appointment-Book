using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppointmentBook_Exercise7.dataAccess;
namespace AppointmentBook_Exercise7
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //AppointmentContext context = new AppointmentContext();
            //USER user = new USER
            //{
            //    //Id = 1,
            //    FirstName = "Redi",
            //    LastName = "Canaj",
            //    Username = "red",
            //    Password = "123",
            //    IdRole = 1
            //};
            //Repository<USER> repository = new Repository<USER>(context);
            //repository.Insert(user);
            //context.USERS.Attach(user);
            //context.Entry(user).State = System.Data.Entity.EntityState.Modified;
            //context.SaveChanges();

            //AppointmentContext context = new AppointmentContext();
            //Repository<USER> repository = new Repository<USER>(context);
            //IEnumerable<USER> users = context.USERS.ToList();
            Application.Run(new LoginForm());
        }
    }
}
