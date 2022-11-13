using Microsoft.EntityFrameworkCore;
using SimpleAPI.DAL.Models;

namespace SimpleAPI.DAL.Data
{
    public class WeatherContext :DbContext
    {

        public WeatherContext(DbContextOptions<WeatherContext> options):base(options)
        {
                
        }

        public DbSet<WeatherForecast> Weathers { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<WeatherForecast>().HasNoKey();

        }

    }
}
