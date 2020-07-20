using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication3.Areas.USERINFO.Controllers
{
    public class HomeController : Controller
    {
        // GET: USERINFO/Home
        public ActionResult Index()
        {
            return View();
        }
    }
}