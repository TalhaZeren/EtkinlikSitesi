using EtkinlikProjesi.Models.Concrete;
using Microsoft.EntityFrameworkCore;

namespace EtkinlikProjesi.Data
{
    public class ApplicationDbContext :DbContext
    {
        protected readonly IConfiguration Configuration;

        public ApplicationDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // Connect to postgres with connection String from App Setting.
            options.UseNpgsql(Configuration.GetConnectionString("WebApiDatabase"));

        }
        public DbSet<User> User { get; set; }

    }
}
