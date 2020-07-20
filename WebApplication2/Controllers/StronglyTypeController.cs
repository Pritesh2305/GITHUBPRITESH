using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class StronglyTypeController : Controller
    {
        // GET: StronglyType
        public ActionResult Index()
        {
            Employee emp1 = new Employee();
            emp1.Empid = 1;
            emp1.Empname = "Priesh";
            emp1.Empdesignation = "MD";

            ViewData["var1"] = emp1;
            ViewBag.var2 = emp1;

            return View(emp1);
        }
        public ActionResult Aboutus()
        {
            Employee emp1 = new Employee();
            emp1.Empid = 1;
            emp1.Empname = "Priesh1";
            emp1.Empdesignation = "MD1";

            Employee emp2 = new Employee();
            emp2.Empid = 2;
            emp2.Empname = "Priesh2";
            emp2.Empdesignation = "MD2";

            Employee emp3 = new Employee();
            emp3.Empid = 3;
            emp3.Empname = "Priesh3";
            emp3.Empdesignation = "MD3";

            List<Employee> emplist = new List<Employee>();
            emplist.Add(emp1);
            emplist.Add(emp2);
            emplist.Add(emp3);

            return View(emplist);
        }

        public ActionResult PartialViewDemo()
        {
            return View();
        }
    }
}