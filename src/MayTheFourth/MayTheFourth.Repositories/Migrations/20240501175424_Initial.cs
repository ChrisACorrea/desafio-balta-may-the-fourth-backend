using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MayTheFourth.Repositories.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Episode = table.Column<int>(type: "INT4", nullable: false),
                    OpeningCrawl = table.Column<string>(type: "VARCHAR(550)", nullable: false),
                    Director = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Producer = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    ReleaseDate = table.Column<DateTime>(type: "DATE", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()"),
                    UpdatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    RotationPeriod = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    OrbitalPeriod = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Diameter = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Climate = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    Gravity = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    Terrain = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    SurfaceWater = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    Population = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()"),
                    UpdatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Starships",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Model = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Manufacturer = table.Column<string>(type: "VARCHAR(200)", nullable: false),
                    CostInCredits = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Length = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MaxSpeed = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Crew = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Passengers = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CargoCapacity = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    HyperdriveRating = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    MGLT = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Consumables = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Class = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()"),
                    UpdatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Starships", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Model = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Manufacturer = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    CostInCredits = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Length = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    MaxSpeed = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Crew = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Passengers = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    CargoCapacity = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    Consumables = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    Class = table.Column<string>(type: "VARCHAR(120)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()"),
                    UpdatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Characters",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "VARCHAR(150)", nullable: false),
                    Height = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Weight = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    HairColor = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    SkinColor = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    EyeColor = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    BirthYear = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    Gender = table.Column<string>(type: "VARCHAR(20)", nullable: false),
                    PlanetId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()"),
                    UpdatedAt = table.Column<DateTime>(type: "DATE", nullable: false, defaultValueSql: "NOW()")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Characters", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Characters_Planets_PlanetId",
                        column: x => x.PlanetId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MoviePlanet",
                columns: table => new
                {
                    MoviesId = table.Column<Guid>(type: "uuid", nullable: false),
                    PlanetsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MoviePlanet", x => new { x.MoviesId, x.PlanetsId });
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MoviePlanet_Planets_PlanetsId",
                        column: x => x.PlanetsId,
                        principalTable: "Planets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieStarship",
                columns: table => new
                {
                    MoviesId = table.Column<Guid>(type: "uuid", nullable: false),
                    StarshipsId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieStarship", x => new { x.MoviesId, x.StarshipsId });
                    table.ForeignKey(
                        name: "FK_MovieStarship_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieStarship_Starships_StarshipsId",
                        column: x => x.StarshipsId,
                        principalTable: "Starships",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MovieVehicle",
                columns: table => new
                {
                    MoviesId = table.Column<Guid>(type: "uuid", nullable: false),
                    VehiclesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovieVehicle", x => new { x.MoviesId, x.VehiclesId });
                    table.ForeignKey(
                        name: "FK_MovieVehicle_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovieVehicle_Vehicles_VehiclesId",
                        column: x => x.VehiclesId,
                        principalTable: "Vehicles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CharacterMovie",
                columns: table => new
                {
                    CharactersId = table.Column<Guid>(type: "uuid", nullable: false),
                    MoviesId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CharacterMovie", x => new { x.CharactersId, x.MoviesId });
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Characters_CharactersId",
                        column: x => x.CharactersId,
                        principalTable: "Characters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CharacterMovie_Movies_MoviesId",
                        column: x => x.MoviesId,
                        principalTable: "Movies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMovie_MoviesId",
                table: "CharacterMovie",
                column: "MoviesId");

            migrationBuilder.CreateIndex(
                name: "IX_Characters_PlanetId",
                table: "Characters",
                column: "PlanetId");

            migrationBuilder.CreateIndex(
                name: "IX_MoviePlanet_PlanetsId",
                table: "MoviePlanet",
                column: "PlanetsId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieStarship_StarshipsId",
                table: "MovieStarship",
                column: "StarshipsId");

            migrationBuilder.CreateIndex(
                name: "IX_MovieVehicle_VehiclesId",
                table: "MovieVehicle",
                column: "VehiclesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CharacterMovie");

            migrationBuilder.DropTable(
                name: "MoviePlanet");

            migrationBuilder.DropTable(
                name: "MovieStarship");

            migrationBuilder.DropTable(
                name: "MovieVehicle");

            migrationBuilder.DropTable(
                name: "Characters");

            migrationBuilder.DropTable(
                name: "Starships");

            migrationBuilder.DropTable(
                name: "Movies");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
