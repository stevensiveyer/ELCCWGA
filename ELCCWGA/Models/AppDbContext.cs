using Microsoft.EntityFrameworkCore;
using ELCCWGA;

namespace ELCCWGA.Models
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public AppDbContext()
        {
            
        }

        string _connectionString = "Server=(localdb)\\MSSQLLocalDB;Database=GolfScores;Trusted_Connection=True;TrustServerCertificate=True;";
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DbConnectionString"));
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<GolfScore> Scores { get; set; }
    }
}
