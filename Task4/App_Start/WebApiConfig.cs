using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace Task4
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            // New code, added by JingHui (Task 4)
            // https://www.hexacta.com/How-to-enable-CORS-on-your-Web-API
            config.EnableCors();
            config.Filters.Add(new RequireHttpsAttribute());
        }
    }
}
