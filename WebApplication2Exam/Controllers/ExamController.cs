using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2Exam.Controllers
{
    public class ExamController : Controller
    {
        // GET: Exam
        public ActionResult Index()
            
        {
            ViewBag.loggedInUserName = User.Identity.Name;
            return View("Index", dbObject.Employees.ToList());
        }

        public ActionResult Delete(int id)
        {
            Employee employeeToBeDeleted = dbObject.Employees.Find(id);
            dbObject.Employees.Remove(employeeToBeDeleted);

            dbObject.SaveChanges();
            return Redirect("/Demo/Index");
        }

        public ActionResult Create()
        {
            return View("Create");
        }

        public ActionResult AfterCreate(Employee employeeToBeAdded)
        {
            dbObject.Employees.Add(employeeToBeAdded);
            dbObject.SaveChanges();
            return Redirect("/Demo/Index");
        }

        public ActionResult Edit(int id)
        {
            Employee employeeToBeEdited = dbObject.Employees.Find(id);

            return View("Edit", employeeToBeEdited);
        }

        public ActionResult AfterEdit(Employee updatedEmployee)
        {
            Employee employeeToBeEdited = dbObject.Employees.Find(updatedEmployee.No);
            employeeToBeEdited.Name = updatedEmployee.Name;
            employeeToBeEdited.Address = updatedEmployee.Address;
            dbObject.SaveChanges();
            return Redirect("/Demo/Index");
        }

        [AllowAnonymous]
        public ActionResult About()
        {
            return View("About");
        }
    }


}
        }
    }
}
