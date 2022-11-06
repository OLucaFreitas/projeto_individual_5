using GoodTravel.Model;
using Microsoft.EntityFrameworkCore;

namespace GoodTravel.Data
{
    public class DataContext : DbContext
    {


       


        protected readonly IConfiguration _configuration;
  

        public DataContext(IConfiguration configuration)
        {
            _configuration = configuration;
            
 
        }

     

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = _configuration.GetConnectionString("DefaultConnection");
            optionsBuilder.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));

        }


        public DbSet<Promocao> Promocoes { get; set; }

        public DbSet<Destino> Destinos { get; set; }



    }
}
