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
            foreach (Tara x in database.Tara)
            {          
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonOrase()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (Oras x in database.Oras)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonInstitutii()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (Institutie x in database.Institutie)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonInstitutiiPartenere()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (InstitutiiPartenere x in database.InstitutiiPartenere)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonDepartamente()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (DepartamenteATM x in database.DepartamenteATM)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonDepartamentePart()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (DepartamentePartenere x in database.DepartamentePartenere)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonPersonalATM()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (PersonalATM x in database.PersonalATM)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonParticipantiStraini()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (ParticipantiStraini x in database.ParticipantiStraini)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getJsonDetaliiMobilitati()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (DetaliiMobilitatiProiect x in database.DetaliiMobilitatiProiect)
            {
                jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

    }
}