using Microsoft.EntityFrameworkCore;
using SimpleAPI.DAL.Data;
using SimpleAPI.DAL.Repositories;
using SimpleAPI.DAL.Repositories.Interfaces;
using SimpleAPI.DAL.Services;
using SimpleAPI.DAL.Services.Interfaces;

namespace SimpleAPI.Services
{
    public static class ServicesExt
    {
        public static void UseServicesExt(this WebApplicationBuilder builder, IConfiguration configuration)
        {
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<WeatherContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            builder.Services.AddScoped<IWeatherRepository, WeatherRepository>();
            builder.Services.AddScoped<IWeatherService, WeatherService>();

        }
    }
}
