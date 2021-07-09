using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
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
                query = query.Where(t => t.CategoryID.ToLower() == activeCategory.ToLower());
            }
            if(activeGame != "all")
            {
                query = query.Where(t => t.GameID.ToLower() == activeGame.ToLower());
            }

            model.Countries = query.ToList();
            return View(model);
        }
    }
}
