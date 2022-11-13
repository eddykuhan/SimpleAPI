using System.ComponentModel.DataAnnotations.Schema;

namespace SimpleAPI.DAL.Models
{
    [Table("Weathers")]
    public class WeatherForecast
    {
        public int WeatherForecastId { get; set; }
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }
        
        public string? Summary { get; set; }
    }
}