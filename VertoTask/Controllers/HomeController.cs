using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using VertoTask.Data;
using VertoTask.Models;

namespace VertoTask.Controllers  // Add this to keep things tidy & discoverable
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Homepage()
        {
            var content = await _context.HomepageContents.FirstOrDefaultAsync();
            return View(content);
        }
    }
}
