using authorifilter.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace authorifilter.Controllers
{
    public class LoginController : Controller
    {
        DEMOLEARNEntities db = new DEMOLEARNEntities();
        // GET: Login
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(USERINFO u, string ReturnUrl)
        {
            if (isvalid(u))
            {
                FormsAuthentication.SetAuthCookie(u.USERNAME, false);
                Session["lusername"] = u.USERNAME + "";

                if (ReturnUrl != null)
                {
                    return Redirect(ReturnUrl);
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return View();
            }
        }

        public bool isvalid(USERINFO ui)
        {
            bool retval = false;
            try
            {
                var cre = db.USERINFOes.Where(m => m.USERNAME == ui.USERNAME && m.PWD == ui.PWD).FirstOrDefault();

                if (cre.USERNAME == ui.USERNAME && cre.PWD == ui.PWD)                
                {
                    retval = true;
                }

                return retval;
            }
            catch (Exception ex)
            {
                return retval;
            }
        }

        public ActionResult Logout()
        { 
            FormsAuthentication.SignOut();
            Session["lusername"] = null;
            return RedirectToAction("Index", "Home");
        }
    }
}