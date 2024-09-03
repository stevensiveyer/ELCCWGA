using Microsoft.EntityFrameworkCore;

namespace ELCCWGA.Models
{
    public class ScheduleDbContext :DbContext
    {
        protected readonly IConfiguration Configuration;

        public ScheduleDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public ScheduleDbContext()
        { 
            
        }
        
        string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=ScheduleItems;Trusted_Connection=True;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<ScheduleItem> ScheduleItems { get; set; }
    }
}
