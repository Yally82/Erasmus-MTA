using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Erasmus_MTA.Controllers
{
    public class PersonalController : Controller
    {
        // GET: Personal
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult getPersonalbyID()
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

    }
}