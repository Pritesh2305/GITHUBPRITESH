using ajaxform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajaxform.Controllers
{
    public class HomeController : Controller
    {
        DEMOLEARNEntities db = new DEMOLEARNEntities();

        // GET: Home
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(EMP e)
        {
            if (ModelState.IsValid)
            {
                db.EMPs.Add(e);
                int a = db.SaveChanges();

                if (a > 0)
                {
                    //return Json("Data Insert.");
                    return JavaScript("alert('Data Inserted !!')");
                }
                else
                {
                    return Json("Problem in Data Insert.");
                }
            }
            return View();
        }

        public ActionResult Index()
        {
            List<EMP> emplist1 = new List<EMP>();
            emplist1 = db.EMPs.Where(m => m.RID > 0).ToList();

            return View(emplist1);
        }
            
        [HttpPost]
        public ActionResult Index(string txtsearch)
        {
            List<EMP> semplist1 = new List<EMP>();


            if (string.IsNullOrEmpty(txtsearch) == false)
            {
                semplist1 = db.EMPs.Where(m => m.FIRSTNAME.Contains(txtsearch)).ToList();
                return PartialView("_searchdata", semplist1);
                //return View(semplist1);
            }
            else
            {
                semplist1 = db.EMPs.Where(m => m.RID > 0).ToList();
                return PartialView("_searchdata", semplist1);
                //return View(semplist1);
            }


            //return View(semplist1);
        }
        
        public ActionResult Allemp()
        {
            dynamic datalist = db.EMPs.ToList();
            return PartialView("_searchdata", datalist);
        }

        public ActionResult Empreset()
        {
            dynamic datalist = db.EMPs.Where(m =>m.RID<=0);
            dynamic da1 = (from s in db.EMPs
                          where s.RID <= 0
                          select new { s.FIRSTNAME,s.LASTNAME }).ToList();

            dynamic da2 = (from s in db.EMPs                           
                           orderby s.FIRSTNAME, s.LASTNAME
                           select new {s.FIRSTNAME,s.OFFICE }
                           ).Take(3);

            dynamic d3 = (from s in db.EMPs
                          group s by new { s.FIRSTNAME,s.LASTNAME }
                          ).ToList();
                         
                


            return PartialView("_searchdata", datalist);
        }
    }
}