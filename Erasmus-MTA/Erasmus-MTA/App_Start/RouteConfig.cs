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
                name: "TablesInstitutii",
                url: "Tables/Intern/getjson/Institutii",
                defaults: new { controller = "Tables", action = "getJsonInstitutii" }
             );
            routes.MapRoute(
                name: "TablesInstitutiiPart",
                url: "Tables/Intern/getjson/InstitutiiPart",
                defaults: new { controller = "Tables", action = "getJsonInstitutiiPartenere" }
             );
            routes.MapRoute(
                name: "TablesDepartamente",
                url: "Tables/Intern/getjson/Departamente",
                defaults: new { controller = "Tables", action = "getJsonDepartamente" }
             );
            routes.MapRoute(
               name: "TablesDepartamentePart",
               url: "Tables/Intern/getjson/DepartamentePart",
               defaults: new { controller = "Tables", action = "getJsonDepartamentePart" }
            );
            routes.MapRoute(
                  name: "TablesPersonal",
                  url: "Tables/Intern/getjson/Personal",
                  defaults: new { controller = "Tables", action = "getJsonPersonalATM" }
           );
            routes.MapRoute(
                 name: "TablesParticipanti",
                 url: "Tables/Intern/getjson/Participanti",
                 defaults: new { controller = "Tables", action = "getJsonParticipantiStraini" }
          );
            routes.MapRoute(
                name: "TablesMobilitati",
                url: "Tables/Intern/getjson/Mobilitati",
                defaults: new { controller = "Tables", action = "getJsonDetaliiMobilitati" }
         );
            routes.MapRoute(
              name: "TablesOrase",
              url: "Tables/Intern/getjson/Orase",
              defaults: new { controller = "Tables", action = "getJsonOrase" }
       );


            /////////////////////////////////////////////////////////////////////////////////
            routes.MapRoute(
                name: "MobilitiesGetJson",
                url: "Mobilities/Intern/getjson",
                defaults: new { controller = "Mobilities", action = "getSelectParameters" }
             );
     
            routes.MapRoute(
             name: "PersonGetJson",
             url: "Person/Intern/getJson",
             defaults: new { controller = "Person", action = "getJsonPerson" }
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
