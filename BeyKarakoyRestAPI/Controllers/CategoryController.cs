using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Threading.Tasks;
using BeyKarakoyRestAPI.Data;
using BeyKarakoyRestAPI.Domain.Models;
using BeyKarakoyRestAPI.Models;
using BeyKarakoyRestAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BeyKarakoyRestAPI.Controllers
{
    [Route("api/ok")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly BeyKarakoyContext _context;

        private readonly ICategoryService _categoryService;

        public CategoryController(BeyKarakoyContext context, ICategoryService categoryService)
        {
            _context = context;
            _categoryService = categoryService;

        }
        [HttpGet]
        //public async Task<IEnumerable<Category>> ListAsync()
        //{
        //    var categories = await _categoryService.ListAsync();

        //    return categories;
        //}
        //// GET: api/Product1
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Category>>> GetProducts()
        {
            return await _context.Category.ToListAsync();
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Category>> GetCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);

            if (category == null)
            {
                return NotFound();
            }

            return category;
        }

        // PUT: api/Products1/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCategory(int id, Category category)
        {
            if (id != category.Id)
            {
                return BadRequest();
            }

            _context.Entry(category).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (System.Data.Entity.Infrastructure.DbUpdateConcurrencyException)
            {
                if (!CategoryExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Products1
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        [HttpPost]
        public async Task<ActionResult<Category>> PostCategory(Category category)
        {
            _context.Category.Add(category);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProduct", new { id = category.Id }, category);
        }

        // DELETE: api/Products1/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Category>> DeleteCategory(int id)
        {
            var category = await _context.Category.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            _context.Category.Remove(category);
            await _context.SaveChangesAsync();

            return category;
        }

        private bool CategoryExists(int id)
        {
            return _context.Category.Any(e => e.Id == id);
        }
    }
}