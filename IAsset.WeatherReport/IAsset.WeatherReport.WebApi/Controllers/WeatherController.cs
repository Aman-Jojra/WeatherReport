using IAsset.WeatherReport.WebApi.ExternalProxies;
using IAsset.WeatherReport.WebApi.Framework;
using IAsset.WeatherReport.WebApi.Results;
using System.Linq;
using System.Web.Http;

namespace IAsset.WeatherReport.WebApi.Controllers
{
    public class WeatherController : ApiController
    {
        private IGlobalWeatherSoapClient _globalWeatherSoapClient;
        public WeatherController(IGlobalWeatherSoapClient globalWeatherSoapClient)
        {
            _globalWeatherSoapClient = globalWeatherSoapClient;
        }

        // GET weather/countries/US/cities
        [Route("~/weather/countries/{countryName}/cities")]
        public IHttpActionResult GetCitiesByCountry(string countryName)
        {
            var cities = _globalWeatherSoapClient.GetCitiesByCountry(countryName);
            var response = Helper.XMLDeserialize<NewDataSet>(cities);
            if (response != null && response.Items != null && response.Items.Any())
            {
                return Ok(response.Items.Select(i => i.City));
            }
            return NotFound();
        }

        // GET weather/cities/Indore/countries/India     
        [Route("~/weather/cities/{cityName}/countries/{countryName}")]
        public IHttpActionResult GetWeather(string cityName, string countryName)
        {
            var weather = _globalWeatherSoapClient.GetWeather(cityName, countryName);
            CurrentWeather weatherResponse = Helper.XMLDeserialize<CurrentWeather>(weather);
            if (weatherResponse != null)
            {
                return Ok(weatherResponse);
            }

            return NotFound();
        }
    }
}
