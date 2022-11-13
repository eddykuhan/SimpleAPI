using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SimpleAPI.DAL.Models;

namespace SimpleAPI.DAL.Services.Interfaces
{
    public interface IWeatherService
    {
        IEnumerable<WeatherForecast> GetData();
    }
}
