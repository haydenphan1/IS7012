using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.JobTitles
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public DetailsModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            JobTitle = await _context.JobTitle
                .Include(j => j.Candidates)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (JobTitle == null) return NotFound();

            return Page();
        }
    }
}
