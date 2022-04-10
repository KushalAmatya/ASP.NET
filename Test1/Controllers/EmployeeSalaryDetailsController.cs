using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            return View(emplyee_salary_details);
        }
        public ActionResult Create1()
        {
            var empList= db.employees.ToList();
            ViewBag.employeeList = new SelectList(empList, "id", "name");
            return View();
        }

        [HttpPost]
        public ActionResult SaveData(employee_salary_details employee_Salary_Details)
        {
            db.employee_salary_details.Add(employee_Salary_Details);
            db.SaveChanges();
           return RedirectToAction("EmpSalView");

        }
        public ActionResult EditSal(int Id)
        {
            var empList = db.employees.ToList();
            ViewBag.employeeList = new SelectList(empList, "id", "name");
            employee_salary_details data = db.employee_salary_details.Find(Id);
            //tab_1 data = db.tab_1.FirstOrDefault(x => x.Id == Id);
            return View(data);
        }
        public ActionResult UpdateData(employee_salary_details employee_Salary_Details)
        {
            db.Entry(employee_Salary_Details).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("EmpSalView");

        }
        public ActionResult Delete(int Id)
        {
            employee_salary_details data = db.employee_salary_details.Find(Id);
            db.employee_salary_details.Remove(data);
            db.SaveChanges();
            return RedirectToAction("EmpSalView");

        }
    }
}