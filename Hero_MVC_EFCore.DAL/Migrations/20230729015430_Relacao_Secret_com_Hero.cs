using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hero_MVC_EFCore.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Relacao_Secret_com_Hero : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SecretIdentityId",
                table: "Heroes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Heroes_SecretIdentityId",
                table: "Heroes",
                column: "SecretIdentityId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Heroes_SecretIdentities_SecretIdentityId",
                table: "Heroes",
                column: "SecretIdentityId",
                principalTable: "SecretIdentities",
                principalColumn: "SecretIdentityId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Heroes_SecretIdentities_SecretIdentityId",
                table: "Heroes");

            migrationBuilder.DropIndex(
                name: "IX_Heroes_SecretIdentityId",
                table: "Heroes");

            migrationBuilder.DropColumn(
                name: "SecretIdentityId",
                table: "Heroes");
        }
    }
}
