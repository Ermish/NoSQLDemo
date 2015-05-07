using System;
using NoSQLDemo.Models;

namespace NoSQLDemo.Repositories
{
    public interface IRepository
    {
        UserModel GetUser(Guid id);
        bool AddUser(UserModel user);
        bool UpdateUser(UserModel user);
        bool DeleteUser(Guid id);
    }
}