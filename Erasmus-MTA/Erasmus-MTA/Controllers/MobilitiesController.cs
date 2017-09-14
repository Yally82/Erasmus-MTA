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
            List<JstreeObject> jsonData = new List<JstreeObject>();

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
            List<JstreeObject> jsonData = new List<JstreeObject>();

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

            List<JstreeObject> jsonData = new List<JstreeObject>();

            JstreeObject tari = new JstreeObject("Tara");
            JstreeObject departamente = new JstreeObject("Departament");
            JstreeObject orase = new JstreeObject("Oras");
            JstreeObject parteneri = new JstreeObject("Partener");
            JstreeObject tipPartener = new JstreeObject("Tip Partener");
            JstreeObject niveleMobilitate = new JstreeObject("Nivel Mobilitate");

            jsonData.Add(tari);
            jsonData.Add(orase);
            jsonData.Add(departamente);
            jsonData.Add(parteneri);
            jsonData.Add(tipPartener);
            jsonData.Add(niveleMobilitate);


            foreach (Tara tara in database.Tara)
            {
                tari.Add(new JstreeObject(tara.NumeEngleza));
            }
            foreach (DepartamenteATM dep in database.DepartamenteATM)
            {
                departamente.Add(new JstreeObject(dep.Nume));
            }
            foreach(Oras oras in database.Oras)
            {
                orase.Add(new JstreeObject(oras.Nume));
            }
            foreach( TipPartener tip in database.TipPartener)
            {
                tipPartener.Add(new JstreeObject(tip.Denumire));
            }
           foreach( InstitutiiPartenere inst in database.InstitutiiPartenere)
            {
                parteneri.Add(new JstreeObject(inst.Nume));
            }
            foreach (NivelStudii niv in database.NivelStudii)
            {
                parteneri.Add(new JstreeObject(niv.Nivel));
            }

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
    };

   

}
