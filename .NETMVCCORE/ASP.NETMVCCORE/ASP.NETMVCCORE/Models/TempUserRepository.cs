using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETMVCCORE.Models
{
    public class TempUserRepository :IUserRepository
    {
        private List<User> usersList;

        public TempUserRepository()
        {
            usersList = new List<User>()
            {
                new User(){
                ID= 1,
                Name="Harry",
                DOB= DateTime.Now,
                Gender=Gender.Male,
                Email="a@gmail.com",
                MobileNo="07716628264",
                Address="10 HighBury Lane",
                PostCode = "Se3 3ep",
                LocationOfWork="Canary Wharf, London",
                Biography="I am kind of a genius",
                KeyWordsForSkill="Entrepeneur",
                Category= SportsCategory.Football
                },
                new User(){
                ID= 2,
                Name="Mike",
                DOB= DateTime.Now,
                Gender=Gender.Male,
                Email="b@gmail.com",
                MobileNo="07716623324",
                Address="10 Farnharm Road",
                PostCode = "Se4 5ep",
                LocationOfWork="Liverpool Street, London",
                Biography="I am a good learner",
                KeyWordsForSkill="Senior Manager",
                Category= SportsCategory.Basketball
                },
                new User(){
                ID= 3,
                Name="Felisha",
                DOB= DateTime.Now,
                Gender=Gender.Female,
                Email="n@gmail.com",
                MobileNo="07326623324",
                Address="30 melvin Road",
                PostCode= "SW3 7WL",
                LocationOfWork="Kensington Road, London",
                Biography="I am a good performer",
                KeyWordsForSkill="Guitarist",
                Category= SportsCategory.Cricket
                },
                new User(){
                ID= 4,
                Name="Mary",
                DOB= DateTime.Now,
                Gender=Gender.Female,
                Email="m@gmail.com",
                MobileNo="07116623324",
                Address="30 Avenue Street",
                PostCode= "NW3 31M",
                LocationOfWork="GreenField Lane, Norwich",
                Biography="I live in Norwich and I work as a chef in the five star hotel",
                KeyWordsForSkill="Chef",
                Category= SportsCategory.Swimming
                },
                new User(){
                ID= 5,
                Name="Mary",
                DOB= DateTime.Now,
                Gender=Gender.Female,
                Email="m@gmail.com",
                MobileNo="07116623324",
                Address="30 Avenue Street",
                PostCode="NW3 31M",
                LocationOfWork="GreenField Lane, Norwich",
                Biography="I live in Norwich and I work as a chef",
                KeyWordsForSkill="Chef",
                Category= SportsCategory.Rugby
                },
                new User(){
                ID= 6,
                Name="Mary",
                DOB= DateTime.Now,
                Gender=Gender.Female,
                Email="m@gmail.com",
                MobileNo="07116623324",
                Address="30 Avenue Street",
                PostCode="NW3 31M",
                LocationOfWork="GreenField Lane, Norwich",
                Biography="I live in Norwich and I work as a chef",
                KeyWordsForSkill="Chef",
                Category= SportsCategory.Tennis
                }
            };

        }

        //Get All Users
        public IEnumerable<User> GetAllUsers()
        {
            return usersList;
        }

        //Get UsersByID
        public User GetUsers(int ID)
        {
            return usersList.FirstOrDefault(x=>x.ID == ID);
        }

        //Add Users (Admin Functionality)
        public User Add(User user)
        {
            user.ID = usersList.Max(x => x.ID) + 1;
            usersList.Add(user);
            return user;
        }

        public User Update(User updateUser)
        {
            User userToUpdate = usersList.FirstOrDefault(x => x.ID == updateUser.ID);
            if (userToUpdate != null)
            {
                userToUpdate.Name = updateUser.Name;
                userToUpdate.DOB = updateUser.DOB;
                userToUpdate.Gender = updateUser.Gender;
                userToUpdate.Email = updateUser.Email;
                userToUpdate.MobileNo = updateUser.MobileNo;
                userToUpdate.Address = updateUser.Address;
                userToUpdate.PostCode = updateUser.PostCode;
                userToUpdate.LocationOfWork = updateUser.LocationOfWork;
                userToUpdate.Biography = updateUser.Biography;
                userToUpdate.KeyWordsForSkill = updateUser.KeyWordsForSkill;
                userToUpdate.Category = updateUser.Category;
            }
            return userToUpdate;
        }

        public User Delete(int ID)
        {
            User userToDelete = usersList.FirstOrDefault(x => x.ID == ID);
            if (userToDelete != null)
            {
                usersList.Remove(userToDelete);
            }
            return userToDelete;
        }
    }
}
