using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace vidly
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            // inable attr routing
            routes.MapMvcAttributeRoutes();
            // the old routing you have to go to too many places for any change
            routes.MapRoute(
                name: "MoviesByReleaseDate",
                url: "Movies/released/{year}/{month}",
                defaults: new { controller = "Movies", action = "MoviesByReleaseDate" },
                new { year = @"\d{4}", month = @"\d{2}" }
                );
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
