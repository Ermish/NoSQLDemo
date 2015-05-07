using System;

namespace NoSQLDemo.Models
{
    public class UserModel
    {
        public UserModel()
        {
            
        }


        public Guid Id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }

        public AddressModel HomeAddress { get; set; }
    }
}