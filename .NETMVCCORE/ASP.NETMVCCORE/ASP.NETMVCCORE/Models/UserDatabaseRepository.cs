using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETMVCCORE.Models
{
    public class UserDatabaseRepository : IUserRepository
    {
        private readonly ApplicationDbContext context; 
        public UserDatabaseRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return context.Users;
        }
        public User GetUsers(int ID)
        {
            return context.Users.Find(ID);
        }


        public User Add(User user)
        {
            context.Users.Add(user);
            context.SaveChanges();
            return user;
        }
        public User Update(User updateUser)
        {
            var userModifyState = context.Users.Attach(updateUser);
            userModifyState.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return updateUser;
        }

        public User Delete(int ID)
        {
            User userToDelete = context.Users.Find(ID);
            if (userToDelete != null)
            {
                context.Users.Remove(userToDelete);
                context.SaveChanges();
            }
            return userToDelete;
        }

    }
}
