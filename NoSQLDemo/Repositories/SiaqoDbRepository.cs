using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using NoSQLDemo.DbFactories;
using NoSQLDemo.Models;

namespace NoSQLDemo.Repositories
{
    public class SiaqoDbRepository : IRepository
    {
        public UserModel GetUser(Guid id)
        {
            var db = SiaqoDbFactory.GetInstance();

            var user = db.Query<UserModel>().SqoFirstOrDefault(x => x.Id == id);

            return user;
        }

        public List<T> Get<T>(Expression<Func<T, bool>> predicate)
        {
            var db = SiaqoDbFactory.GetInstance();

            var users = db.Query<T>().SqoWhere(predicate).ToList();

            return users;
        }

        public bool AddUser(UserModel user)
        {
            try
            {
                var db = SiaqoDbFactory.GetInstance();

                db.StoreObject(user);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool UpdateUser(UserModel user)
        {
            try
            {
                var db = SiaqoDbFactory.GetInstance();

                db.StoreObject(user);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool DeleteUser(Guid id)
        {
            try
            {
                var db = SiaqoDbFactory.GetInstance();

                db.DeleteObjectBy("_id", id);

                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }
}