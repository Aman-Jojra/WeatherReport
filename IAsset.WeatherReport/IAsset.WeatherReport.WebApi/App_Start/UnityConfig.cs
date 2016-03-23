using IAsset.WeatherReport.WebApi.ExternalProxies;
using Microsoft.Practices.Unity;
using System.Web.Http;
using Unity.WebApi;

namespace IAsset.WeatherReport.WebApi
{
    public static class UnityConfig
    {
        public static void RegisterComponents()
        {
			var container = new UnityContainer();
            container.RegisterType<GlobalWeatherSoapClient>(
                new InjectionFactory(c => new GlobalWeatherSoapClient()));
            container.RegisterType<IGlobalWeatherSoapClient, GlobalWeatherSoapClient>();
            GlobalConfiguration.Configuration.DependencyResolver = new UnityDependencyResolver(container);
        }
    }
}