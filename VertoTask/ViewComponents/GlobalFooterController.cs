using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VertoTask.Data;

namespace VertoTask.ViewComponents
{
    public class GlobalFooterViewComponent : ViewComponent
    {
        private readonly AppDbContext _context;

        public GlobalFooterViewComponent(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var settings = await _context.GlobalContents.FirstOrDefaultAsync();
            return View("~/Views/Shared/GlobalFooter.cshtml", settings);

        }
    }
}
