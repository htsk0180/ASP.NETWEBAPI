using System.Linq;
using System.Web.Http;
using System.Web.Http.Dispatcher;
using OnlineStore.ServiceHost.API.Core;
using OnlineStore.ServiceHost.API.Handlers;

namespace OnlineStore.ServiceHost.API
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            config.MessageHandlers.Add(new ApiResponseHandler());
            config.Services.Replace(typeof(IHttpControllerActivator), new WindsorHttpControllerActivator());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // Xml formatter'a gerek yok.
            var appXmlType = config.Formatters.XmlFormatter.SupportedMediaTypes.FirstOrDefault(t => t.MediaType == "application/xml");
            config.Formatters.XmlFormatter.SupportedMediaTypes.Remove(appXmlType);
        }
    }
}
