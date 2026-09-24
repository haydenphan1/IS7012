using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Companies
{
    public class DeleteModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public DeleteModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Company = await _context.Company
                .Include(c => c.Industry)
                .FirstOrDefaultAsync(m => m.Id == id);

            if (Company == null) return NotFound();

            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null) return NotFound();

            var company = await _context.Company.FindAsync(id);

            if (company != null)
            {
                _context.Company.Remove(company);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("Index");
        }
    }
}
