using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NoSQLDemo.Models;
using NoSQLDemo.Repositories;

namespace NoSQLDemo
{
    public class Program
    {
        static void Main(string[] args)
        {
            Demo();
        }

        private static void Demo()
        {
            var user = new UserModel
                       {
                           Id = Guid.NewGuid(),
                           FirstName = "John",
                           LastName = "Smith",
                           HomeAddress = new AddressModel()
                                         {
                                          AddressLine1   = "123 Happy Ln.",
                                          AddressLine2 = "",
                                          City = "Charlotte",
                                          State = "NC"
                                         },
                                         Phone = "123-456-7890"
                       };

            SiaqoDbDemo(user);
        }

        public static void SiaqoDbDemo(UserModel user)
        {
            IRepository repo = new SiaqoDbRepository();

            repo.AddUser(user);

            var newUser = repo.GetUser(user.Id);

            newUser.LastName = "NOT SMITH";

            repo.UpdateUser(newUser);

            var updatedUser = repo.GetUser(newUser.Id);

            repo.DeleteUser(updatedUser.Id);
        }
    }
}
