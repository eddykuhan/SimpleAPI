using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAPI.DAL.Models;

namespace SimpleAPI.DAL.Data
{
    public static class DbInitializer
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };
        public static void Initialize(WeatherContext context)
        {
            
            context.Database.EnsureCreated();
            // Look for any Weathers.
            if (context.Weathers.Any())
            {
                return; // DB has been seeded
            }

            var weathers = new List<WeatherForecast>()
            {
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = 54,
                    Summary = "Hot"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = -6,
                    Summary = "Freezing"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = 29,
                    Summary = "Warm"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = 54,
                    Summary = "Balmy"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = 16,
                    Summary = "Chilly"
                },
                new WeatherForecast
                {
                    Date = DateTime.Now,
                    TemperatureC = 80,
                    Summary = "Bracing"
                }
            };

            foreach (var s in weathers)
            {
                context.Weathers.Add(s);
            }
            context.SaveChanges();
        }

    }
}