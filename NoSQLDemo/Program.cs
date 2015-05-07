using System;
using NoSQLDemo.Models;
using NoSQLDemo.Repositories;

namespace NoSQLDemo
{
    public class Program
    {
        private static void Main(string[] args)
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
                                             AddressLine1 = "123 Happy Ln.",
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

            var user2 = user;


            user2.FirstName = "Bob";
            user2.Id = Guid.NewGuid();

            repo.AddUser(user2);

            var newUser = repo.GetUser(user.Id);
            var newUser2 = repo.GetUser(user2.Id);

            var filteredUser = repo.Get<UserModel>(x => x.FirstName.Contains("Bo"));

            newUser.LastName = "NOT SMITH";

            repo.UpdateUser(newUser);

            var updatedUser = repo.GetUser(newUser.Id);

            repo.DeleteUser(updatedUser.Id);
        }
    }
}