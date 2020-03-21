using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapping
{
    public static class Mapping
    {
        public static User MappUser(USER user) {
            return new User()
            {
                id = user.Id,
                FirstName = user.FirstName,
                LastName = user.LastName
            };
        }
    }
}
