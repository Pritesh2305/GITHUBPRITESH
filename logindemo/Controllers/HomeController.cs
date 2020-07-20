using logindemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace logindemo.Controllers
{
    public class HomeController : Controller
    {
        DEMOLEARNEntities objemp = new DEMOLEARNEntities();

        // GET: Home
        public ActionResult Index()
        {
            if (Session["loginuserrid"] == null || Session["loginuserrid"].ToString() == "")
            {
                return RedirectToAction("Index", "Login");
            }

            var emplist = objemp.EMPs.ToList();
            ViewBag.emplist = emplist;

            return View();
        }

        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Index", "Login");
            
        }

        public ActionResult Add()
        {
            return View();

        }

        [HttpPost]
        public ActionResult Add(EMP emp1)
        {
            objemp.EMPs.Add(emp1);
            objemp.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        public ActionResult Edit(int id)
        {
            var row = objemp.EMPs.Where(model => model.RID == id).FirstOrDefault();
            return View(row); 
        }

        [HttpPost]
        public ActionResult Edit(EMP emp1)
        {
            if (ModelState.IsValid == true)
            {
                var row = objemp.EMPs.Where(model => model.RID == emp1.RID).FirstOrDefault();

                row.FIRSTNAME = emp1.FIRSTNAME;
                row.LASTNAME = emp1.LASTNAME;
                row.EMPCODE = emp1.EMPCODE;
                row.POSITION = emp1.POSITION;
                row.OFFICE = emp1.OFFICE;

                //objemp.Entry(objemp).State = System.Data.Entity.EntityState.Modified;
                int a = objemp.SaveChanges();
                if (a > 0)
                {
                    TempData["updatemsg"] = "<script>alert('Update Record Completed') </script>";
                    return RedirectToAction("Index","Home");
                }
                else
                {
                    TempData["updatemsg"] = "<script>alert('Update Record Failed.') </script>";
                }
            }

            return View();
        }
        
        public ActionResult Delete(int id)
        {
            var row = objemp.EMPs.Where(model => model.RID == id).FirstOrDefault();
            objemp.EMPs.Remove(row);

            int a = objemp.SaveChanges();
            if (a > 0)
            {
                TempData["deletemsg"] = "<script>alert('Delete Record Completed') </script>";
                return RedirectToAction("Index", "Home");
            }
            else
            {
                TempData["deletemsg"] = "<script>alert('Delete Record Failed.') </script>";
            }
            return View();

        }
        

    }
}