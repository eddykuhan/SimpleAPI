using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAPI.DAL.Models;

namespace SimpleAPI.DAL.Repositories.Interfaces
{
    public interface IWeatherRepository
    {

        IEnumerable<WeatherForecast> GetWeatherData();
    }
}
