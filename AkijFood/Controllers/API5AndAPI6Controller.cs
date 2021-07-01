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
    public class API5AndAPI6Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public API5AndAPI6Controller(ApplicationDbContext context)
        {
            _context = context;
        }


        //API 05: Delete All products if it’s quantity is less than 500
        [HttpPost]
        public async Task<IActionResult> DeleteLessThan()
        {
            var itemtoremove = _context.tblColdDrinks.Where(x => x.NumQuantity < 500).First();

            _context.tblColdDrinks.Remove(itemtoremove);
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpGet]
        //API 06: Find total price of all products
        public ActionResult TotalPrice()
        {
            var itemtoremove = _context.tblColdDrinks.Sum(x => x.NumUnitPrice);
            return Ok(itemtoremove);
        }
    }
}
