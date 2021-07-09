using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGames.Models
{
    public class OlympicSession
    {
        private const string CountriesKey = "mycountries";
        private const string CountKey = "countrycount";
        private const string CategoryKey = "category";
        private const string GameKey = "game";

        private ISession session { get; set; }
        public OlympicSession(ISession session)
        {
            this.session = session;
        }

        public void SetMyCountries(List<Country> countries)
        {
            session.SetObject(CountriesKey, countries);
            session.SetInt32(CountKey, countries.Count);
        }

        public List<Country> GetMyCountries() => session.GetObject<List<Country>>(CountriesKey) ?? new List<Country>();
        public int GetMyCountryCount() => session.GetInt32(CountKey) ?? 0;
        public void SetActiveCategory(string activeCategory) => session.SetString(CategoryKey, activeCategory);
        public string GetActiveCategory() => session.GetString(CategoryKey);
        public void SetActiveGame(string activeGame) => session.SetString(GameKey, activeGame);
        public string GetActiveGame() => session.GetString(GameKey);

        public void RemoveMyCountries()
        {
            session.Remove(CountriesKey);
            session.Remove(CountKey);
        }
    }
}
