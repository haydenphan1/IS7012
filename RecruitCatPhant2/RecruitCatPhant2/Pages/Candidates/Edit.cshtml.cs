using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Candidates
{
    public class EditModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public EditModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Candidate Candidate { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null) return NotFound();

            Candidate = await _context.Candidate.FindAsync(id);

            if (Candidate == null) return NotFound();

            PopulateSelections();
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                PopulateSelections();
                return Page();
            }

            _context.Attach(Candidate).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Candidate.Any(e => e.Id == Candidate.Id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("Index");
        }

        private void PopulateSelections()
        {
            ViewData["CompanyId"] = new SelectList(_context.Company, "Id", "Name", Candidate.CompanyId);
            ViewData["JobTitleId"] = new SelectList(_context.JobTitle, "Id", "Title", Candidate.JobTitleId);
            ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name", Candidate.IndustryId);
        }
    }
}
