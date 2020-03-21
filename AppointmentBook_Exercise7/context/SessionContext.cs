using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppointmentBook_Exercise7
{
    class SessionContext
    {

        private static SessionContext instance;

        public USER CurrentUser { get; set; }

        public bool IsLoggedIn { get; set; }

        private SessionContext() { }

        public static SessionContext Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new SessionContext();
                }
                return instance;
            }
        }

        public void OnLogIn(USER user)
        {
            CurrentUser = user;

            if (user != null)
            {
                IsLoggedIn = true;
            }
            else
            {
                IsLoggedIn = false;
            }
        }

        public void OnLogOut()
        {
            CurrentUser = null;
            IsLoggedIn = false;
        }

    }
}
