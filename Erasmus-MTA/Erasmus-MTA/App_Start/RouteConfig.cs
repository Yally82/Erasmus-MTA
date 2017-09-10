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
                name: "TablesTara",
                url: "Tables/Intern/getjson/Tara",
                defaults: new { controller = "Tables", action = "getJsonTara" }
             );

            routes.MapRoute(
                name: "MobilitiesGETJSON",
                url: "Mobilities/Intern/getjson",
                defaults: new { controller = "Mobilities", action = "getSelectParameters" }
             );
     
            routes.MapRoute(
             name: "PersonGetJson",
             url: "Person/Intern/getjSON",
             defaults: new { controller = "Person", action = "getPersonbyID" }
            );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
