using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erasmus_MTA.Models;
using System.Diagnostics;
using Erasmus_MTA.Utilities;

namespace Erasmus_MTA.Controllers
{
   
    public class MobilitiesController : Controller
    {

        private ErasmusEntities database = new ErasmusEntities();
        private MobilityType type = 0;

        public ActionResult Index()
        {
            string typeString = HttpContext.Request.Params.Get("type");
            if (typeString == "Incoming")
                type = MobilityType.Incoming;
            else
                if (typeString == "Outgoing")
                    type = MobilityType.Outgoing;
           // Debug.WriteLine(type.ToString());

            return View();
        }

        [HttpGet]
        public JsonResult getStudentMobilities()
        {
            List<dynamic> jsonData = new List<dynamic>();

            foreach (MobilitateOutgoing x in database.MobilitateOutgoing)
            {
                if(x.PersonalATM.SituatieActuala1.Denumire=="Student"||
                    x.PersonalATM.SituatieActuala1.Denumire == "Absolvent")
                    jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getPersonalATMMobilities()
        {
            List<dynamic> jsonData = new List<dynamic>();
            foreach (MobilitateOutgoing x in database.MobilitateOutgoing)
            {
                if (x.PersonalATM.SituatieActuala1.Denumire == "Personal"||
                    x.PersonalATM.SituatieActuala1.Denumire == "Fost Personal")
                    jsonData.Add(x.ToJSON());
            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getSelectParameters()
        {

            List<JsonObject> jsonData = new List<JsonObject>();

            JsonObject tari = new JsonObject("Tara");
            JsonObject departamente = new JsonObject("Departament");
            JsonObject orase = new JsonObject("Oras");
            JsonObject parteneri = new JsonObject("Parteneri");
            JsonObject nivelStudii = new JsonObject("Nivel Studii");
            JsonObject tipPartener = new JsonObject("Tip Partener");
            JsonObject niveleMobilitate = new JsonObject("Nivel Mobilitate");

            jsonData.Add(tari);
            jsonData.Add(orase);
            jsonData.Add(departamente);
            jsonData.Add(parteneri);
            jsonData.Add(nivelStudii);
            jsonData.Add(tipPartener);
            jsonData.Add(niveleMobilitate);


            foreach (Tara tara in database.Tara)
            {
                tari.Add(new JsonObject(tara.NumeEngleza));
            }
            foreach (DepartamenteATM dep in database.DepartamenteATM)
            {
                departamente.Add(new JsonObject(dep.Nume));
            }
            foreach(Oras oras in database.Oras)
            {
                orase.Add(new JsonObject(oras.Nume));
            }
            foreach( TipPartener tip in database.TipPartener)
            {
                tipPartener.Add(new JsonObject(tip.Denumire));
            }
           foreach( InstitutiiPartenere inst in database.InstitutiiPartenere)
            {
                parteneri.Add(new JsonObject(inst.Nume));
            }
            foreach (NivelStudii niv in database.NivelStudii)
            {
                nivelStudii.Add(new JsonObject(niv.Nivel));
            }

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    };

   

}
