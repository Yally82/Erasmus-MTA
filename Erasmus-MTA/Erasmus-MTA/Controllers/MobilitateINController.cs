using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erasmus_MTA.Models;

namespace Erasmus_MTA.Controllers
{
    public class MobilitateINController : Controller
    {
        private ErasmusEntities database = new ErasmusEntities();

        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getMobilitiesbyID()
        {
            //returnare detalii mobilitate
            var jsonData = new
            {
                total = 1,
                page = 1,
                records = database.Employees.ToList().Count,
                rows = (
                  from emp in database.Employees.ToList()
                  select new
                  {
                      id = emp.id,
                      cell = new string[] {
                      emp.Name.ToString(),
                      emp.Designation.ToString(),
                      emp.Gender.ToString(),
                      emp.Salary.ToString(),
                      emp.City, emp.State,
                      emp.Zip.ToString()
                      }
                  }).ToArray()
            };
            return Json(jsonData, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult getMobilitiesbyTara()
        {
            //returnare detalii mobilitati
        }

        [HttpGet]
        public JsonResult getMobilitiesbyOras()
        { //returnare detalii mobilitati
        }

        [HttpGet]
        public JsonResult getMobilitiesbyDepartament()
        { //returnare detalii mobilitati
        }

        [HttpGet]
        public JsonResult getMobilitiesbyPartener()
        { //returnare detalii mobilitati
        }

        [HttpGet]
        public JsonResult getMobilitiesbyTipPartener()
        { //returnare detalii mobilitati
        }

        [HttpGet]
        public JsonResult getMobilitiesbyAn()
        { //returnare detalii mobilitati
        }

        [HttpGet]
        public JsonResult getMobilitiesbyNivelMobilitate()
        { //returnare detalii mobilitati
        }

        [HttpGet]
        public JsonResult getMobilitiesbyGenParticipant()
        { //returnare detalii mobilitati
        }
    }
}