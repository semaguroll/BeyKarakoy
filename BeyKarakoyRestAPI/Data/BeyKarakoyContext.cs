
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Data
{
    public class BeyKarakoyContext : DbContext
    {

        public BeyKarakoyContext(DbContextOptions<BeyKarakoyContext> options)
           : base(options)
        {
        }

        public DbSet<BeyKarakoyRestAPI.Models.Category> Category { get; set; }    
        //public DbSet<BeyKarakoyRestAPI.Models.ProductModel> Product { get; set; }

    }
}
