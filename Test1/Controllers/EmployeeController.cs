using System;
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
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(tab_1 tab_1)
        {
            db.tab_1.Add(tab_1);
            db.SaveChanges();
            return RedirectToAction("EmpView");
                
        }
    }
}