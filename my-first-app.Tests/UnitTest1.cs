using System;
using Xunit;
using Microsoft.Extensions.Logging.Abstractions;

namespace Samples.WeatherForecast.Api.UnitTest
{
    public class WeatherForecastControllerTests
    {
        [Fact]
        public void ShouldReturnAListOfValues()
        {
            // Arrange
            var logger = new NullLogger<myfirstapp.Controllers.WeatherForecastController>();
            var service = new myfirstapp.Controllers.WeatherForecastController(logger);

            // Act
            var result = service.Get();

            // Assert
            Assert.NotNull(result);
        }
    }
}
