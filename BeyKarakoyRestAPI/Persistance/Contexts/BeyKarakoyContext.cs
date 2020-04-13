﻿
using BeyKarakoyRestAPI.Domain.Models;
using BeyKarakoyRestAPI.Models;
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

        public DbSet<Category> Category { get; set; }
        //public object Product { get; internal set; }
        public DbSet<Product> Product { get; set; }


    }
}

