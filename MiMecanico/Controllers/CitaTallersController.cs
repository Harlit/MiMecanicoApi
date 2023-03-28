using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MiMecanico.Data;
using MiMecanico.Models;

namespace MiMecanico.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitaTallersController : ControllerBase
    {
        private readonly Contexto _context;

        public CitaTallersController(Contexto context)
        {
            _context = context;
        }

        // GET: api/CitaTallers
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CitaTaller>>> GetCitaTallers()
        {
          if (_context.CitaTallers == null)
          {
              return NotFound();
          }
            return await _context.CitaTallers.ToListAsync();
        }

        // GET: api/CitaTallers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CitaTaller>> GetCitaTaller(int id)
        {
          if (_context.CitaTallers == null)
          {
              return NotFound();
          }
            var citaTaller = await _context.CitaTallers.FindAsync(id);

            if (citaTaller == null)
            {
                return NotFound();
            }

            return citaTaller;
        }

        // PUT: api/CitaTallers/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCitaTaller(int id, CitaTaller citaTaller)
        {
            if (id != citaTaller.CitaTallerId)
            {
                return BadRequest();
            }

            _context.Entry(citaTaller).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CitaTallerExists(id))
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

        // POST: api/CitaTallers
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CitaTaller>> PostCitaTaller(CitaTaller citaTaller)
        {
          if (_context.CitaTallers == null)
          {
              return Problem("Entity set 'Contexto.CitaTallers'  is null.");
          }
            _context.CitaTallers.Add(citaTaller);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCitaTaller", new { id = citaTaller.CitaTallerId }, citaTaller);
        }

        // DELETE: api/CitaTallers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCitaTaller(int id)
        {
            if (_context.CitaTallers == null)
            {
                return NotFound();
            }
            var citaTaller = await _context.CitaTallers.FindAsync(id);
            if (citaTaller == null)
            {
                return NotFound();
            }

            _context.CitaTallers.Remove(citaTaller);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CitaTallerExists(int id)
        {
            return (_context.CitaTallers?.Any(e => e.CitaTallerId == id)).GetValueOrDefault();
        }
    }
}
