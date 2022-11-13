using DotNet.Testcontainers.Containers;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.Configuration;
using System;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SimpleAPI.DAL.Data;

namespace SimpleAPI.IntegrationTests.Helpers
{
    public static class TestHelper
    {
      
        public static WebApplicationFactory<Program> GetWebApplicationFactory()
        {

            return new WebApplicationFactory<Program>()
                .WithWebHostBuilder(builder =>
                {
                    var _configuration = new ConfigurationBuilder()
                        .AddJsonFile("specflow.json")
                        .Build();

                    builder.ConfigureTestServices(services =>
                        {

                            //services.Configure(configurationSection);

                            //services.AddAuthentication("Test")
                            //    .AddScheme<AuthenticationSchemeOptions, TestAuthHandler>("Test", null);
                            //services.AddAuthorization(configure =>
                            //{
                            //    var authorizationPolicyBuilderbuilder = new AuthorizationPolicyBuilder(new List<string> { "Test" }.ToArray())
                            //        .AddRequirements(new DenyAnonymousAuthorizationRequirement());

                            //    configure.DefaultPolicy = authorizationPolicyBuilderbuilder.Build();
                            //    services.AddControllers();

                            //});
                            //var conn = _configuration.GetConnectionString("DefaultConnection");
                            //services.AddDbContext<WeatherContext>(options =>
                            //    options.UseSqlServer(conn));

                        }
                       
                    );
           
                });
        }



        //public static async Task ExecuteDbScripts(TestcontainerDatabase containerDatabase)
        //{
        //    var fileArray = Directory.GetFiles(@"Schemas", "*.sql");
        //    foreach (var sql in fileArray)
        //    {
        //        var cmdText = File.ReadAllText(sql);
        //        await using (var connection =
        //                     new SqlConnection($"{containerDatabase.ConnectionString}TrustServerCertificate=True;"))
        //        {
        //            connection.Open();

        //            await using (var cmd = new SqlCommand())
        //            {
        //                cmd.Connection = connection;
        //                cmd.CommandText = cmdText;
        //                cmd.ExecuteNonQuery();
        //            }
        //        }
        //    }




        //}

    }

}
