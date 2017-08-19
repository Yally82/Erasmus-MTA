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
               name: "MobilitateINGetJSONid",
               url: "MobilitateIN/Intern/GetJSON/{id}",
               defaults: new { controller = "MobilitateIN", action = "getMobilitiesbyID" }
            );
            routes.MapRoute(
              name: "MobilitateINGetJSON",
              url: "MobilitateIN/Intern/GetJSON/{action}",
              defaults: new { controller = "MobilitateIN", action = "getMobilitiebyTara" }
           );

            routes.MapRoute(
                name: "MobilitateINSelect",
                url: "MobilitateIN/Select/{type}",
                defaults: new { controller = "MobilitateIN", action = "Index" }
             );

            routes.MapRoute(
             name: "PersonalGetJson",
             url: "Personal/Intern/GetJSON/{id}",
             defaults: new { controller = "Personal", action = "getPersonalbyID" }
            );

            routes.MapRoute(
             name: "Personal",
             url: "Personal",
             defaults: new { controller = "Personal", action = "Index" }
          );

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
