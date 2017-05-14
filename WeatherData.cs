using System;

namespace WeatherApp
{
    public abstract class WeatherData
    {
        const double Kelvin = 273.15;
        private Location location;

        public Location Location
        {
            get { return location; }
            set { location = value; }
        }

        public WeatherData()
        {
            this.location = new Location(null);
        }

        public double CelciusToFahrenheit(double Celsius)
        {                           // Convertion from Celsius to Fahrenheit and limiting to only 3 digits
            return ((double)((int)(((Celsius * 1.8) + 32) * 1000.0))) / 1000.0;     // after the decimal point
        }

        public void PrintToScreen()
        {    // Used to display all attributes received from the weather service
            double TemperatureCelsius = Convert.ToDouble(location.Temperature) - Kelvin;
            double TemperatureCelsiusMax = Convert.ToDouble(location.TemperatureMax) - Kelvin;
            double TemperatureCelsiusMin = Convert.ToDouble(location.TemperatureMin) - Kelvin;
            for (int i = 0; i < 35; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
            Console.WriteLine("The Weather Forecast At:  " + location.City + ", " + Location.Country + ":");
            for (int i = 0; i < 35; i++)
            {
                Console.Write("-");
            }
            Console.WriteLine();
            Console.WriteLine("Current temperatue is: " + TemperatureCelsius + " ℃" + "   |  " + CelciusToFahrenheit(TemperatureCelsius) + " °F");
            Console.WriteLine("The temperature will reach its maximum at: " + TemperatureCelsiusMax + " ℃\t|  " + CelciusToFahrenheit(TemperatureCelsiusMax) + " °F");
            Console.WriteLine("The temperature will reach its minimum at: " + TemperatureCelsiusMin + " ℃\t|  " + CelciusToFahrenheit(TemperatureCelsiusMin) + " °F");
            Console.WriteLine("Sunrise will be at: " + Location.Sunrise + " UTC");
            Console.WriteLine("Sunset will be at: " + Location.Sunset + " UTC");
            Console.WriteLine("Clouds current status: " + Location.Cloud);
            Console.WriteLine("Wind Speed: " + Location.Wind + " KM/H, feels " + Location.WindDesc + ", heading Towards " + Location.WindDir + ".");
            Console.WriteLine("Humidity: " + Location.Humidity + "%");
            Console.WriteLine("Pressure: " + Location.Pressure + "%");
            Console.WriteLine("Last update was received at " + Location.Lastupdate + " UTC");
            for (int i = 0; i < 35; i++)
            {
                Console.Write("=");
            }
            Console.WriteLine();
        }
    }
}