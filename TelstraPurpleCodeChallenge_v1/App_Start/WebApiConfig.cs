using System.Web.Http;

namespace TelstraPurpleCodeChallenge_v1
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "Default",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "CodeChallenge", action = "Token", id = RouteParameter.Optional }
            );
        }
    }
}
