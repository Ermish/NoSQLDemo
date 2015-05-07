using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using NoSQLDemo.Models;
using NoSQLDemo.Repositories;

namespace NoSQLDemo.DbFactories
{
    public class CouchDbLiteFactory : IRepository
    {
        public List<T> Get<T>(Expression<Func<T, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public UserModel GetUser(Guid id)
        {
            throw new NotImplementedException();
        }

        public bool AddUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUser(UserModel user)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUser(Guid id)
        {
            throw new NotImplementedException();
        }
    }
}