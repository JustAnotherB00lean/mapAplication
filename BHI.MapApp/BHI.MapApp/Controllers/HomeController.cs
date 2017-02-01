using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BHI.MapApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Holas";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "m";

            return View();
        }
    }
}