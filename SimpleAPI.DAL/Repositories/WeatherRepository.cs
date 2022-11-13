using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SimpleAPI.DAL.Data;
using SimpleAPI.DAL.Models;
using SimpleAPI.DAL.Repositories.Interfaces;

namespace SimpleAPI.DAL.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        private readonly WeatherContext _weatherContext;
        public WeatherRepository(WeatherContext context)
        {
            _weatherContext = context;
        }
        public IEnumerable<WeatherForecast> GetWeatherData()
        {
            var conn = _weatherContext.Database.GetDbConnection().ConnectionString;
            return _weatherContext.Weathers.ToList();
        }
    }
}
