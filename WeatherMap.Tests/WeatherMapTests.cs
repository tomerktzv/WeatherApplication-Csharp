using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
namespace WeatherApp.Tests
{
    [TestClass]
    public class WeatherMapTests
    {
        [TestMethod]
        public void getWeatherDataTest()
        {
            Location location = new Location("London");
            IWeatherDataService service = WeatherDataServiceFactory.getWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);
            WeatherData weatherData = service.getWeatherData(new Location("London"));
            Assert.AreEqual(weatherData.Location.City, location.City);
        }

        [TestMethod]
        public void getWeatherDataServiceTest()
        {
            String BadValue = "OPEN_WEATHER_MAP_False", GoodValue = "OPEN_WEATHER_MAP", TestingValue;
            try
            { 
                WeatherDataServiceFactory service = WeatherDataServiceFactory.getWeatherDataService(BadValue);
                TestingValue = GoodValue;
            }
            catch(WeatherDataException e)
            {
                TestingValue = BadValue;
            }
            Assert.AreEqual(BadValue, TestingValue);
        }

    }
}