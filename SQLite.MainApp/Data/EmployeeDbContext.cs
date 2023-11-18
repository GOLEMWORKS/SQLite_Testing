using Microsoft.EntityFrameworkCore;

namespace SQLite.MainApp.Data
{
    public class EmployeeDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public EmployeeDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(Configuration.GetConnectionString("DatabaseMain"));
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
