using Microsoft.EntityFrameworkCore;

namespace ApiAnnan.Models
{
    public class CrowdFundingDbContext : DbContext
    {
        public CrowdFundingDbContext()
        { 

        }
        public CrowdFundingDbContext(DbContextOptions<CrowdFundingDbContext> options)
    : base(options)
        {
            
        }

        public DbSet<AccountRole> AccountRoles { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Donation> Donations { get; set; }

    }
}
