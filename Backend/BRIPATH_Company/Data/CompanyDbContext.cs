using Microsoft.EntityFrameworkCore;

namespace BRIPATH_Company.Data
{
    public class CompanyDbContext : DbContext
    {
        public CompanyDbContext(DbContextOptions<CompanyDbContext> options) : base(options)
        {
        }
    }
}
