using LABB4MVCRAZOR.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace LABB4MVCRAZOR.Controllers
{
    public class LendingsController : Controller
    {
        private readonly MvcRazorDbContext _context;

        public LendingsController(MvcRazorDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> LendingBooks()
        {
            try
            {
                // Hämta alla lån från databasen inklusive relaterade böcker och kunder
                var lendings = await _context.Lendings
                    .Include(l => l.Book)
                    .Include(l => l.Customer)
                    .ToListAsync();

                // Returnera vyn med listan över lån (inklusive bok- och kundinformation)
                return View("CustomerLendings", lendings);
            }
            catch (Exception ex)
            {
                // Hantera eventuella fel och returnera felmeddelande
                return StatusCode(500, $"An error occurred: {ex.Message}");
            }
        }

    }
}
