using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erasmus_MTA.Utilities;
using Erasmus_MTA.Models;
using System.Reflection;
using System.Data.Entity;

/*De facut updateurile, doar modificari corespunzatoare*/

namespace Erasmus_MTA.Controllers
{
   
    public class TablesController : Controller
    {
        private ErasmusEntities database = new ErasmusEntities();

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

            ViewBag.Table =  HttpContext.Request.Params.Get("table");
            return View();
        }


        //Use of Parameter binding  (simple types(from URL))
        public JsonResult getMedia(string type)
        {
            Assembly thisAssembly = typeof(TablesController).Assembly;
            Type t=Type.GetType("Erasmus_MTA.Models."+ type);
            MethodInfo method = Utility.GetExtensionMethods(thisAssembly, t,"ToJSON");

            List<dynamic> jsonData = new List<dynamic>();
            foreach (dynamic x in getContainer(type))
            {
                jsonData.Add(method.Invoke(x, new[] { x }));
            }
           
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        //Use of Parameter binding (simple types(from URL))
        public void deleteMedia(string type,int id)
        {
            Type t = Type.GetType("Erasmus_MTA.Models." + type);

            //get database
            dynamic container = getContainer(type);


            //database.Model.Find
            MethodInfo methodFind = container.GetType().GetMethod("Find");
            //conversion in order that invoke accepts parameter
            int[] intarray = new int[1];
            intarray[0] = id;
            dynamic x = methodFind.Invoke(container, new object[] { intarray.Cast<object>().ToArray()});
            if (x == null)
                return;


            //database.Model.Remove
            MethodInfo methodRemove = container.GetType().GetMethod("Remove", new[] { t });
            methodRemove.Invoke(container, new object[] { x });

            database.SaveChanges();
        }


        public JsonResult insertTara(Tara x)
        {
            database.Tara.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertOras(Oras x)
        {
            database.Oras.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertInstitutie(Institutie x)
        {
            database.Institutie.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertInstitutiiPartenere(InstitutiiPartenere x)
        {
            database.InstitutiiPartenere.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertDepartamenteATM(DepartamenteATM x)
        {
            database.DepartamenteATM.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertDepartamentePartenere(DepartamentePartenere x)
        {
            database.DepartamentePartenere.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertPersonalATM(PersonalATM x)
        {
            database.PersonalATM.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertParticipantiStraini(ParticipantiStraini x)
        {
            database.ParticipantiStraini.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult insertDetaliiMobilitatiProiect(DetaliiMobilitatiProiect x)
        {
            database.DetaliiMobilitatiProiect.Add(x);
            database.SaveChanges();
            return Json(x.ToJSON(), JsonRequestBehavior.AllowGet);
        }




        public JsonResult updateTara(int id, Tara edited)
        {
            Tara original = database.Tara.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.NumeEngleza = edited.NumeEngleza;
            original.NumeRomana = edited.NumeRomana;

            database.Entry(original).State= System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateOras(int id, Oras edited)
        {
            Oras original = database.Oras.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.NumeEngleza = edited.NumeEngleza;
            original.NumeRomana = edited.NumeRomana;

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateInstitutie(int id, Institutie edited)
        {
            Institutie original = database.Institutie.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.NumeEngleza = edited.NumeEngleza;
            original.Acronim = edited.Acronim;
            original.AdresaPostala = edited.AdresaPostala;
            original.AdresaWeb = edited.AdresaWeb;
            original.CodErasmus = edited.CodErasmus;
            original.CodPIC = edited.CodPIC;
            original.Descriere = edited.Descriere;

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateInstitutiiPartenere(int id, InstitutiiPartenere edited)
        {
            InstitutiiPartenere original = database.InstitutiiPartenere.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.NumeRomana = edited.NumeRomana;
            original.NumeEngleza = edited.NumeEngleza;
            original.Oras = edited.Oras;
            original.TipPartener = edited.TipPartener;
            original.Acronim = edited.Acronim;
            original.AdresaPostala = edited.AdresaPostala;
            original.AdresaWeb = edited.AdresaWeb;
            original.CodErasmus = edited.CodErasmus;
            original.CodPIC = edited.CodPIC;
            original.CartaErasmus = edited.CartaErasmus;
            original.AcordErasmus = edited.AcordErasmus;
            original.Descriere = edited.Descriere;

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateDepartamenteATM(int id, DepartamenteATM edited)
        {
            DepartamenteATM original = database.DepartamenteATM.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.NumeEngleza = edited.NumeEngleza;
            original.Acronim = edited.Acronim;
            original.AdresaPostala = edited.AdresaPostala;
            original.AdresaWeb = edited.AdresaWeb;
            original.Descriere = edited.Descriere;

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateDepartamentePartenere(int id, DepartamentePartenere edited)
        {
            DepartamentePartenere original = database.DepartamentePartenere.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.NumeRomana = edited.NumeRomana;
            original.NumeEngleza = edited.NumeEngleza;
            original.InstitutiePartenera = edited.InstitutiePartenera;
            original.Acronim = edited.Acronim;
            original.AdresaPostala = edited.AdresaPostala;
            original.AdresaWeb = edited.AdresaWeb;
            original.Descriere = edited.Descriere;

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updatePersonalATM(int id, PersonalATM edited)
        {
            PersonalATM original = database.PersonalATM.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.Prenume = edited.Prenume;
            original.DataNasterii = edited.DataNasterii;
            original.DepartamentATM = edited.DepartamentATM;
            original.SituatieErasmus = edited.SituatieErasmus;
            original.Functie = edited.Functie;
            original.Email = edited.Email;
            original.Telefon = edited.Telefon;
            original.Descriere = edited.Descriere;

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateParticipantiStraini(int id, ParticipantiStraini edited)
        {
            ParticipantiStraini original = database.ParticipantiStraini.Find(id);
            if (original == null)
                return null;

            original.Nume = edited.Nume;
            original.Prenume = edited.Prenume;
            original.DepartamentPartner = edited.DepartamentPartner;
            original.SituatieActuala = edited.SituatieActuala;
            original.SituatieErasmus = edited.SituatieErasmus;
            original.Functie = edited.Functie;
            original.Email = edited.Email;
            original.Telefon = edited.Telefon;
            original.Descriere = edited.Descriere;

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public JsonResult updateDetaliiMobilitatiProiect(int id, DetaliiMobilitatiProiect edited)
        {
            DetaliiMobilitatiProiect original = database.DetaliiMobilitatiProiect.Find(id);
            if (original == null)
                return null;

          //De completat

            database.Entry(original).State = System.Data.Entity.EntityState.Modified;
            database.SaveChanges();

            return Json(original.ToJSON(), JsonRequestBehavior.AllowGet);
        }
        public dynamic getContainer(string type)
        {
            switch (type)
            {
                case "Tara":
                    return database.Tara;
                case "Oras":
                    return database.Oras;
                case "Institutie":
                    return database.Institutie;
                case "InstitutiiPartenere":
                    return database.InstitutiiPartenere;
                case "PersonalATM":
                    return database.PersonalATM;
                case "ParticipantiStraini":
                    return database.ParticipantiStraini;
                case "DepartamenteATM":
                    return database.DepartamenteATM;
                case "DepartamentePartenere":
                    return database.DepartamentePartenere;
                case "DetaliiMobilitatiProiect":
                    return database.DetaliiMobilitatiProiect;
                default:
                    return null;
            }

        }

    }
}