using System.Web.Mvc;
using System.Web.Routing;

namespace TelstraPurpleCodeChallenge_v1
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "DefaultAPI",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "CodeChallenge", action = "Token", id = UrlParameter.Optional }
            );
        }
    }
}
