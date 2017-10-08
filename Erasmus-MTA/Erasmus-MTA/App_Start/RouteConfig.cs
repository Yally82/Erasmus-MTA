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



            /////////////////////////////////////////////////////////////////////////////////

            routes.MapRoute(
                name: "Tables",
                url: "Tables/{action}/{type}/{id}",
                defaults: new { controller = "Tables", type = UrlParameter.Optional, id = UrlParameter.Optional }
             );


            /////////////////////////////////////////////////////////////////////////////////
            routes.MapRoute(
                name: "MobilitiesGetJsonStudent",
                url: "Mobilities/Intern/getjson/StudentMobilities",
                defaults: new { controller = "Mobilities", action = "getStudentMobilities" }
             );
            routes.MapRoute(
                name: "MobilitiesGetJsonPersonalATM",
                url: "Mobilities/Intern/getjson/PersonalATMMobilities",
                defaults: new { controller = "Mobilities", action = "getPersonalATMMobilities" }
             );

            routes.MapRoute(
                name: "MobilitiesGetJson",
                url: "Mobilities/Intern/getjson",
                defaults: new { controller = "Mobilities", action = "getSelectParameters" }
             );



            /////////////////////////////////////////////////////////////////////////////////
            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Login", id = UrlParameter.Optional }
            );
        }
    }
}
