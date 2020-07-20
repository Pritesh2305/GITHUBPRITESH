using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication2.Controllers
{
    public class QrcodeController : Controller
    {
        // GET: Qrcode
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string Text1)
        {

            return View();
        }
    }
}