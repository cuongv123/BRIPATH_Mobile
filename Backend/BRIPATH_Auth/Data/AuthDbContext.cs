using BRIPATH_Auth.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace BRIPATH_Auth.Data
{
    public class AuthDbContext : DbContext
    {
        public AuthDbContext(DbContextOptions<AuthDbContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Roles> Roles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Unique constraints
            modelBuilder.Entity<Users>()
                .HasIndex(u => u.Username).IsUnique();

            modelBuilder.Entity<Users>()
                .HasIndex(u => u.Email).IsUnique();

            modelBuilder.Entity<Users>()
                .HasIndex(u => u.Phone).IsUnique();

            modelBuilder.Entity<Roles>()
                .HasIndex(r => r.RoleName).IsUnique();

            modelBuilder.Entity<Users>()
                .HasOne(u => u.Role)
                .WithMany(r => r.Users)
                .HasForeignKey(u => u.RoleId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
