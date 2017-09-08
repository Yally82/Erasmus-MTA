﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Erasmus_MTA.Models;

namespace Erasmus_MTA.Controllers
{
    public class PersonController : Controller
    {
        private ErasmusEntities database = new ErasmusEntities();
        private MobilityType type = 0;

        // GET: Personal
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

        //[HttpGet]
        //public JsonResult getPersonalbyID()
        //{
        //    //returnare detalii mobilitate
        //    var jsonData = new
        //    {
        //        total = 1,
        //        page = 1,
        //        records = database.Employees.ToList().Count,
        //        rows = (
        //          from emp in database.Employees.ToList()
        //          select new
        //          {
        //              id = emp.id,
        //              cell = new string[] {
        //              emp.Name.ToString(),
        //              emp.Designation.ToString(),
        //              emp.Gender.ToString(),
        //              emp.Salary.ToString(),
        //              emp.City, emp.State,
        //              emp.Zip.ToString()
        //              }
        //          }).ToArray()
        //    };
        //    return Json(jsonData, JsonRequestBehavior.AllowGet);
        //}

    }
}