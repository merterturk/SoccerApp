using Microsoft.EntityFrameworkCore.Migrations;

namespace SoccerApp.Dal.Migrations
{
    public partial class ImageColumnAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "HomeTeams",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "AwayTeams",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "HomeTeams");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "AwayTeams");
        }
    }
}
