using BeyKarakoyRestAPI.Data;
using BeyKarakoyRestAPI.Domain.Repositories;
using BeyKarakoyRestAPI.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace BeyKarakoyRestAPI.Persistance.Repositories
{
    public class CategoryRepository : BaseRepository, ICategoryRepository
    {
        public CategoryRepository(BeyKarakoyContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Category>> ListAsync()
        {
            return await _context.Category.ToListAsync();
        }
    }
}
