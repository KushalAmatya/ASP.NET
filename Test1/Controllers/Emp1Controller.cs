using System;
using System.Collections.Generic;
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
    }
}