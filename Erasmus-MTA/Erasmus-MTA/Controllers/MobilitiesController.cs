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
        public JsonResult getSelectParameters()
        {
            JstreeObject jsonData = new JstreeObject("Types");

            JstreeObject tari = new JstreeObject("Tara");
            JstreeObject departamente = new JstreeObject("Departament");
            JstreeObject orase = new JstreeObject("Oras");
            JstreeObject parteneri = new JstreeObject("Partener");
            JstreeObject tipPartener = new JstreeObject("Tip Partener");
            JstreeObject niveleMobilitate = new JstreeObject("Nivel Mobilitate");

            jsonData.children.Add(tari);
            jsonData.children.Add(orase);
            jsonData.children.Add(departamente);
            jsonData.children.Add(parteneri);
            jsonData.children.Add(tipPartener);
            jsonData.children.Add(niveleMobilitate);


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
