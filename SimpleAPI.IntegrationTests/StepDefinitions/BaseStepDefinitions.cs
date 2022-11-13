using FluentAssertions;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SimpleAPI.IntegrationTests.Helpers;
using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using TechTalk.SpecFlow;

namespace SimpleAPI.IntegrationTests.StepDefinitions
{
    public abstract class BaseStepDefinitions
    {
        protected HttpClient _client { get; set; }
        protected HttpResponseMessage _response { get; set; }
        protected WebApplicationFactory<Program> webApplicationFactory;

        private const string BaseAddress = "http://localhost/";

        protected BaseStepDefinitions()
        {
            webApplicationFactory = TestHelper.GetWebApplicationFactory();

        }

        [Given(@"I am a caller of this API")]
        public virtual void GivenIAmACallerOfThisAPI()
        {
            _client = webApplicationFactory.CreateDefaultClient(new Uri(BaseAddress));
            _client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Test");

        }
        [Then(@"the response status code is ""([^""]*)""")]
        public virtual void ThenTheResponseStatusCodeIs(HttpStatusCode statusCode)
        {
            _response.StatusCode.Should().Be(statusCode);
        }
        [Then(@"the response status code is not ""([^""]*)""")]
        public void ThenTheResponseStatusCodeIsNot(HttpStatusCode statusCode)
        {

            _response.StatusCode.Should().NotBe(statusCode);
        }

        [Then(@"the SuccessStatusCode is ""([^""]*)""")]
        public void ThenTheSuccessStatusCodeIs(bool expectedSuccessCode)
        {
            Assert.AreEqual(expectedSuccessCode, _response.IsSuccessStatusCode);
        }



    }
}
