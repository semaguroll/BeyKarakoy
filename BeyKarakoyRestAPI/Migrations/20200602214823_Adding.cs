using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyKarakoyRestAPI.Migrations
{
    public partial class Adding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "The Irish Spirit X Bey - Velvet T-shirt Bordo");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Bey X Wunder T-shIrt Siyah");

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

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Black Organic T-shirt Siyah");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Ferra Maroon Organic T-shirt Pembe");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Green Organic T-shirt Yeşil");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Grey Organic T-shirt Gri");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Off White Organic T-shirt Beyaz");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8,
                column: "Name",
                value: "The Irish Spirit X Bey - Velvet T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9,
                column: "Name",
                value: "Bey X Wunder T-shIrt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10,
                column: "Name",
                value: "Bey X Wunder T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11,
                column: "Name",
                value: "Pale Pink Organic T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: "Black Organic T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13,
                column: "Name",
                value: "Ferra Maroon Organic T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: "Green Organic T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15,
                column: "Name",
                value: "Grey Organic T-shirt");

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16,
                column: "Name",
                value: "Off White Organic T-shirt");
        }
    }
}
