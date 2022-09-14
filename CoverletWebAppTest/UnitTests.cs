using Xunit;
using CoverletWebApp;
using CoverletWebApp.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Moq;

namespace CoverletWebAppTest
{
    public class UnitTests
    {
        [Fact]
        public void TemperatureTest()
        {
            var w = new WeatherForecast();
            w.TemperatureC = 0;
            Assert.Equal(32, w.TemperatureF);
        }

        [Fact]
        public void TemperatureControllerTest()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var c = new WeatherForecastController(logger.Object);
            Assert.NotEmpty(c.Get());
        }

        [Fact]
        public async void LoginTest()
        {
            var logger = new Mock<ILogger<WeatherForecastController>>();
            var c = new WeatherForecastController(logger.Object);
            var res = await c.Login("hello");
            Assert.True(res is OkResult);
        }

        [Fact]
        public void ToolsTest()
        {
            Assert.NotEmpty(new CoverletTestTools.FileSystem().GetFileInfosInDirectory("Files", SearchOption.AllDirectories));
        }
    }
}