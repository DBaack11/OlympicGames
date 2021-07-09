
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
                new { CountryID="canada", CountryName="Canada", GameID="winter", CategoryID="indoorCurling", LogoImage="canada.png" },
                new { CountryID = "sweden", CountryName = "Sweden", GameID = "winter", CategoryID = "indoorCurling", LogoImage = "sweden.png" },
                new { CountryID = "greatBritain", CountryName = "Great Britain", GameID = "winter", CategoryID = "indoorCurling", LogoImage = "greatBritain.png" },
                new { CountryID = "jamaica", CountryName = "Jamaica", GameID = "winter", CategoryID = "outdoorBobsleigh", LogoImage = "jamaica.png" },
                new { CountryID = "italy", CountryName = "Italy", GameID = "winter", CategoryID = "outdoorBobsleigh", LogoImage = "italy.jpg" },
                new { CountryID = "japan", CountryName = "Japan", GameID = "winter", CategoryID = "outdoorBobsleigh", LogoImage = "japan.png" },
                new { CountryID = "germany", CountryName = "Germany", GameID = "summer", CategoryID = "indoorDiving", LogoImage = "germany.png" },
                new { CountryID = "china", CountryName = "China", GameID = "summer", CategoryID = "indoorDiving", LogoImage = "china.png" },
                new { CountryID = "mexico", CountryName = "Mexico", GameID = "summer", CategoryID = "indoorDiving", LogoImage = "mexico.png" },
                new { CountryID = "brazil", CountryName = "Brazil", GameID = "summer", CategoryID = "outdoorRoadCycling", LogoImage = "brazil.png" },
                new { CountryID = "netherlands", CountryName = "Netherlands", GameID = "summer", CategoryID = "outdoorRoadCycling", LogoImage = "netherlands.png" },
                new { CountryID = "usa", CountryName = "USA", GameID = "summer", CategoryID = "outdoorRoadCycling", LogoImage = "usa.png" },
                new { CountryID = "thailand", CountryName = "Thailand", GameID = "paralympic", CategoryID = "indoorArchery", LogoImage = "thailand.png" },
                new { CountryID = "uruguay", CountryName = "Uruguay", GameID = "paralympic", CategoryID = "indoorArchery", LogoImage = "uruguay.png" },
                new { CountryID = "ukraine", CountryName = "Ukraine", GameID = "paralympic", CategoryID = "indoorArchery", LogoImage = "ukraine.png" },
                new { CountryID = "austria", CountryName = "Austria", GameID = "paralympic", CategoryID = "outdoorCanoeSprint", LogoImage = "austria.png" },
                new { CountryID = "pakistan", CountryName = "Pakistan", GameID = "paralympic", CategoryID = "outdoorCanoeSprint", LogoImage = "pakistan.png" },
                new { CountryID = "zimbabwe", CountryName = "Zimbabwe", GameID = "paralympic", CategoryID = "outdoorCanoeSprint", LogoImage = "zimbabwe.png" },
                new { CountryID = "france", CountryName = "France", GameID = "youth", CategoryID = "indoorBreakdancing", LogoImage = "france.png" },
                new { CountryID = "cyprus", CountryName = "Cyprus", GameID = "youth", CategoryID = "indoorBreakdancing", LogoImage = "cyprus.png" },
                new { CountryID = "russia", CountryName = "Russia", GameID = "youth", CategoryID = "indoorBreakdancing", LogoImage = "russia.png" },
                new { CountryID = "finland", CountryName = "Finland", GameID = "youth", CategoryID = "outdoorSkateboarding", LogoImage = "finland.png" },
                new { CountryID = "slovakia", CountryName = "Slovakia", GameID = "youth", CategoryID = "outdoorSkateboarding", LogoImage = "slovakia.png" },
                new { CountryID = "portugal", CountryName = "Portugal", GameID = "youth", CategoryID = "outdoorSkateboarding", LogoImage = "portugal.png" }

                );
        }
    }
}
