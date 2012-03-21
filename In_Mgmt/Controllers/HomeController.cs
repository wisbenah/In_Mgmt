using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace In_Mgmt.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to INVENTORY MANAGEMENT";

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
