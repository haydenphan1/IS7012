using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Industries
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public EditModel(RecruitCatPhant2Context context)
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

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
                return Page();

            _context.Attach(Industry).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Industry.Any(e => e.Id == Industry.Id))
                    return NotFound();
                else
                    throw;
            }

            return RedirectToPage("Index");
        }
    }
}
