using Microsoft.EntityFrameworkCore.Migrations;

namespace OlympicGames.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Sport = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GameID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoImage = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    GameID = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.GameID);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryID", "Sport", "Type" },
                values: new object[,]
                {
                    { "indoorCurling", "Curling", "Indoor" },
                    { "indoorDiving", "Diving", "Indoor" },
                    { "indoorArchery", "Archery", "Indoor" },
                    { "indoorBreakdancing", "Breakdancing", "Indoor" },
                    { "outdoorBobsleigh", "Bobsleigh", "Outdoor" },
                    { "outdoorRoadCycling", "Road Cycling", "Outdoor" },
                    { "outdoorCanoeSprint", "Canoe Sprint", "Outdoor" },
                    { "outdoorSkateboarding", "Skateboarding", "Outdoor" }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryID", "CategoryID", "CountryName", "GameID", "LogoImage" },
                values: new object[,]
                {
                    { "ukraine", "indoorArchery", "Ukraine", "paralympic", "ukraine.png" },
                    { "austria", "outdoorCanoeSprint", "Austria", "paralympic", "austria.png" },
                    { "pakistan", "outdoorCanoeSprint", "Pakistan", "paralympic", "pakistan.png" },
                    { "zimbabwe", "outdoorCanoeSprint", "Zimbabwe", "paralympic", "zimbabwe.png" },
                    { "france", "indoorBreakdancing", "France", "youth", "france.png" },
                    { "slovakia", "outdoorSkateboarding", "Slovakia", "youth", "slovakia.png" },
                    { "russia", "indoorBreakdancing", "Russia", "youth", "russia.png" },
                    { "finland", "outdoorSkateboarding", "Finland", "youth", "finland.png" },
                    { "uruguay", "indoorArchery", "Uruguay", "paralympic", "uruguay.png" },
                    { "portugal", "outdoorSkateboarding", "Portugal", "youth", "portugal.png" },
                    { "cyprus", "indoorBreakdancing", "Cyprus", "youth", "cyprus.png" },
                    { "thailand", "indoorArchery", "Thailand", "paralympic", "thailand.png" },
                    { "brazil", "outdoorRoadCycling", "Brazil", "summer", "brazil.png" },
                    { "netherlands", "outdoorRoadCycling", "Netherlands", "summer", "netherlands.png" },
                    { "mexico", "indoorDiving", "Mexico", "summer", "mexico.png" },
                    { "china", "indoorDiving", "China", "summer", "china.png" },
                    { "germany", "indoorDiving", "Germany", "summer", "germany.png" },
                    { "japan", "outdoorBobsleigh", "Japan", "winter", "japan.png" },
                    { "italy", "outdoorBobsleigh", "Italy", "winter", "italy.jpg" },
                    { "jamaica", "outdoorBobsleigh", "Jamaica", "winter", "jamaica.png" },
                    { "greatBritain", "indoorCurling", "Great Britain", "winter", "greatBritain.png" },
                    { "sweden", "indoorCurling", "Sweden", "winter", "sweden.png" },
                    { "canada", "indoorCurling", "Canada", "winter", "canada.png" },
                    { "usa", "outdoorRoadCycling", "USA", "summer", "usa.png" }
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "GameID", "Name" },
                values: new object[,]
                {
                    { "paralympic", "Paralympics" },
                    { "winter", "Winter Olympics" },
                    { "summer", "Summer Olympics" },
                    { "youth", "Youth Olympics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
