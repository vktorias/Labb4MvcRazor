using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using LABB4MVCRAZOR.Data;
using LABB4MVCRAZOR.Models;

namespace LABB4MVCRAZOR.Controllers

{
    public class CustomersController : Controller
    {
        private readonly MvcRazorDbContext _context;
        public CustomersController(MvcRazorDbContext context)
        {
            _context = context;
        }

        // GET: Customers 

        public async Task<IActionResult> Index(int? id)
        {
            if (id.HasValue)
            {
                // Lägg till kundens ID i ViewData eller ViewBag 
                ViewData["CustomerId"] = id.Value;
                // Redirect to the edit action with the provided customer ID 
                return RedirectToAction("Edit", new { id = id.Value });
            }
            else
            { 
                return View(await _context.Customers.ToListAsync());
            }
        }

        // GET: Customers/Details/5 
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);
            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        [HttpGet]
        public async Task<IActionResult> SearchCustomer(string searchValue)
        {
            if (string.IsNullOrEmpty(searchValue))
            {
                ViewBag.SearchPerformed = false;
                ViewBag.Message = "Please enter a search value.";
                return View("SearchDetails", await _context.Customers.ToListAsync());
            }

            var customers = await _context.Customers
                .Where(c => c.CustomerName.Contains(searchValue) || c.CustomerId.ToString() == searchValue)
                .ToListAsync();

            ViewBag.SearchPerformed = true;

            if (customers.Count == 0)
            {
                ViewBag.Message = "No results found.";
            }

            return View("SearchDetails", customers);
        }

        // GET: Customers/Create 
        public IActionResult Create()
        {
            return View();
        }

        // POST: Customers/Create 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CustomerId,CustomerName,Email,PhoneNumber")] Customer customer)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _context.Add(customer);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            catch (Exception ex)
            {
                // Logga fel eller visa meddelande för användaren 
                ModelState.AddModelError("", "Detett problem när kunden skulle skapas.");
            }

            // Om ModelState inte är giltig eller om det uppstod en DbUpdateException 
            // visas formuläret igen med felmeddelanden
            return View(customer);
        }

        // GET: Customers/Edit/5 
        public async Task<IActionResult> Edit(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        // POST: Customers/Edit/5 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, [Bind("CustomerId,CustomerName,Email,PhoneNumber")] Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(customer);
                    _context.SaveChanges(); // Spara ändringarna i databasen 
                    TempData["SuccessMessage"] = "Customer information updated successfully.";
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CustomerExists(customer.CustomerId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        TempData["ErrorMessage"] = "An error occurred while updating customer information.";
                        throw;
                    }
                }
            }
            TempData["ErrorMessage"] = "Invalid customer information. Please correct the errors.";
            return View(customer);
        }

        // GET: Customers/Delete/5 
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var customer = await _context.Customers
                .FirstOrDefaultAsync(m => m.CustomerId == id);

            if (customer == null)
            {
                return NotFound();
            }

            return View(customer);
        }

        // POST: Customers/Delete/5 

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var customer = await _context.Customers.FindAsync(id);

            if (customer != null)
            {
                _context.Customers.Remove(customer);
            }

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        private bool CustomerExists(int id)
        {
            return _context.Customers.Any(e => e.CustomerId == id);
        }

    }
}







