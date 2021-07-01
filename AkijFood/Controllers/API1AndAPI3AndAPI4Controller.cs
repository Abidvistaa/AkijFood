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
    public class API1AndAPI3AndAPI4Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public API1AndAPI3AndAPI4Controller(ApplicationDbContext context)
        {
            _context = context;
        }


        // POST: api/tblColdDrinkGivenTask

        // API 01: Insert Mojo (Quantity 575, Unit Price 15)
        [HttpPost]
        public async Task<ActionResult<tblColdDrink>> PosttblColdDrink(tblColdDrink tblColdDrink)
        {
            tblColdDrink coldDrink = new tblColdDrink();
            coldDrink.ColdDrinksName = "Mojo";
            coldDrink.Quantity = 575;
            coldDrink.UnitPrice = 15;
            _context.tblColdDrinks.Add(coldDrink);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GettblColdDrink", new { id = tblColdDrink.ColdDrinksId }, tblColdDrink);
        }

        // DELETE: api/tblColdDrink

        //API 03: Delete Speed from the table
        [HttpDelete]
        public async Task<IActionResult> DeletetblColdDrink()
        {
            var itemtoremove = _context.tblColdDrinks.Where(x=>x.ColdDrinksName == "Speed").First();

            _context.tblColdDrinks.Remove(itemtoremove);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // GET: api/tblColdDrink

        //API 04: Find remaining products name
        [HttpGet]
        public async Task<ActionResult<IEnumerable<tblColdDrink>>> GettblColdDrinks()
        {
            var item = _context.tblColdDrinks.Select(x => new { x.ColdDrinksName }).ToList();
            return Ok(item);
        }
    }
}
