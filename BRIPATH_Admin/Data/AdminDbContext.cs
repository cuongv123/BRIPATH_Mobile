using Microsoft.EntityFrameworkCore;

namespace BRIPATH_Admin.Data
{
    public class AdminDbContext : DbContext
    {
        public AdminDbContext(DbContextOptions<AdminDbContext> options) : base(options)
        {
        }
        // Define your DbSets here. Example:
        // public DbSet<User> Users { get; set; }
    }
}
