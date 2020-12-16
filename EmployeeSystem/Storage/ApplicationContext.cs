using Microsoft.EntityFrameworkCore;
using EmployeeSystem.Storage.EFModels;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore;

// using Microsoft.AspNetCore.Identity;
// using Microsoft.AspNetCore.Identity.UI;
// using Microsoft.AspNetCore.Hosting;
namespace EmployeeSystem.Storage
{
    public class ApplicationContext : IdentityDbContext<IdentityUser>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : 
        base(options) {
            // Empty constructor body...
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<Employee> Employee { get; set; }
        public DbSet<Concern> Concern { get; set; }
        public DbSet<Holiday> Holiday { get; set; }
        public DbSet<Leave> Leave { get; set; }

    }
}