using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erasmus_MTA.Models;
using System.Diagnostics;

namespace Erasmus_MTA.Controllers
{
    public enum MobilityType
    {
        Incoming,
        Outgoing,
    }

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
            JsonData jsonData = new JsonData("Types");

            foreach (Tara tara in database.Tara)
            {
                jsonData.tari.Add(new JstreeObject(tara.NumeEngleza));
            }
            foreach (DepartamenteATM dep in database.DepartamenteATM)
            {
                jsonData.departamente.Add(new JstreeObject(dep.Nume));
            }
            foreach(Oras oras in database.Oras)
            {
                jsonData.orase.Add(new JstreeObject(oras.Nume));
            }
            foreach( TipPartener tipPartener in database.TipPartener)
            {
                jsonData.tipPartener.Add(new JstreeObject(tipPartener.Denumire));
            }
           foreach( InstitutiiPartenere inst in database.InstitutiiPartenere)
            {
                jsonData.parteneri.Add(new JstreeObject(inst.Nume));
            }
            foreach (NivelStudii niv in database.NivelStudii)
            {
                jsonData.parteneri.Add(new JstreeObject(niv.Nivel));
            }

            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        public class JsonData : JstreeObject
        {
            public JstreeObject tari = new JstreeObject("Tara");
            public JstreeObject departamente= new JstreeObject("Departament");
            public JstreeObject orase = new JstreeObject("Oras");
            public JstreeObject parteneri = new JstreeObject("Partener");
            public JstreeObject tipPartener = new JstreeObject("Tip Partener");
            public JstreeObject niveleMobilitate = new JstreeObject("Nivel Mobilitate");

            public JsonData(string name)
                :base(name)
            {
                children = new List<JstreeObject>();
                children.Add(tari);
                children.Add(orase);
                children.Add(departamente);
                children.Add(parteneri);
                children.Add(tipPartener);
                children.Add(niveleMobilitate);

                tari.children = new List<JstreeObject>();
                departamente.children = new List<JstreeObject>();
                orase.children = new List<JstreeObject>();
                parteneri.children = new List<JstreeObject>();
                tipPartener.children = new List<JstreeObject>();
                niveleMobilitate.children = new List<JstreeObject>();
            }
        }

        public class JstreeObject
        {
            public string text;
            public int id;
            public State state;
            public List<JstreeObject> children;
            public JstreeObject()
            {
                state = new State();
                state.opened = true;
                children = null;
            }
            public JstreeObject(string name)
                :this()
            { 
                text = name;
            }
            public void Add(JstreeObject obj)
            {
                children.Add(obj);
            }
        }
        public class State
        {
            public bool selected;
            public bool opened;
            public bool disabled;
        }
    };
}
