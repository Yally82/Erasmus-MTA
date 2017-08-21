using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Erasmus_MTA
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            routes.MapRoute(
                name: "MobilitiesGETJSON",
                url: "Mobilities/Intern/GETJSON",
                defaults: new { controller = "Mobilities", action = "getSelectParameters" }
             );

            routes.MapRoute(
                name: "Mobilities",
                url: "Mobilities",
                defaults: new { controller = "Mobilities", action = "Index" }
             );

            routes.MapRoute(
             name: "PersonGetJson",
             url: "Person/Intern/GetJSON",
             defaults: new { controller = "Person", action = "getPersonbyID" }
            );

            routes.MapRoute(
             name: "Person",
             url: "Person",
             defaults: new { controller = "Person", action = "Index" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
