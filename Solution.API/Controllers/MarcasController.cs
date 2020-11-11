using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.DAL.EF;
using data= Solution.DO.Objects;

namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarcasController : Controller
    {

        private readonly SolutionDBContext _context;

        public MarcasController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Marcas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Marcas>>> GetMarcas()
        {
            return new Solution.BS.Marcas(_context).GetAll().ToList();
        }

        // GET: api/Marcas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Marcas>> GetMarcas(int id)
        {
            var cafe = new Solution.BS.Marcas(_context).GetOneById(id);

            if (cafe == null)
            {
                return NotFound();
            }

            return cafe;
        }

        // PUT: api/Marcas/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMarcas(int id, data.Marcas marcas)
        {
            if (id != marcas.Id_Marca)
            {
                return BadRequest();
            }

           

            try
            {
                new Solution.BS.Marcas(_context).Update(marcas);
            }
            catch (Exception ex)
            {
                if (!MarcasExists(id))
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

        // POST: api/Marcas
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.Marcas>> PostMarcas(data.Marcas marcas)
        {
            new Solution.BS.Marcas(_context).Insert(marcas);

            return CreatedAtAction("GetMarcas", new { id = marcas.Id_Marca }, marcas);
        }

        // DELETE: api/Marcas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Marcas>> DeleteMarcas(int id)
        {
            var marcas = new Solution.BS.Marcas(_context).GetOneById(id);
            if (marcas == null)
            {
                return NotFound();
            }

            new Solution.BS.Marcas(_context).Delete(marcas);

            return marcas;
        }

        private bool MarcasExists(int id)
        {
            return (new Solution.BS.Cafe(_context).GetOneById(id) != null);
        }

    }
}
