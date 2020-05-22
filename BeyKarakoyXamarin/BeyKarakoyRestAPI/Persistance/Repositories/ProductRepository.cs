using BeyKarakoyRestAPI.Data;
using BeyKarakoyRestAPI.Domain.Models;
using BeyKarakoyRestAPI.Domain.Repositories;
using BeyKarakoyRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Persistance.Repositories
{
    public class ProductRepository : BaseRepository,IProductRepository
    {
        public ProductRepository(BeyKarakoyContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> ListAsync()
        {
            return await _context.Product.ToListAsync();
        }
    }
}
