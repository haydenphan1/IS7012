using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Industries
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public DetailsModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Industry = await _context.Industry
                .Include(i => i.Companies)
                .Include(i => i.Candidates)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Industry == null) return NotFound();

            return Page();
        }
    }
}
