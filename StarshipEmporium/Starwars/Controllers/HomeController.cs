using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Starwars.Models;

namespace Starwars.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Crazy Achmed's starship emporium.";

            StarshipList starships = Starwars.Services.StarwarsApi.GetStarships(null);

            return View("Index", starships);
        }

        public ActionResult Starship(int id)
        {
            Starship starship = Starwars.Services.StarwarsApi.GetStarship(id);

            return View("Starship", starship);
        }
    }
}
