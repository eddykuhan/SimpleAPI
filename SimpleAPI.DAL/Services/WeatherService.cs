using SimpleAPI.DAL.Models;
using SimpleAPI.DAL.Repositories.Interfaces;
using SimpleAPI.DAL.Services.Interfaces;

namespace SimpleAPI.DAL.Services
{
    public class WeatherService:IWeatherService
    {
        private readonly IWeatherRepository _weatherRepository;
        public WeatherService(IWeatherRepository weatherRepository)
        {
            _weatherRepository = weatherRepository;
        }
        public IEnumerable<WeatherForecast> GetData()
        {
            return _weatherRepository.GetWeatherData();
        }
    }
}
