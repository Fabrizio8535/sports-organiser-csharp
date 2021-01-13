using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NETMVCCORE.Models
{
    public static class ExtensionForModel
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<User>().HasData(
                new User()
                {
                    ID = 1,
                    Name = "Harry",
                    DOB = DateTime.Now,
                    Gender = Gender.Male,
                    Email = "a@gmail.com",
                    MobileNo = "07716628264",
                    Address = "10 HighBury Lane",
                    PostCode = "Se3 3ep",
                    LocationOfWork = "Canary Wharf, London",
                    Biography = "I am kind of a genius",
                    KeyWordsForSkill = "Entrepeneur",
                    Category = SportsCategory.Football
                },
                new User()
                {
                    ID = 2,
                    Name = "Mike",
                    DOB = DateTime.Now,
                    Gender = Gender.Male,
                    Email = "b@gmail.com",
                    MobileNo = "07716623324",
                    Address = "10 Farnharm Road",
                    PostCode = "Se4 5ep",
                    LocationOfWork = "Liverpool Street, London",
                    Biography = "I am a good learner",
                    KeyWordsForSkill = "Senior Manager",
                    Category = SportsCategory.Basketball
                },
                new User()
                {
                    ID = 3,
                    Name = "Felisha",
                    DOB = DateTime.Now,
                    Gender = Gender.Female,
                    Email = "n@gmail.com",
                    MobileNo = "07326623324",
                    Address = "30 melvin Road",
                    PostCode = "SW3 7WL",
                    LocationOfWork = "Kensington Road, London",
                    Biography = "I am a good performer",
                    KeyWordsForSkill = "Guitarist",
                    Category = SportsCategory.Cricket
                },
                new User()
                {
                    ID = 4,
                    Name = "Mary",
                    DOB = DateTime.Now,
                    Gender = Gender.Female,
                    Email = "m@gmail.com",
                    MobileNo = "07116623324",
                    Address = "30 Avenue Street",
                    PostCode = "NW3 31M",
                    LocationOfWork = "GreenField Lane, Norwich",
                    Biography = "I live in Norwich and I work as a chef in the five star hotel",
                    KeyWordsForSkill = "Chef",
                    Category = SportsCategory.Swimming
                }
                );
        }
    }
}
