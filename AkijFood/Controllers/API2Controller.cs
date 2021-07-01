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
    public class API2Controller : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public API2Controller(ApplicationDbContext context)
        {
            _context = context;
        }

        //API 02: Update unit price of Futika to 35

        [HttpPost]
        public ActionResult PuttblColdDrink()
        {
            //foreach (var item in _context.tblColdDrinks.Where(w => w.ColdDrinksName == "Frutika"))
            //{
            //    item.NumUnitPrice = 35;
            //}
            //_context.Entry(tblColdDrink).State = EntityState.Modified;
            tblColdDrink obj = (from item in _context.tblColdDrinks
                            where item.ColdDrinksName == "Frutika"
                            select item).Single();

            obj.UnitPrice = 35;
            _context.SaveChanges();
            return NoContent();
        }
    }
}
