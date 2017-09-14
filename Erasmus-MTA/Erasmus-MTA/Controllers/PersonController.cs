using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erasmus_MTA.Models;
using Erasmus_MTA.Utilities;

namespace Erasmus_MTA.Controllers
{
    public class PersonController : Controller
    {
        private ErasmusEntities database = new ErasmusEntities();
        private MobilityType type = 0;

        // GET: Personal
        public ActionResult Index()
        {
            string typeString = HttpContext.Request.Params.Get("type");
            if (typeString == "Incoming")
                type = MobilityType.Incoming;
            else
                if (typeString == "Outgoing")
                type = MobilityType.Outgoing;
            return View();
        }

        //Robert: Get JSON Person. Completare: aici cu for..+Utilities/ToJSON+script cu campuri
        [HttpGet]
        public JsonResult getJsonPerson()
        {
            List<dynamic> jsonData = new List<dynamic>();
           
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}