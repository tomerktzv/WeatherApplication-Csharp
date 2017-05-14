using System;

namespace WeatherApp
{
    // Abstract Factory pattern that will be used in order to create a weather service
    //public const String OTHER_WEATHER_SOURCE = "OTHER_WEATHER_SOURCE";

    public abstract class WeatherDataServiceFactory : WeatherData, IWeatherDataService
    {
        public const String OPEN_WEATHER_MAP = "OPEN_WEATHER_MAP";
        public static WeatherDataServiceFactory getWeatherDataService(String Source)
        {
            try
            {
                if (Source.Equals(OPEN_WEATHER_MAP)) return WeatherMap.Instance();
                else throw new WeatherDataException("Invalid Weather Service!");
            }
            finally { }
        }
        virtual public WeatherDataServiceFactory getWeatherData(Location location) { return null; }
    }
}