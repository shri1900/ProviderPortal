using Portal.Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Portal.Api.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options): base(options){ }

        public DbSet<Value> Value { get; set; }
        public DbSet<User> Users { get; set; }
    }
}