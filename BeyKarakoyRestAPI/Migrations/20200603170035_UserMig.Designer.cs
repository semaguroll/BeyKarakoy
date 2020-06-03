﻿// <auto-generated />
using System;
using BeyKarakoyRestAPI.Persistance.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BeyKarakoyRestAPI.Migrations
{
    [DbContext(typeof(BeyKarakoyContext))]
    [Migration("20200603170035_UserMig")]
    partial class UserMig
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BeyKarakoyRestAPI.Domain.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Category");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "T-shirt"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Sweatshirt"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Gömlek"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Ceket"
                        },
                        new
                        {
                            Id = 5,
                            Name = "Kazak"
                        },
                        new
                        {
                            Id = 6,
                            Name = "Palto"
                        },
                        new
                        {
                            Id = 7,
                            Name = "Deneme"
                        });
                });

            modelBuilder.Entity("BeyKarakoyRestAPI.Domain.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoryId")
                        .IsRequired()
                        .HasColumnType("int")
                        .HasMaxLength(50);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasMaxLength(1000);

                    b.Property<int>("StockCount")
                        .HasColumnType("int")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Product");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0079_1024x1024.jpg?v=1575541690",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey Kadife T-shirt Mavi",
                            Price = 290,
                            StockCount = 0
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 1,
                            Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0005_1024x1024.jpg?v=1575457605",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey Kadife T-shirt Hardal",
                            Price = 290,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 1,
                            Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0015_1024x1024.jpg?v=1575541761",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey Kadife T-shirt Bordo",
                            Price = 290,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 4,
                            CategoryId = 1,
                            Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0091_1024x1024.jpg?v=1575541853",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey Kadife T-shirt Beyaz",
                            Price = 290,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 5,
                            CategoryId = 1,
                            Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0051_1024x1024.jpg?v=1575541914",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey Kadife T-shirt Siyah",
                            Price = 290,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 6,
                            CategoryId = 1,
                            Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0064_1024x1024.jpg?v=1575542231",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey Kadife T-shirt Açık Kahve",
                            Price = 290,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 7,
                            CategoryId = 1,
                            Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0039_1024x1024.jpg?v=1575542276",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey Kadife T-shirt Gri",
                            Price = 290,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 8,
                            CategoryId = 1,
                            Description = "80% cotton, 20% polyester / Model is 182 cm and is wearing a size L",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_9963_1_1024x1024.jpg?v=1551101152",
                            Info = "We are confident that you will be happy with your purchase. However, if you are not satisfied you can return your item for a full refund.",
                            Name = "The Irish Spirit X Bey - Velvet T-shirt Bordo",
                            Price = 290,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 9,
                            CategoryId = 1,
                            Description = "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6662_1024x1024.jpg?v=1540214754",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey X Wunder T-shIrt Siyah",
                            Price = 133,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 10,
                            CategoryId = 1,
                            Description = "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6643_1024x1024.jpg?v=1541585544",
                            Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
                            Name = "Bey X Wunder T-shirt Beyaz",
                            Price = 133,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 11,
                            CategoryId = 1,
                            Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4586_1024x1024.JPG?v=1557488463",
                            Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.",
                            Name = "Pale Pink Organic T-shirt Pembe",
                            Price = 180,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 12,
                            CategoryId = 1,
                            Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4526_1024x1024.JPG?v=1558104419",
                            Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.",
                            Name = "Black Organic T-shirt Siyah",
                            Price = 180,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 13,
                            CategoryId = 1,
                            Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4660_1024x1024.JPG?v=1557489069",
                            Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.",
                            Name = "Ferra Maroon Organic T-shirt Pembe",
                            Price = 180,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 14,
                            CategoryId = 1,
                            Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4640_1024x1024.JPG?v=1557489248",
                            Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.",
                            Name = "Green Organic T-shirt Yeşil",
                            Price = 180,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 15,
                            CategoryId = 1,
                            Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4485_1024x1024.JPG?v=1557489461",
                            Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.",
                            Name = "Grey Organic T-shirt Gri",
                            Price = 180,
                            StockCount = 20
                        },
                        new
                        {
                            Id = 16,
                            CategoryId = 1,
                            Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery",
                            Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4619_2d95aea5-3f80-4172-b5a6-14e09d025537_1024x1024.jpg?v=1558624216",
                            Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.",
                            Name = "Off White Organic T-shirt Beyaz",
                            Price = 180,
                            StockCount = 20
                        });
                });

            modelBuilder.Entity("BeyKarakoyRestAPI.Domain.Models.Sepet", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasMaxLength(1000);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasMaxLength(1000);

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Sepet");
                });

            modelBuilder.Entity("BeyKarakoyRestAPI.Domain.Models.Siparis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Count")
                        .HasColumnType("int")
                        .HasMaxLength(1000);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(1000)")
                        .HasMaxLength(1000);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("Price")
                        .HasColumnType("int")
                        .HasMaxLength(1000);

                    b.Property<string>("Size")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("Siparis");
                });

            modelBuilder.Entity("BeyKarakoyRestAPI.Domain.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Lgn")
                        .HasColumnType("bit")
                        .HasMaxLength(10);

                    b.Property<string>("Mail")
                        .IsRequired()
                        .HasColumnType("nvarchar(200)")
                        .HasMaxLength(200);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.HasKey("Id");

                    b.ToTable("User");
                });
#pragma warning restore 612, 618
        }
    }
}
