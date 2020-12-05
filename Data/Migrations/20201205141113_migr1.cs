using Microsoft.EntityFrameworkCore.Migrations;

namespace Betting.Migrations
{
    public partial class migr1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Colors_PrimaryTeamColorColorId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Colors_SecondaryTeamColorColorId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PrimaryTeamColorColorId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SecondaryTeamColorColorId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "PrimaryTeamColorColorId",
                table: "Teams");

            migrationBuilder.DropColumn(
                name: "SecondaryTeamColorColorId",
                table: "Teams");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PrimaryKitColorId",
                table: "Teams",
                column: "PrimaryKitColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SecondaryKitColorId",
                table: "Teams",
                column: "SecondaryKitColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Colors_PrimaryKitColorId",
                table: "Teams",
                column: "PrimaryKitColorId",
                principalTable: "Colors",
                principalColumn: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Colors_SecondaryKitColorId",
                table: "Teams",
                column: "SecondaryKitColorId",
                principalTable: "Colors",
                principalColumn: "ColorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Colors_PrimaryKitColorId",
                table: "Teams");

            migrationBuilder.DropForeignKey(
                name: "FK_Teams_Colors_SecondaryKitColorId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_PrimaryKitColorId",
                table: "Teams");

            migrationBuilder.DropIndex(
                name: "IX_Teams_SecondaryKitColorId",
                table: "Teams");

            migrationBuilder.AddColumn<int>(
                name: "PrimaryTeamColorColorId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SecondaryTeamColorColorId",
                table: "Teams",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Teams_PrimaryTeamColorColorId",
                table: "Teams",
                column: "PrimaryTeamColorColorId");

            migrationBuilder.CreateIndex(
                name: "IX_Teams_SecondaryTeamColorColorId",
                table: "Teams",
                column: "SecondaryTeamColorColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Colors_PrimaryTeamColorColorId",
                table: "Teams",
                column: "PrimaryTeamColorColorId",
                principalTable: "Colors",
                principalColumn: "ColorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Teams_Colors_SecondaryTeamColorColorId",
                table: "Teams",
                column: "SecondaryTeamColorColorId",
                principalTable: "Colors",
                principalColumn: "ColorId");
        }
    }
}
