using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Candidates
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public IndexModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public IList<Candidate> Candidate { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Candidate = await _context.Candidate
                .Include(c => c.Company)
                .Include(c => c.JobTitle)
                .Include(c => c.Industry)
                .ToListAsync();
        }
    }
}
