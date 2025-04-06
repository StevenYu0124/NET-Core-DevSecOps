using System;
using System.Linq;
using NUnit.Framework;
using NetCoreApis.WeatherForecast;
using System.Collections.Generic;

namespace NetCoreApis.WeatherForecast.Tests
{
    [TestFixture]
    public class WeatherForecastControllerTest
    {
        [Test]
        public void Get_ReturnsExpectedNumberOfForecasts()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.That(result, Is.Not.Null); // Ensure the result is not null
            var forecasts = result.ToArray();
            Assert.That(forecasts, Has.Length.EqualTo(5)); // Ensure 5 forecasts are returned
        }

        [Test]
        public void Get_ReturnsForecastsWithValidTemperatureRange()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            foreach (var forecast in result)
            {
                Assert.That(forecast.TemperatureC, Is.InRange(-20, 55)); // Temperature should be within the expected range
            }
        }

        [Test]
        public void Get_ReturnsForecastsWithValidSummaries()
        {
            // Arrange
            var controller = new WeatherForecastController();
            var validSummaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            // Act
            var result = controller.Get();

            // Assert
            Assert.NotNull(result);
            foreach (var forecast in result)
            {
                Assert.Contains(forecast.Summary, validSummaries); // Summary should be one of the predefined values
            }
        }

        [Test]
        public void Get_ReturnsForecastsWithFutureDates()
        {
            // Arrange
            var controller = new WeatherForecastController();

            // Act
            var result = controller.Get();

            // Assert
            Assert.That(result, Is.Not.Null);
            foreach (var forecast in result)
            {
                Assert.That(forecast.Date, Is.GreaterThan(DateOnly.FromDateTime(DateTime.Now))); // Date should be in the future
            }
        }
    }
}