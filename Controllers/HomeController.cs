using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.IdentityModel.Tokens;
using OlympicGames.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGames.Controllers
{
    public class HomeController : Controller
    {
        private CountryContext context;

        public HomeController(CountryContext ctx)
        {
            context = ctx;
        }

        public ViewResult Index(string activeCategory = "all", string activeGame = "all")
        {
            var session = new OlympicSession(HttpContext.Session);
            session.SetActiveCategory(activeCategory);
            session.SetActiveGame(activeGame);

            var model = new CountryListViewModel
            {
                ActiveCategory = activeCategory,
                ActiveGame = activeGame,
                Categories = context.Categories.ToList(),
                Games = context.Games.ToList()
            };

            IQueryable<Country> query = context.Countries;
            if(activeCategory != "all")
            {
                query = query.Where(c => c.Category.CategoryID.ToLower() == activeCategory.ToLower());
            }
            if(activeGame != "all")
            {
                query = query.Where(c => c.Game.GameID.ToLower() == activeGame.ToLower());
            }

            model.Countries = query.ToList();
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Details(CountryViewModel model)
        {
            TempData["ActiveCategory"] = model.ActiveCategory;
            TempData["ActiveGame"] = model.ActiveGame;
            return RedirectToAction("Details", new { ID = model.Country.CountryID });
        }

        [HttpGet]
        public ViewResult Details(string id)
        {
            var session = new OlympicSession(HttpContext.Session);
            var model = new CountryViewModel
            {
                Country = context.Countries
                    .Include(t => t.Category)
                    .Include(t => t.Game)
                    .FirstOrDefault(t => t.CountryID == id),
                ActiveGame = session.GetActiveGame(),
                ActiveCategory = session.GetActiveCategory()
            };
            return View(model);
        }

        [HttpPost]
        public RedirectToActionResult Add(CountryViewModel model)
        {
            model.Country = context.Countries
                .Include(t => t.Category)
                .Include(t => t.Game)
                .Where(t => t.CountryID == model.Country.CountryID)
                .FirstOrDefault();

            var session = new OlympicSession(HttpContext.Session);
            var countries = session.GetMyCountries();
            countries.Add(model.Country);
            session.SetMyCountries(countries);

            TempData["message"] = $"{model.Country.CountryName} added to your favorites.";

            return RedirectToAction("Index",
                new
                {
                    ActiveCategory = session.GetActiveCategory(),
                    ActiveGame = session.GetActiveGame()
                });
        }
    }
}
