using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.JobTitles
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public DeleteModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public JobTitle JobTitle { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var jobTitle = await _context.JobTitle.FirstOrDefaultAsync(m => m.Id == id);
            if (jobTitle == null)
                return NotFound();

            JobTitle = jobTitle;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var jobTitle = await _context.JobTitle.FindAsync(id);

            if (jobTitle != null)
            {
                _context.JobTitle.Remove(jobTitle);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
