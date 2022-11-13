using System.Threading.Tasks;
using DotNet.Testcontainers.Builders;
using DotNet.Testcontainers.Configurations;
using DotNet.Testcontainers.Containers;

namespace SimpleAPI.IntegrationTests.Containers
{
    public static class IntegrationTestFactory

    {
        private static TestcontainerDatabase _testcontainer;
        public static async Task<TestcontainerDatabase> InitializeAsync()
        {
            _testcontainer = new TestcontainersBuilder<MsSqlTestcontainer>()
                .WithDatabase(new MsSqlTestcontainerConfiguration
                {
                    Password = "P@ssword1",
                    Port = 5160,
                    Database = "TEST"
                })
                .WithImage("mcr.microsoft.com/mssql/server:2019-latest")
                .WithName("IntegrationTestSuite")
                .WithCleanUp(true)
                .Build();

            await _testcontainer.StartAsync();

            return _testcontainer;
        }

        public static async Task DisposeAsync(TestcontainerDatabase containerDatabase) => await containerDatabase.DisposeAsync();
    }
}
