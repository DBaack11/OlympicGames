using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGames.Models
{
    public class CountryListViewModel
    {
        public List<Country> Countries { get; set; }
        public string ActiveCategory { get; set; }
        public string ActiveGame { get; set; }

        private List<Category> categories;
        public List<Category> Categories {
            get => categories; 
            set
            {
                categories = value;
                categories.Insert(0, new Category { CategoryID = "all", Sport = "All", Type = "All" });
            } 
        }

        private List<Game> games;
        public List<Game> Games
        {
            get => games;
            set
            {
                games = value;
                games.Insert(0, new Game { GameID = "all", Name = "All" });
            }
        }

        public string CheckActiveCategory(string c) => 
            c.ToLower() == ActiveCategory.ToLower() ? "active" : "";

        public string CheckActiveGame(string g) =>
            g.ToLower() == ActiveGame.ToLower() ? "active" : "";

    }
}
