using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VertoTask.Data;
using VertoTask.Models;

namespace VertoTask.Controllers  // <-- Add this namespace matching your project structure
{
    public class AdminController : Controller
    {
        private readonly AppDbContext _context;

        public AdminController(AppDbContext context)
        {
            _context = context;
        }

        // GET: /Admin/EditHomepageText
        public async Task<IActionResult> EditHomepageText()
        {
            var content = await _context.HomepageContents.FindAsync(1);
            if (content == null) return NotFound();

            return View("AdminPage", content);

        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditHomepageText(HomepageContent model)
        {
            var content = await _context.HomepageContents.FindAsync(model.Id);
            if (content == null) return NotFound();

            // Copy all editable text properties from model to entity
            content.Section1_TextOverCarousel = model.Section1_TextOverCarousel;
            content.Section2_Title = model.Section2_Title;
            content.Section2_SubTitle = model.Section2_SubTitle;
            content.Section2_ButtonText = model.Section2_ButtonText;
            content.Section3_FloatingText = model.Section3_FloatingText;
            content.Section4_GlobalText = model.Section4_GlobalText;
            content.Section4_Image1Title = model.Section4_Image1Title;
            content.Section4_Image1Description = model.Section4_Image1Description;
            content.Section4_Image2Title = model.Section4_Image2Title;
            content.Section4_Image3Title = model.Section4_Image3Title;
            content.Section5_Title = model.Section5_Title;
            content.Section5_SubTitle = model.Section5_SubTitle;
            content.Section5_Image1Text = model.Section5_Image1Text;
            content.Section5_Image2Text = model.Section5_Image2Text;

            await _context.SaveChangesAsync();

            TempData["Success"] = "Homepage text updated!";
            return RedirectToAction(nameof(EditHomepageText));
        }




    }
}
