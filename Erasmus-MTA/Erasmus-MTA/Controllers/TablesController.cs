using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erasmus_MTA.Utilities;
using Erasmus_MTA.Models;

namespace Erasmus_MTA.Controllers
{
    public class TablesController : Controller
    {
        private ErasmusEntities database = new ErasmusEntities();

        public ActionResult Index()
        {
            ViewBag.Table =  HttpContext.Request.Params.Get("table");
            return View();
        }

        [HttpGet]
        public JsonResult getJsonTara()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (Tara tara in database.Tara)
            {
                jsonData.Add(new { tara.ID, tara.Nume, tara.NumeRomana, tara.NumeEngleza } );
            }
            var js= Json(jsonData, JsonRequestBehavior.AllowGet);
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}