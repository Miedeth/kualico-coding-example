using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CustomerTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Crazy Achmed's starship emporium.";

            return View();
        }

        public ActionResult Starship()
        {
            return View();
        }
    }
}
