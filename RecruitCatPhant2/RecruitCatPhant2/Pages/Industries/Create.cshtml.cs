using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Industries
{
    public class CreateModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public CreateModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        [BindProperty]
        public Industry Industry { get; set; } = default!;

        public IActionResult OnGet()
        {
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Industry.Add(Industry);
            await _context.SaveChangesAsync();

            return RedirectToPage("Index");
        }
    }
}
