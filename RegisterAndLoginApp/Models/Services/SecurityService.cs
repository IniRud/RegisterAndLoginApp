using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegisterAndLoginApp.Models.Services
{
    public class SecurityService
    {
        List<UserModel> knownUsers = new List<UserModel>();

        public SecurityService()
        {
            knownUsers.Add(new UserModel { Id = 0, UserName = "rene", Password = "dove" });
            knownUsers.Add(new UserModel { Id = 1, UserName = "laila", Password = "real" });
            knownUsers.Add(new UserModel { Id = 2, UserName = "flora", Password = "calg"});
            knownUsers.Add(new UserModel { Id = 3, UserName = "biggy", Password = "reps" });
        }

        public bool IsValid(UserModel user)
        {
            // return true with C# keyword ANY()
            return knownUsers.Any(x => x.UserName == user.UserName && x.Password == user.Password);
        }
    }
}
