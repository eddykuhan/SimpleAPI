using Microsoft.AspNetCore.Mvc;
using SimpleAPI.DAL.Models;
using SimpleAPI.DAL.Services.Interfaces;

namespace SimpleAPI.Controllers
{
    [ApiController]
    [Route("/v1")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private  readonly  IWeatherService _weatherService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherService  weatherService)
        {
            _logger = logger;
            _weatherService = weatherService;
        }

        [HttpGet("weatherforecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return _weatherService.GetData();
        }
    }
}