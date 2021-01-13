using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETMVCCORE.Models
{
    public interface IUserRepository
    {
        User GetUsers(int ID);
        IEnumerable<User> GetAllUsers();

        User Add(User user);
        User Update(User updateUser);
        User Delete(int ID);
    }
}
