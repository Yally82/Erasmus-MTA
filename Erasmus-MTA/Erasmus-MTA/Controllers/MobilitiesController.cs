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
        public JsonResult jstreeCheckedPersonal(string tara=null,string oras=null,string departament=null,string parteneri=null,string nivelStudii=null,string tipPartener=null,string nivelMobilitate=null)
        {


            List<dynamic> jsonData = new List<dynamic>();
            foreach (MobilitateOutgoing x in database.MobilitateOutgoing)
            {
           
                if ((x.PersonalATM.SituatieActuala1.Denumire == "Personal" ||
                    x.PersonalATM.SituatieActuala1.Denumire == "Fost Personal"))
                    {
                    int sw = 0;
                    if (tara!=null)
                        if(tara.Contains(x.InstitutiiPartenere.Oras1.Tara1.NumeEngleza)==false)
                        {
                            sw=1;
                            break;
                        }
                    if(oras!=null)
                        if(oras.Contains(x.InstitutiiPartenere.Oras1.Nume)==false)
                        {
                            sw = 1;
                            break;
                        }
                    if(departament!=null)
                        if (departament.Contains(x.DepartamenteATM.Nume) == false)
                        {
                            sw = 1;
                            break;
                        }
                   
                    if (parteneri != null)
                        if (parteneri.Contains(x.InstitutiiPartenere.Nume) == false)
                        {
                            sw = 1;
                            break;
                        }
                    if(nivelStudii!= null)
                    if(nivelStudii.Contains(x.Mobilitate.NivelStudii.Nivel)==false)
                    {
                        sw = 1;
                        break;
                    }
                    if(tipPartener!=null)
                    if (tipPartener.Contains(x.InstitutiiPartenere.TipPartener1.Denumire) == false)
                    {
                        sw = 1;
                        break;
                    }
                    if(nivelMobilitate!=null)
                    if (nivelMobilitate.Contains("") == false)
                    {
                        sw = 1;
                        break;
                    }
                    if (sw == 0)
                        jsonData.Add(x.ToJSON());
                }

            }
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }
         [HttpGet]
        public JsonResult jstreeCheckedStudents(string tara = null, string oras = null, string departament = null, string parteneri = null, string nivelStudii = null, string tipPartener = null, string nivelMobilitate = null)
        {


            List<dynamic> jsonData = new List<dynamic>();
            foreach (MobilitateOutgoing x in database.MobilitateOutgoing)
            {

                if ((x.PersonalATM.SituatieActuala1.Denumire == "Student" ||
                    x.PersonalATM.SituatieActuala1.Denumire == "Absolvent"))
                {
                    int sw = 0;
                    if (tara != null)
                        if (tara.Contains(x.InstitutiiPartenere.Oras1.Tara1.NumeEngleza) == false)
                        {
                            sw = 1;
                            break;
                        }
                    if (oras != null)
                        if (oras.Contains(x.InstitutiiPartenere.Oras1.Nume) == false)
                        {
                            sw = 1;
                            break;
                        }
                    if (departament != null)
                        if (departament.Contains(x.DepartamenteATM.Nume) == false)
                        {
                            sw = 1;
                            break;
                        }

                    if (parteneri != null)
                        if (parteneri.Contains(x.InstitutiiPartenere.Nume) == false)
                        {
                            sw = 1;
                            break;
                        }
                    if (nivelStudii != null)
                        if (nivelStudii.Contains(x.Mobilitate.NivelStudii.Nivel) == false)
                        {
                            sw = 1;
                            break;
                        }
                    if (tipPartener != null)
                        if (tipPartener.Contains(x.InstitutiiPartenere.TipPartener1.Denumire) == false)
                        {
                            sw = 1;
                            break;
                        }
                    if (nivelMobilitate != null)
                        if (nivelMobilitate.Contains("") == false)
                        {
                            sw = 1;
                            break;
                        }
                    if (sw == 0)
                        jsonData.Add(x.ToJSON());
                }

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
            JsonObject nivelStudii = new JsonObject("NivelStudii");
            JsonObject tipPartener = new JsonObject("TipPartener");
            JsonObject niveleMobilitate = new JsonObject("NivelMobilitate");

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
