using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace resultfilter.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        [OutputCache(Duration =10,Location =System.Web.UI.OutputCacheLocation.Server )]
        public ActionResult Index()
        {
            ViewBag.time = DateTime.Now.ToLongTimeString();
            return View();
        }
    }
}