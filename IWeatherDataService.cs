
namespace WeatherApp{

    public interface IWeatherDataService{
        WeatherDataServiceFactory getWeatherData(Location location);
    }
}