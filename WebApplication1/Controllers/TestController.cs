using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class TestController : Controller
    {
        // GET: Test
        public string Index()
        {
            return ("Hello World");
        }

        public ActionResult Method1()
        {
            ViewBag.message = "Pritesh Bhavsar";
            return View();
        }

        public ActionResult Membership()
        {
            return View();
        }
    }
}