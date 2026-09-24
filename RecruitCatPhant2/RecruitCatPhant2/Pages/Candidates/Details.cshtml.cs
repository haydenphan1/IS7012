using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Candidates
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public DetailsModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.JobTitle)
                .Include(c => c.Industry)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Candidate == null) return NotFound();

            return Page();
        }
    }
}
