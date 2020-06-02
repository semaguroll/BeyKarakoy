using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyKarakoyRestAPI.Migrations
{
    public partial class AddColor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Bey X Wunder T-shirt Beyaz");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pale Pink Organic T-shirt Pembe");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Bey X Wunder T-shirt Pembe");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pale Pink Organic T-shirt Yeşil");
        }
    }
}
