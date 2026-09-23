using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Industries
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public DeleteModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Industry Industry { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var industry = await _context.Industry.FindAsync(id);
            if (industry == null)
                return NotFound();

            Industry = industry;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var industry = await _context.Industry.FindAsync(id);

            if (industry != null)
            {
                _context.Industry.Remove(industry);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
