using System;

namespace WeatherApp
{
    class Program
    {
        public delegate void AnonymousPrint(ref IWeatherDataService service1);//Anonymous Method
        public static void Main(string[] args)
        {
            try
            {
                IWeatherDataService Service = WeatherDataServiceFactory.getWeatherDataService(WeatherDataServiceFactory.OPEN_WEATHER_MAP);
                WeatherData weatherData = Service.getWeatherData(new Location("Haifa"));
                AnonymousPrint DisplayServiceName = delegate (ref IWeatherDataService CurrentService)
                {
                    Console.WriteLine("Information Was Received From: " + CurrentService.ToString());

                };
                weatherData.PrintToScreen();
                DisplayServiceName(ref Service);
            }
            catch (WeatherDataException w)
            {
                Console.WriteLine(w.ToString());
            }
            finally
            {
                Console.ReadKey();
            }
        }
    }
}