using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hero_MVC_EFCore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Alter_FilmsHeroes_ID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FilmsHeroesId",
                table: "FilmsHeroes");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FilmsHeroesId",
                table: "FilmsHeroes",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
