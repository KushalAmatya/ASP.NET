﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class EmployeeController : Controller
    {
        MainEntities db = new MainEntities();
        // GET: Employee
        public ActionResult EmpView()
        {
            List<tab_1> data = db.tab_1.ToList();
            return View(data);
        }
    }
}