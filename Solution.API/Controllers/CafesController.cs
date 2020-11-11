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
    public class CafesController : Controller
    {

        private readonly SolutionDBContext _context;

        public CafesController(SolutionDBContext context)
        {
            _context = context;
        }

        // GET: api/Cafes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<data.Cafe>>> GetCafe()
        {

            return new Solution.BS.Cafe(_context).GetAll().ToList();
            
        }

        // GET: api/Cafes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<data.Cafe>> GetCafe(int id)
        {
            var cafe = new Solution.BS.Cafe(_context).GetOneById(id);

            if (cafe == null)
            {
                return NotFound();
            }

            return cafe;
        }

        // PUT: api/Cafes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCafe(int id, data.Cafe cafe)
        {
            if (id != cafe.Id_Cafe)
            {
                return BadRequest();
            }

           

            try
            {
                new Solution.BS.Cafe(_context).Update(cafe);
            }
            catch (Exception ex)
            {
                if (!CafeExists(id))
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

        // POST: api/Cafes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<data.Cafe>> PostCafe(data.Cafe cafe)
        {
            new Solution.BS.Cafe(_context).Insert(cafe);

            return CreatedAtAction("GetCafe", new { id = cafe.Id_Cafe }, cafe);
        }

        // DELETE: api/Cafes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<data.Cafe>> DeleteCafe(int id)
        {
            var cafe = new Solution.BS.Cafe(_context).GetOneById(id);
            if (cafe == null)
            {
                return NotFound();
            }

            new Solution.BS.Cafe(_context).Delete(cafe);

            return cafe;
        }

        private bool CafeExists(int id)
        {
            return (new Solution.BS.Cafe(_context).GetOneById(id) != null);
        }

    }
}
