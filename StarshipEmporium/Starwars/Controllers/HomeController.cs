using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Starwars.Models;

namespace CustomerTracker.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Crazy Achmed's starship emporium.";

            StarshipList starships = Starwars.Services.StarwarsApi.GetStarships(null);

            return View(starships);
        }

        public ActionResult Starship()
        {
            return View();
        }
    }
}
