
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OlympicGames.Models
{
    public class CountryContext : DbContext
    {
        public CountryContext(DbContextOptions<CountryContext> options) : base(options) { }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Game> Games { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Category>().HasData(
                new Category { CategoryID = "indoorCurling", Sport = "Curling", Type="Indoor"},
                new Category { CategoryID = "indoorDiving", Sport = "Diving", Type = "Indoor" },
                new Category { CategoryID = "indoorArchery", Sport = "Archery", Type = "Indoor" },
                new Category { CategoryID = "indoorBreakdancing", Sport = "Breakdancing", Type = "Indoor" },
                new Category { CategoryID = "outdoorBobsleigh", Sport = "Bobsleigh", Type = "Outdoor" },
                new Category { CategoryID = "outdoorRoadCycling", Sport = "Road Cycling", Type = "Outdoor" },
                new Category { CategoryID = "outdoorCanoeSprint", Sport = "Canoe Sprint", Type = "Outdoor" },
                new Category { CategoryID = "outdoorSkateboarding", Sport = "Skateboarding", Type = "Outdoor" }
                );

            modelBuilder.Entity<Game>().HasData(
                new Game { GameID = "winter", Name = "Winter Olympics"},
                new Game { GameID = "summer", Name = "Summer Olympics" },
                new Game { GameID = "paralympic", Name = "Paralympics" },
                new Game { GameID = "youth", Name = "Youth Olympics" }
                );

            modelBuilder.Entity<Country>().HasData(
                new Country { CountryID="canada", CountryName="Canada", GameID="winter", CategoryID="indoorCurling", LogoImage="canada.png" },
                new Country { CountryID = "sweden", CountryName = "Sweden", GameID = "winter", CategoryID = "indoorCurling", LogoImage = "sweden.png" },
                new Country { CountryID = "greatBritain", CountryName = "Great Britain", GameID = "winter", CategoryID = "indoorCurling", LogoImage = "greatBritain.png" },
                new Country { CountryID = "jamaica", CountryName = "Jamaica", GameID = "winter", CategoryID = "outdoorBobsleigh", LogoImage = "jamaica.png" },
                new Country { CountryID = "italy", CountryName = "Italy", GameID = "winter", CategoryID = "outdoorBobsleigh", LogoImage = "italy.jpg" },
                new Country { CountryID = "japan", CountryName = "Japan", GameID = "winter", CategoryID = "outdoorBobsleigh", LogoImage = "japan.png" },
                new Country { CountryID = "germany", CountryName = "Germany", GameID = "summer", CategoryID = "indoorDiving", LogoImage = "germany.png" },
                new Country { CountryID = "china", CountryName = "China", GameID = "summer", CategoryID = "indoorDiving", LogoImage = "china.png" },
                new Country { CountryID = "mexico", CountryName = "Mexico", GameID = "summer", CategoryID = "indoorDiving", LogoImage = "mexico.png" },
                new Country { CountryID = "brazil", CountryName = "Brazil", GameID = "summer", CategoryID = "outdoorRoadCycling", LogoImage = "brazil.png" },
                new Country { CountryID = "netherlands", CountryName = "Netherlands", GameID = "summer", CategoryID = "outdoorRoadCycling", LogoImage = "netherlands.png" },
                new Country { CountryID = "usa", CountryName = "USA", GameID = "summer", CategoryID = "outdoorRoadCycling", LogoImage = "usa.png" },
                new Country { CountryID = "thailand", CountryName = "Thailand", GameID = "paralympic", CategoryID = "indoorArchery", LogoImage = "thailand.png" },
                new Country { CountryID = "uruguay", CountryName = "Uruguay", GameID = "paralympic", CategoryID = "indoorArchery", LogoImage = "uruguay.png" },
                new Country { CountryID = "ukraine", CountryName = "Ukraine", GameID = "paralympic", CategoryID = "indoorArchery", LogoImage = "ukraine.png" },
                new Country { CountryID = "austria", CountryName = "Austria", GameID = "paralympic", CategoryID = "outdoorCanoeSprint", LogoImage = "austria.png" },
                new Country { CountryID = "pakistan", CountryName = "Pakistan", GameID = "paralympic", CategoryID = "outdoorCanoeSprint", LogoImage = "pakistan.png" },
                new Country { CountryID = "zimbabwe", CountryName = "Zimbabwe", GameID = "paralympic", CategoryID = "outdoorCanoeSprint", LogoImage = "zimbabwe.png" },
                new Country { CountryID = "france", CountryName = "France", GameID = "youth", CategoryID = "indoorBreakdancing", LogoImage = "france.png" },
                new Country { CountryID = "cyprus", CountryName = "Cyprus", GameID = "youth", CategoryID = "indoorBreakdancing", LogoImage = "cyprus.png" },
                new Country { CountryID = "russia", CountryName = "Russia", GameID = "youth", CategoryID = "indoorBreakdancing", LogoImage = "russia.png" },
                new Country { CountryID = "finland", CountryName = "Finland", GameID = "youth", CategoryID = "outdoorSkateboarding", LogoImage = "finland.png" },
                new Country { CountryID = "slovakia", CountryName = "Slovakia", GameID = "youth", CategoryID = "outdoorSkateboarding", LogoImage = "slovakia.png" },
                new Country { CountryID = "portugal", CountryName = "Portugal", GameID = "youth", CategoryID = "outdoorSkateboarding", LogoImage = "portugal.png" }

                );
        }
    }
}
