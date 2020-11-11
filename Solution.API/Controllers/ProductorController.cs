using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Solution.DAL.EF;
using data = Solution.DO.Objects;
namespace Solution.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductorController : Controller


    {

        private readonly SolutionDBContext _context;

        public ProductorController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Productor
        [HttpGet]
        public  async  Task<ActionResult<IEnumerable<data.Productor>>>  GetProductor()
        {
           
             return  new Solution.BS.Productor(_context).GetAll().ToList();
        }

        // GET: api/Productor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Productor>> GetProductor(int id)
        {
            var productor = new Solution.BS.Productor(_context).GetOneById(id);

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
        public async Task<IActionResult> PutProductor(int id, data.Productor productor)
        {
            if (id != productor.Id_Productor)
            {
                return BadRequest();
            }

          

            try
            {
                new Solution.BS.Productor(_context).Update(productor);
            }
            catch (Exception ex)
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
        public async Task<ActionResult<data.Productor>> PostProductor(data.Productor productor)
        {
            new Solution.BS.Productor(_context).Insert(productor);

            return CreatedAtAction("GetProductor", new { id = productor.Id_Productor }, productor);
        }

        // DELETE: api/Productor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Productor>> DeleteProductor(int id)
        {
            var productor = new Solution.BS.Productor(_context).GetOneById(id);
            if (productor == null)
            {
                return NotFound();
            }

            new Solution.BS.Productor(_context).Delete(productor);

            return productor;
        }

        private bool ProductorExists(int id)
        {
            return (new Solution.BS.Productor(_context).GetOneById(id) != null);
        }
    }
}
