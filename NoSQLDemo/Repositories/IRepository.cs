using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NoSQLDemo.Models;

namespace NoSQLDemo.Repositories
{
    public interface IRepository
    {
        UserModel GetUser(Guid id);
        List<T> Get<T>(Expression<Func<T, bool>> predicate);
        bool AddUser(UserModel user);
        bool UpdateUser(UserModel user);
        bool DeleteUser(Guid id);
    }
}