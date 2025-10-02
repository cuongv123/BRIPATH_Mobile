using Microsoft.EntityFrameworkCore;

namespace BRIPATH_User.Data
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> options) : base(options)
        {
        }
        // Define your DbSets here. For example:
        // public DbSet<User> Users { get; set; }
    }
}
