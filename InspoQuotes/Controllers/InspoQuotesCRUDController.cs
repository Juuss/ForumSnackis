using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InspoQuotes.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InspoQuotesCRUDController : ControllerBase
    {
        private readonly Model.InspoQuoteContext _context;
        public InspoQuotesCRUDController(Model.InspoQuoteContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Model.InspoQuote>>> GetInspoQuotes()
        {
            return await _context.InspoQuotes.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Model.InspoQuote>> GetInspoQuote(long id)
        {
            var inspoQuote = await _context.InspoQuotes.FindAsync(id);
            if (inspoQuote == null)
            {
                return NotFound();
            }
            return inspoQuote;
        }
        [HttpGet("Random")]
        public async Task<ActionResult<Model.InspoQuote>> GetRandom()
        {
            var random = new Random();
            
            var inspoQuotes = await _context.InspoQuotes.ToListAsync();
            if (inspoQuotes.Count == 0)
            {
                return NotFound();
            }
            var num = random.Next(0,inspoQuotes.Count);
            var inspoQuote = inspoQuotes[num];

            if (inspoQuote == null)
            {
                return NotFound();
            }

            return inspoQuote;
        }
        [HttpPost]
        public async Task<ActionResult<Model.InspoQuote>> PostInspoQuote(Model.InspoQuote InspoQuote)
        {
            _context.InspoQuotes.Add(InspoQuote);
            var x = await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetInspoQuote), new { id = InspoQuote.Id }, InspoQuote);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Model.InspoQuote>> DeleteInspoQuote(long id)
        {
            var inspoQuote = await _context.InspoQuotes.FindAsync(id);
            if (inspoQuote == null)
            {
                return NotFound();
            }
            _context.InspoQuotes.Remove(inspoQuote);
            await _context.SaveChangesAsync();
            return inspoQuote;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutInspoQuote(long id, Model.InspoQuote InspoQuote)
        {
            if(id != InspoQuote.Id)
            {
                return BadRequest();
            }
            _context.Entry(InspoQuote).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InspoQuoteExist(id))
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
        private bool InspoQuoteExist(long id)
        {
            return _context.InspoQuotes.Any(m => m.Id == id);
        }
    }
}
