using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class UserRepository
    {
        public User GetUserById(int id) {
            using (var db = new AppointmentBookEntities())
            {
                var user = db.USERS.FirstOrDefault(x => x.Id == id);
                if (user == null)
                {
                    //user nuk u gjet
                    return null;
                }
                else {

                    return Mapping.Mapping.MappUser(user);
                }
            }
        }
    }
}
