using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Testing;
using Xunit;

namespace TestingMvc.Tests
{
    public class TestingMvcFunctionalTests : IClassFixture<TestingMvcTestFixture<Startup>>
    {
        public TestingMvcFunctionalTests(TestingMvcTestFixture<Startup> fixture)
        {
            Client = fixture.CreateClient(new Uri("https://localhost:44389"));
        }

        public HttpClient Client { get; set; }

        [Fact]
        public async Task GetHomePage()
        {
            //Act
            var response = await Client.GetAsync("/");

            //Assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GetNotExistWillGet404()
        {
            //Act
            var response = await Client.GetAsync("/not-exist");

            //Assert
            Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
        }
    }
}
