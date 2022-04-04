using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class EmpNewController : Controller
    {
        // GET: EmpNew
        MainEntities db = new MainEntities();
        public ActionResult EmpNewView()
        {
            List<employee> data = db.employees.ToList();
            return View(data);
        }

        public ActionResult CreateEmp()
        {
            return View();
        }

        public ActionResult SaveData(employee employee)
        {
            db.employees.Add(employee);
            db.SaveChanges();
            return RedirectToAction("EmpNewView");

        }
        public ActionResult EditEmp(int Id)
        {
            employee data = db.employees.Find(Id);
            //tab_1 data = db.tab_1.FirstOrDefault(x => x.Id == Id);
            return View(data);
        }
        public ActionResult UpdateData(employee employee)
        {
            db.Entry(employee).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("EmpNewView");

        }
        public ActionResult Delete(int Id)
        {
            employee data = db.employees.Find(Id);
            db.employees.Remove(data);
            db.SaveChanges();
            return RedirectToAction("EmpNewView");

        }
    }
}