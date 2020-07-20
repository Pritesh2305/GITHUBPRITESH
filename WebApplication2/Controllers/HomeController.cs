using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HomeController : Controller
    {
      //  [Route("Home/Index")]
        public ActionResult Index()
        {
            TempData["d1"] = "Pritesh Bhavsar";
            ViewData["m1"] = "test message";
            ViewData["m2"] = System.DateTime.Now.ToShortDateString();

            string[] fruits = { "apple", "mamgo", "banana" };
            ViewData["fa"] = fruits;

            List<string> sportslist = new List<string>()
            {
                "cricket",
                "vollyball",
                "tabletennis"
            };

            ViewData["sportslist"] = sportslist;

            // employee 
            Employee emp = new Employee();
            emp.Empid = 11;
            emp.Empname = "Pritesh";
            emp.Empdesignation = "MD";
            ViewData["Emp"] = emp;


            //////
            ///
            ViewBag.Message = "Test";
            ViewBag.splist1 = sportslist;
            ViewBag.emp1 = emp;


            ViewData["commondata"] = "Common Data";
            ViewBag.commondata1 = "Common Data1";

            
            //TempData.Keep();
            

            return View("");
        }

        public string Show()
        {
            return "Show Action Method";
        }

        public dynamic Studentid(dynamic id)
        {
            return id;
        }

        public ActionResult Pritesh()
        {
            return View();
        }

        public ActionResult Viewdatademo()
        {
            return View();
        }
    }
       
}