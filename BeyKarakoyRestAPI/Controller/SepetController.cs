using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeyKarakoyRestAPI.Domain.Models;
using BeyKarakoyRestAPI.Persistance.Context;

namespace BeyKarakoyRestAPI.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class SepetController : ControllerBase
    {
        private readonly BeyKarakoyContext _context;

        public SepetController(BeyKarakoyContext context)
        {
            _context = context;
        }

        // GET: api/Sepet
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Sepet>>> GetSepet()
        {
            return await _context.Sepet.ToListAsync();
        }

        // GET: api/Sepet/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Sepet>> GetSepet(int id)
        {
            var sepet = await _context.Sepet.FindAsync(id);

            if (sepet == null)
            {
                return NotFound();
            }

            return sepet;
        }

        // PUT: api/Sepet/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutSepet(int id, Sepet sepet)
        {
            if (id != sepet.Id)
            {
                return BadRequest();
            }

            _context.Entry(sepet).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!SepetExists(id))
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

        // POST: api/Sepet
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public void PostSepet(Sepet sepet)
        {
            _context.Sepet.Add(sepet);
             _context.SaveChangesAsync();
            
        }

        // DELETE: api/Sepet/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Sepet>> DeleteSepet(int id)
        {
            var sepet = await _context.Sepet.FindAsync(id);
            if (sepet == null)
            {
                return NotFound();
            }

            _context.Sepet.Remove(sepet);
            await _context.SaveChangesAsync();

            return sepet;
        }

        private bool SepetExists(int id)
        {
            return _context.Sepet.Any(e => e.Id == id);
        }
    }
}
