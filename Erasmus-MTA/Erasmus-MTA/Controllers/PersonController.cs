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

        // GET: Personal
        public ActionResult Index()
        {
            // Security
            if (Session["Username"] == null)
            {
                Response.Clear();
                Response.Write("Access Denied");
                Response.StatusCode = 401;
                Response.End();
                return View();
            }

            string typeString = HttpContext.Request.Params.Get("type");

            if (typeString.CompareTo(MobilityType.Incoming.ToString()) == 0)
            {
                Session["type"] = MobilityType.Incoming;
            }
            else if (typeString.CompareTo(MobilityType.Outgoing.ToString()) == 0)
            {
                Session["type"] = MobilityType.Outgoing;
            }
            return View();
        }

       
        [HttpGet]
        public JsonResult getJsonPerson()
        {
            List<dynamic> jsonData = new List<dynamic>();

            if (Session["type"].ToString().CompareTo(MobilityType.Incoming.ToString())==0)
            {
                foreach (ParticipantiStraini x in database.ParticipantiStraini)
                {
                    foreach (MobilitateIncoming y in database.MobilitateIncoming)
                    {
                        if (y.ParticipantiStraini1.ID == x.ID)
                        {
                            jsonData.Add(x.ToJSON());
                            break;
                        }
                    }
                }
            }
            else if (Session["type"].ToString().CompareTo(MobilityType.Outgoing.ToString()) == 0)
            {
                foreach (PersonalATM x in database.PersonalATM)
                {
                    foreach (MobilitateOutgoing y in database.MobilitateOutgoing)
                    {
                        if (y.PersonalATM1.ID == x.ID)
                        {
                            jsonData.Add(x.ToJSON());
                            break;
                        }
                    }
                }
            }

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    }
}