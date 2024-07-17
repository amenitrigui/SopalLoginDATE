using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SopalS.Migrations
{
    /// <inheritdoc />
    public partial class Initialcreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Conteneur",
                columns: table => new
                {
                    Ref = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CodeBarres = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Emplacement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateMiseEnService = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PeriodiciteEtalonnage = table.Column<int>(type: "int", nullable: false),
                    DateDernierEtalonnage = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DernierPoids = table.Column<double>(type: "float", nullable: false),
                    Unite = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserCreate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserUpdate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conteneur", x => x.Ref);
                });

            migrationBuilder.CreateTable(
                name: "HistoEtalonnages",
                columns: table => new
                {
                    Ref = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Poids = table.Column<float>(type: "real", nullable: false),
                    Unite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoEtalonnages", x => x.Ref);
                });

            migrationBuilder.CreateTable(
                name: "Utilisateur",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Utilisateur", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Conteneur");

            migrationBuilder.DropTable(
                name: "HistoEtalonnages");

            migrationBuilder.DropTable(
                name: "Utilisateur");
        }
    }
}
