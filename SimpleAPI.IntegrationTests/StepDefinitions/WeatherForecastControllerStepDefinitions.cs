using System;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SimpleAPI.IntegrationTests.StepDefinitions
{
    [Binding]
    [Scope(Feature = "WeatherForecastController")]
    public class WeatherForecastControllerStepDefinitions :BaseStepDefinitions
    {
        [When(@"I make a GET  request to ""([^""]*)""")]
        public virtual async Task WhenIMakeAGETRequestTo(string resourceEndPoint)
        {
            _response = await _client.GetAsync(resourceEndPoint);

            var stringResult = await _response.Content.ReadAsStringAsync();
            //_actualfilterModelData = JsonConvert.DeserializeObject<IEnumerable<RegionFilterModel>>(stringResult);
        }

        [Then(@"I should receive below data")]
        public void ThenIShouldReceiveBelowData()
        {
            throw new PendingStepException();
        }
    }
}
