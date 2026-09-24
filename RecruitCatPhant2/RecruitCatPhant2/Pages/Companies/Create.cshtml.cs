using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Companies
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public CreateModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            PopulateSelections();
            return Page();
        }

        [BindProperty]
        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                PopulateSelections();
                return Page();
            }

            _context.Company.Add(Company);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }

        private void PopulateSelections()
        {
            ViewData["IndustryId"] = new SelectList(_context.Industry, "Id", "Name");
        }
    }
}
