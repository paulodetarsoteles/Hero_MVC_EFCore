using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hero_MVC_EFCore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Adição_Enum_ao_Power : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Powers",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HeroId",
                table: "Powers",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

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
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers");

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Powers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "HeroId",
                table: "Powers",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Powers_Heroes_HeroId",
                table: "Powers",
                column: "HeroId",
                principalTable: "Heroes",
                principalColumn: "HeroId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
