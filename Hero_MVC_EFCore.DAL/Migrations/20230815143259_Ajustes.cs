using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hero_MVC_EFCore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Ajustes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmsHeroes_Heroes_HeroId",
                table: "FilmsHeroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_Films_FilmId",
                table: "Heroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Heroes",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_HeroId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "FilmId",
                table: "Heroes");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Heroes",
                table: "Heroes",
                column: "HeroId");

            migrationBuilder.CreateTable(
                name: "FilmHero",
                columns: table => new
                {
                    FilmsFilmId = table.Column<int>(type: "int", nullable: false),
                    HeroesHeroId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FilmHero", x => new { x.FilmsFilmId, x.HeroesHeroId });
                    table.ForeignKey(
                        name: "FK_FilmHero_Films_FilmsFilmId",
                        column: x => x.FilmsFilmId,
                        principalTable: "Films",
                        principalColumn: "FilmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FilmHero_Heroes_HeroesHeroId",
                        column: x => x.HeroesHeroId,
                        principalTable: "Heroes",
                        principalColumn: "HeroId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FilmHero_HeroesHeroId",
                table: "FilmHero",
                column: "HeroesHeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmsHeroes_Heroes_HeroId",
                table: "FilmsHeroes",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "HeroId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "HeroId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FilmsHeroes_Heroes_HeroId",
                table: "FilmsHeroes");

            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers");

            migrationBuilder.DropTable(
                name: "FilmHero");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Heroes",
                table: "Heroes");

            migrationBuilder.AddColumn<int>(
                name: "FilmId",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Heroes",
                table: "Heroes",
                columns: new[] { "FilmId", "HeroId" });

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_HeroId",
                table: "Heroes",
                column: "HeroId");

            migrationBuilder.AddForeignKey(
                name: "FK_FilmsHeroes_Heroes_HeroId",
                table: "FilmsHeroes",
                column: "HeroId",
                principalTable: "Heroes",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_Films_FilmId",
                table: "Heroes",
                column: "FilmId",
                principalTable: "Films",
                principalColumn: "FilmId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers",
                column: "HeroId",
                principalTable: "Heroes");
        }
    }
}
