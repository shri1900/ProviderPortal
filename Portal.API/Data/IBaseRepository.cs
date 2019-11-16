﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Portal.API.Models;

namespace Portal.API.Data
{
    public interface IBaseRepository
    {
         void Add<T>(T entity) where T: class;
         void Delete<T>(T entity) where T: class;
         Task<bool> SaveAll();
         Task<IEnumerable<User>> GetUsers();
         Task<User> GetUser(int userId);
    }
}