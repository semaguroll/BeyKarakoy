using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyKarakoyRestAPI.Migrations
{
    public partial class SecondMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Info",
                table: "Product",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Product",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                maxLength: 1000,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Product",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 6, "Palto" },
                    { 4, "Ceket" },
                    { 3, "Gömlek" },
                    { 2, "Sweatshirt" },
                    { 1, "T-shirt" },
                    { 5, "Kazak" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Info", "Name", "Price" },
                values: new object[,]
                {
                    { 16, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4619_2d95aea5-3f80-4172-b5a6-14e09d025537_1024x1024.jpg?v=1558624216", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Off White Organic T-shirt", 180 },
                    { 15, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4485_1024x1024.JPG?v=1557489461", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Grey Organic T-shirt", 180 },
                    { 14, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4640_1024x1024.JPG?v=1557489248", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Green Organic T-shirt", 180 },
                    { 13, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4660_1024x1024.JPG?v=1557489069", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Ferra Maroon Organic T-shirt", 180 },
                    { 12, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4526_1024x1024.JPG?v=1558104419", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Black Organic T-shirt", 180 },
                    { 11, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4586_1024x1024.JPG?v=1557488463", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Pale Pink Organic T-shirt", 180 },
                    { 9, 1, "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6662_1024x1024.jpg?v=1540214754", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey X Wunder T-shIrt", 133 },
                    { 8, 1, "80% cotton, 20% polyester / Model is 182 cm and is wearing a size L", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_9963_1_1024x1024.jpg?v=1551101152", "We are confident that you will be happy with your purchase. However, if you are not satisfied you can return your item for a full refund.", "The Irish Spirit X Bey - Velvet T-shirt", 290 },
                    { 7, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0039_1024x1024.jpg?v=1575542276", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Gri", 290 },
                    { 6, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0064_1024x1024.jpg?v=1575542231", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Açık Kahve", 290 },
                    { 5, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0051_1024x1024.jpg?v=1575541914", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Siyah", 290 },
                    { 4, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0091_1024x1024.jpg?v=1575541853", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Beyaz", 290 },
                    { 3, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0015_1024x1024.jpg?v=1575541761", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Bordo", 290 },
                    { 2, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0005_1024x1024.jpg?v=1575457605", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Hardal", 290 },
                    { 10, 1, "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6643_1024x1024.jpg?v=1541585544", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey X Wunder T-shirt", 133 },
                    { 1, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0079_1024x1024.jpg?v=1575541690", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Mavi", 290 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Category",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 500);

            migrationBuilder.AlterColumn<string>(
                name: "Info",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Product",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 1000);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Product",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Category",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 50);
        }
    }
}
