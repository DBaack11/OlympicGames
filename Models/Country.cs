using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGames.Models
{
    public class Country
    {
        public string CountryID { get; set; }
        public string CountryName { get; set; }
        public Game Game { get; set; }
        public Category Category { get; set; }
        public string LogoImage { get; set; }

    }
}
