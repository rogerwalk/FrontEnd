using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Solution.APIW.Models;

namespace Solution.APIW.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductorController : ControllerBase
    {
        private readonly ProyectoContext _context;

        public ProductorController(ProyectoContext context)
        {
            _context = context;
        }

        // GET: api/Productor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productor>>> GetProductor()
        {
            return await _context.Productor.ToListAsync();
        }

        // GET: api/Productor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Productor>> GetProductor(int id)
        {
            var productor = await _context.Productor.FindAsync(id);

            if (productor == null)
            {
                return NotFound();
            }

            return productor;
        }

        // PUT: api/Productor/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProductor(int id, Productor productor)
        {
            if (id != productor.IdProductor)
            {
                return BadRequest();
            }

            _context.Entry(productor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductorExists(id))
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

        // POST: api/Productor
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<Productor>> PostProductor(Productor productor)
        {
            _context.Productor.Add(productor);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetProductor", new { id = productor.IdProductor }, productor);
        }

        // DELETE: api/Productor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Productor>> DeleteProductor(int id)
        {
            var productor = await _context.Productor.FindAsync(id);
            if (productor == null)
            {
                return NotFound();
            }

            _context.Productor.Remove(productor);
            await _context.SaveChangesAsync();

            return productor;
        }

        private bool ProductorExists(int id)
        {
            return _context.Productor.Any(e => e.IdProductor == id);
        }
    }
}
