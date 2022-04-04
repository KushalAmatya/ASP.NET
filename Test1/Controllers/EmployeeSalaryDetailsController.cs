using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Test1.Models;

namespace Test1.Controllers
{
    public class EmployeeSalaryDetailsController : Controller
    {
        // GET: EmployeeSalaryDetails
        MainEntities db = new MainEntities();
        public ActionResult EmpSalView()
        {
            var emplyee_salary_details = db.employee_salary_details.ToList();
            return View();
        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult SaveData(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
            return RedirectToAction("EmpSalView");

        }
    }
}