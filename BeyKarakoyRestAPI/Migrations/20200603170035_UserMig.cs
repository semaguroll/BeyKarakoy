using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyKarakoyRestAPI.Migrations
{
    public partial class UserMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Lgn",
                table: "User",
                maxLength: 10,
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Lgn",
                table: "User");
        }
    }
}
