using logindemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace logindemo.Controllers
{
    public class LoginController : Controller
    {
        DEMOLEARNEntities db = new DEMOLEARNEntities();

        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(MSTUSER mu)
        {
            if (ModelState.IsValid)
            {
                var logindata = db.MSTUSERS.Where(m => m.USERNAME == mu.USERNAME && m.PASSWORD == mu.PASSWORD).FirstOrDefault();
                
                if (logindata == null)
                {
                    ViewBag.errormsg = "Invalid Username or Paasword";
                    return View();
                }
                else
                {
                    Session["loginuserrid"] = logindata.RID;
                    Session["loginusername"] = logindata.USERNAME;
                    return RedirectToAction("Index","Home");
                }
            }
            else
            {
                return View();
            }          
        }
    }
}