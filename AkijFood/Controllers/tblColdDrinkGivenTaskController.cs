using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AkijFood.Data;
using AkijFood.Models;

namespace AkijFood.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class tblColdDrinkGivenTaskController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public tblColdDrinkGivenTaskController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/tblColdDrinkGivenTask
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tblColdDrink>>> GettblColdDrinks()
        {
            return await _context.tblColdDrinks.ToListAsync();
        }

        // GET: api/tblColdDrinkGivenTask/5
        [HttpGet("{id}")]
        public async Task<ActionResult<tblColdDrink>> GettblColdDrink(int id)
        {
            var tblColdDrink = await _context.tblColdDrinks.FindAsync(id);

            if (tblColdDrink == null)
            {
                return NotFound();
            }

            return tblColdDrink;
        }

        // PUT: api/tblColdDrinkGivenTask/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PuttblColdDrink(int id, tblColdDrink tblColdDrink)
        {
            if (id != tblColdDrink.ColdDrinksId)
            {
                return BadRequest();
            }

            _context.Entry(tblColdDrink).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!tblColdDrinkExists(id))
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

        // POST: api/tblColdDrinkGivenTask
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // API 01: Insert Mojo (Quantity 575, Unit Price 15)
        [HttpPost]
        public async Task<ActionResult<tblColdDrink>> MojotblColdDrink(tblColdDrink tblColdDrink)
        {
            tblColdDrink coldDrink = new tblColdDrink();
            coldDrink.ColdDrinksName = "Mojo";
            coldDrink.NumQuantity = 575;
            coldDrink.NumUnitPrice = 15;
            _context.tblColdDrinks.Add(coldDrink);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GettblColdDrink", new { id = tblColdDrink.ColdDrinksId }, tblColdDrink);
        }

        // DELETE: api/tblColdDrinkGivenTask/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletetblColdDrink(int id)
        {
            var tblColdDrink = await _context.tblColdDrinks.FindAsync(id);
            if (tblColdDrink == null)
            {
                return NotFound();
            }

            _context.tblColdDrinks.Remove(tblColdDrink);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool tblColdDrinkExists(int id)
        {
            return _context.tblColdDrinks.Any(e => e.ColdDrinksId == id);
        }
    }
}
