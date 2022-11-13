using DotNet.Testcontainers.Containers;
using SimpleAPI.IntegrationTests.Containers;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SimpleAPI.IntegrationTests.Hooks
{
    [Binding]
    public class SpecflowHooks
    {
        private static TestcontainerDatabase _containerDatabase;
        [BeforeTestRun()]
        public static async Task InitializeTestBed()
        {
            //create docker container 
             _containerDatabase = await IntegrationTestFactory.InitializeAsync();
            //execute sql scheamas in created container
            //await TestHelper.ExecuteDbScripts(_containerDatabase);

        }

        [AfterTestRun()]
        public static async Task Dispose()
        {
            await IntegrationTestFactory.DisposeAsync(_containerDatabase);
        }
    }
}
