using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Portal.API.Data;
using Portal.API.Models;

namespace Portal.API.Data
{
    public class BaseRepository : IBaseRepository
    {
        private readonly DataContext context;

        public BaseRepository(DataContext context)
        {
            this.context = context;
        }

        public void Add<T>(T entity) where T : class
        {
            context.Add(entity);
        }

        public void Delete<T>(T entity) where T : class
        {
            context.Remove(entity);
        }

        public async Task<User> GetUser(int userId)
        {
            var user = await context.Users.Include(c=>c.UserRoles).FirstOrDefaultAsync(u=>u.UserId == userId);
            return user;
        }

        public async Task<IEnumerable<User>> GetUsers()
        {
            var user = await context.Users.Include(c=>c.UserRoles).ToListAsync();
            return user;
        }

        public async Task<bool> SaveAll()
        {
            return await context.SaveChangesAsync() > 0;
        }
    }
}