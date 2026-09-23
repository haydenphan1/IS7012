using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Companies
{
    public class DetailsModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public DetailsModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public Company Company { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
                return NotFound();

            var company = await _context.Company.FirstOrDefaultAsync(m => m.Id == id);
            if (company == null)
                return NotFound();

            Company = company;
            return Page();
        }
    }
}
