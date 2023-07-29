using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hero_MVC_EFCore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Adicao_do_Film_e_Relacao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    FilmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.FilmId);
                });

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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FilmHero");

            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
