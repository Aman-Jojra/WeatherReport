
namespace IAsset.WeatherReport.WebApi.ExternalProxies
{
    public interface IGlobalWeatherSoapClient
    {
        string GetCitiesByCountry(string countryName);
        string GetWeather(string cityName, string countryName);
    }
}
