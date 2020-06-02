using Microsoft.EntityFrameworkCore.Migrations;

namespace BeyKarakoyRestAPI.Migrations
{
    public partial class FirstMig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StockCount = table.Column<int>(maxLength: 500, nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    Description = table.Column<string>(maxLength: 1000, nullable: false),
                    CategoryId = table.Column<int>(maxLength: 50, nullable: false),
                    Info = table.Column<string>(maxLength: 1000, nullable: false),
                    Price = table.Column<int>(maxLength: 1000, nullable: false),
                    Image = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sepet",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(maxLength: 1000, nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    Size = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(maxLength: 1000, nullable: false),
                    Image = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sepet", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Siparis",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Count = table.Column<int>(maxLength: 1000, nullable: false),
                    Name = table.Column<string>(maxLength: 500, nullable: false),
                    Size = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(maxLength: 1000, nullable: false),
                    Image = table.Column<string>(maxLength: 1000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Siparis", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "T-shirt" },
                    { 2, "Sweatshirt" },
                    { 3, "Gömlek" },
                    { 4, "Ceket" },
                    { 5, "Kazak" },
                    { 6, "Palto" },
                    { 7, "Deneme" }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Image", "Info", "Name", "Price", "StockCount" },
                values: new object[,]
                {
                    { 14, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4640_1024x1024.JPG?v=1557489248", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Green Organic T-shirt", 180, 20 },
                    { 13, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4660_1024x1024.JPG?v=1557489069", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Ferra Maroon Organic T-shirt", 180, 20 },
                    { 12, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4526_1024x1024.JPG?v=1558104419", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Black Organic T-shirt", 180, 20 },
                    { 11, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4586_1024x1024.JPG?v=1557488463", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Pale Pink Organic T-shirt", 180, 20 },
                    { 10, 1, "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6643_1024x1024.jpg?v=1541585544", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey X Wunder T-shirt", 133, 20 },
                    { 9, 1, "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6662_1024x1024.jpg?v=1540214754", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey X Wunder T-shIrt", 133, 20 },
                    { 8, 1, "80% cotton, 20% polyester / Model is 182 cm and is wearing a size L", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_9963_1_1024x1024.jpg?v=1551101152", "We are confident that you will be happy with your purchase. However, if you are not satisfied you can return your item for a full refund.", "The Irish Spirit X Bey - Velvet T-shirt", 290, 20 },
                    { 5, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0051_1024x1024.jpg?v=1575541914", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Siyah", 290, 20 },
                    { 6, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0064_1024x1024.jpg?v=1575542231", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Açık Kahve", 290, 20 },
                    { 15, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4485_1024x1024.JPG?v=1557489461", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Grey Organic T-shirt", 180, 20 },
                    { 4, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0091_1024x1024.jpg?v=1575541853", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Beyaz", 290, 20 },
                    { 3, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0015_1024x1024.jpg?v=1575541761", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Bordo", 290, 20 },
                    { 2, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0005_1024x1024.jpg?v=1575457605", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Hardal", 290, 20 },
                    { 1, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0079_1024x1024.jpg?v=1575541690", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Mavi", 290, 0 },
                    { 7, 1, "%80 Pamuk %20 Polyester /Model 182 cm,beden M", "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0039_1024x1024.jpg?v=1575542276", "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", "Bey Kadife T-shirt Gri", 290, 20 },
                    { 16, 1, "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4619_2d95aea5-3f80-4172-b5a6-14e09d025537_1024x1024.jpg?v=1558624216", "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", "Off White Organic T-shirt", 180, 20 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Sepet");

            migrationBuilder.DropTable(
                name: "Siparis");
        }
    }
}
