using SimpleAPI.Builders;
using SimpleAPI.Services;

var builder = WebApplication.CreateBuilder(args);

var webHost = builder.WebHost;

webHost.ConfigureAppConfiguration((builderContext, configBuilder) =>
{
    configBuilder
        .AddEnvironmentVariables()
        .AddJsonFile(
            Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "appsettings.json"));

});

// Add services to the container.
builder.UseServicesExt(builder.Configuration);

var app = builder.Build();


app.UseSwaggerExt();

app.UseHttpsRedirection();

app.UseAuthorization();
    
app.MapControllers();

app.CreateDbIfNotExists();

app.Run();

public partial class Program { }


