using System;

namespace WeatherApp{
    public class WeatherDataException : ApplicationException{
        public WeatherDataException(String message) : base(message){
            Console.WriteLine(message);
        }
    }
}