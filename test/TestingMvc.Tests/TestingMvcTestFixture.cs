using Microsoft.AspNetCore.Mvc.Testing;

namespace TestingMvc.Tests
{
    public class TestingMvcTestFixture<TStartup> : WebApplicationTestFixture<TStartup> where TStartup : class
    {
        public TestingMvcTestFixture() : base("src/TestingMvc")
        { }
    }
}