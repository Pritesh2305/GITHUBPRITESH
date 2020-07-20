using ajaxform.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ajaxform.Controllers
{
    public class PagingController : Controller
    {
        DEMOLEARNEntities db = new DEMOLEARNEntities();

        // GET: Paging
        public ActionResult Index()
        {
            int num =5;
            Session["data"] = num;
            var list1 = (from s in db.EMPs
                        where s.RID > 0
                        select s).ToList().Take(num);

            return View(list1);
        }

        [HttpPost]
        public ActionResult Index(EMP e)
        {
            int row1 = 0;
            int.TryParse(Session["data"]+"", out row1);
            int rows = row1 + 5;

            var list1 = (from m in db.EMPs
                         where m.RID > 0
                         select m).ToList().Take(rows);
            Session["data"] = rows;
            //return View(list1);
            return PartialView("_emplist",list1);

        }
    }
}