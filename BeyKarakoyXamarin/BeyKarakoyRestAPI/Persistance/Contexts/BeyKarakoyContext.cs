
using BeyKarakoyRestAPI.Domain.Models;
using BeyKarakoyRestAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data.Entity.Migrations;

namespace BeyKarakoyRestAPI.Data
{
    public class BeyKarakoyContext : DbContext
    {

        public BeyKarakoyContext(DbContextOptions<BeyKarakoyContext> options)
           : base(options)
        {
        }


        public DbSet<Category> Category { get; set; }
        //public object Product { get; internal set; }
        public DbSet<Product> Product { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);


            builder.Entity<Category>().ToTable("Category");
            builder.Entity<Category>().HasKey(p => p.Id);
            builder.Entity<Category>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Category>().Property(p => p.Name).IsRequired().HasMaxLength(50);
            //builder.Entity<Category>().HasMany(p => p.Product).WithOne(p => p.Category).HasForeignKey(p => p.CategoryId);

            builder.Entity<Category>().HasData(
                new Category { Id = 1, Name = "T-shirt" },
            new Category { Id = 2, Name = "Sweatshirt" },
            new Category { Id = 3, Name = "Gömlek" },
            new Category { Id = 4, Name = "Ceket" },
            new Category { Id = 5, Name = "Kazak" },
            new Category { Id = 6, Name = "Palto" },
             new Category { Id = 7, Name = "Deneme" });

            builder.Entity<Product>().ToTable("Product");
            builder.Entity<Product>().HasKey(p => p.Id);
            builder.Entity<Product>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Entity<Product>().Property(p => p.Name).IsRequired().HasMaxLength(500);
            builder.Entity<Product>().Property(p => p.Description).IsRequired().HasMaxLength(1000);
            //builder.Entity<Product>().Property(p => p.Size).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.CategoryId).IsRequired().HasMaxLength(50);
            builder.Entity<Product>().Property(p => p.Info).IsRequired().HasMaxLength(1000);
            builder.Entity<Product>().Property(p => p.Price).IsRequired().HasMaxLength(1000);
            builder.Entity<Product>().Property(p => p.Image).IsRequired().HasMaxLength(1000);

            builder.Entity<Product>().HasData(
         new Product
         {
             Id = 1,
             Name = "Bey Kadife T-shirt Mavi",
             Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M",
             CategoryId = 1,
             Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.",
             Price = 290,
             Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0079_1024x1024.jpg?v=1575541690"
         },
         new Product { Id = 2, Name = "Bey Kadife T-shirt Hardal", Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 290, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0005_1024x1024.jpg?v=1575457605" },
         new Product { Id = 3, Name = "Bey Kadife T-shirt Bordo", Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 290, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0015_1024x1024.jpg?v=1575541761" },
         new Product { Id = 4, Name = "Bey Kadife T-shirt Beyaz", Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 290, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0091_1024x1024.jpg?v=1575541853" },
         new Product { Id = 5, Name = "Bey Kadife T-shirt Siyah", Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 290, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0051_1024x1024.jpg?v=1575541914" },
          new Product { Id = 6, Name = "Bey Kadife T-shirt Açık Kahve", Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 290, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0064_1024x1024.jpg?v=1575542231" },
         new Product { Id = 7, Name = "Bey Kadife T-shirt Gri", Description = "%80 Pamuk %20 Polyester /Model 182 cm,beden M", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 290, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/Bey-FW-_20-0039_1024x1024.jpg?v=1575542276" },
         new Product { Id = 8, Name = "The Irish Spirit X Bey - Velvet T-shirt", Description = "80% cotton, 20% polyester / Model is 182 cm and is wearing a size L", CategoryId = 1, Info = "We are confident that you will be happy with your purchase. However, if you are not satisfied you can return your item for a full refund.", Price = 290, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_9963_1_1024x1024.jpg?v=1551101152" },
         new Product { Id = 9, Name = "Bey X Wunder T-shIrt", Description = "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 133, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6662_1024x1024.jpg?v=1540214754" },
         new Product { Id = 10, Name = "Bey X Wunder T-shirt", Description = "100% pamuk / Yuvarlak yaka /Model 185 cm beden M / 2 günde teslimat", CategoryId = 1, Info = "Satın alacağınız üründen memnun kalacağınıza eminiz. Ancak memnun kalmadığınız takdirde değişim veya tam iade yapabilirsiniz.", Price = 133, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_6643_1024x1024.jpg?v=1541585544" },
         new Product { Id = 11, Name = "Pale Pink Organic T-shirt", Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", CategoryId = 1, Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", Price = 180, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4586_1024x1024.JPG?v=1557488463" },
         new Product { Id = 12, Name = "Black Organic T-shirt", Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", CategoryId = 1, Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", Price = 180, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4526_1024x1024.JPG?v=1558104419" },
         new Product { Id = 13, Name = "Ferra Maroon Organic T-shirt", Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", CategoryId = 1, Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", Price = 180, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4660_1024x1024.JPG?v=1557489069" },
         new Product { Id = 14, Name = "Green Organic T-shirt", Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", CategoryId = 1, Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", Price = 180, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4640_1024x1024.JPG?v=1557489248" },
         new Product { Id = 15, Name = "Grey Organic T-shirt", Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", CategoryId = 1, Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", Price = 180, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4485_1024x1024.JPG?v=1557489461" },
          new Product { Id = 16, Name = "Off White Organic T-shirt", Description = "Straight fit / % 100 organic cotton GOTS /Rounded neckline / Color: Ferra Maroon /Fits true to size,take your normal size /Model is 182 cm and wearing a size M / 2 days delivery", CategoryId = 1, Info = "This T-Shirt is GOTS certified.GOTS is the world leading certification standard for organic textiles including both ecological and social criteria.GOTS covers every step in the production process from fiber to finished garment.This garment is 3rd party certified.We are confident that you will be happy with your purchase.However, if you are not satisfied you can return your item for a full refund.", Price = 180, Image = "https://cdn.shopify.com/s/files/1/1432/5782/products/IMG_4619_2d95aea5-3f80-4172-b5a6-14e09d025537_1024x1024.jpg?v=1558624216" });


        }


    }
}

