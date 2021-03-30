using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp.Models.Services
{
    public class SecurityService
    {
        UsersDAO usersDAO = new UsersDAO();


        public bool IsValid(UserModel user)
        {
            return usersDAO.findUserByNameAndPassword(user);

        }
    }
}
