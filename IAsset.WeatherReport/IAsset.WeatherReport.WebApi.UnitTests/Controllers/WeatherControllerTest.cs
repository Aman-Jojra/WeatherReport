using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using IAsset.WeatherReport.WebApi.ExternalProxies;
using IAsset.WeatherReport.WebApi.Controllers;
using IAsset.WeatherReport.WebApi.UnitTests.MockData;

namespace IAsset.WeatherReport.WebApi.UnitTests.Controllers
{
    [TestClass]
    public class WeatherControllerTest
    {
        
        [TestMethod]
        public void TestGetCitiesByCountry()
        {
            var globalWeatherSoapClient = new Mock<IGlobalWeatherSoapClient>();
            globalWeatherSoapClient.Setup(am => am.GetCitiesByCountry(It.IsAny<string>())).Returns(ListOfCities.citiesList);

            WeatherController controller = new WeatherController(globalWeatherSoapClient.Object);
            var response = controller.GetCitiesByCountry("Mali");
            Assert.IsNotNull(response);
            //more detailed asserts can be written here
        }

        [TestMethod]
        public void TestGetWeather()
        {
            var globalWeatherSoapClient = new Mock<IGlobalWeatherSoapClient>();
            globalWeatherSoapClient.Setup(am => am.GetWeather(It.IsAny<string>(), It.IsAny<string>())).Returns(ListOfCities.weatherDetails);

            WeatherController controller = new WeatherController(globalWeatherSoapClient.Object);
            var response = controller.GetWeather("Mali", "Gao");
            Assert.IsNotNull(response);
            //more detailed asserts can be written here
        }
    }
}
