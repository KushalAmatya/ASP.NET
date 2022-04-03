using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class Emp1Controller : Controller
    {
        MainEntities db = new MainEntities();
        // GET: Emp1
        public ActionResult Emp1View()
        {
            List<tab_2> data = db.tab_2.ToList();
            return View(data);

        }
        public ActionResult Createnew()
        {
            return View();
        }
        public ActionResult SaveData(tab_2 tab_2)
        {
            db.tab_2.Add(tab_2);
            db.SaveChanges();
            return RedirectToAction("Emp1View");

        }
        public ActionResult EditNew(int Id)
        {
            tab_2 data = db.tab_2.Find(Id);
            //tab_2 data = db.tab_2.FirstOrDefault(x => x.Id == Id);
            return View(data);
        }
        public ActionResult UpdateData(tab_2 tab_2)
        {
            db.Entry(tab_2).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Emp1View");

        }
        public ActionResult DeleteNew(int Id)
        {
            tab_2 data = db.tab_2.Find(Id);
            db.tab_2.Remove(data);
            db.SaveChanges();
            return RedirectToAction("Emp1View");

        }
    }
}