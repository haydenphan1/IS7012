using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.JobTitles
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public IndexModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public IList<JobTitle> JobTitle { get; set; } = default!;

        public async Task OnGetAsync()
        {
            JobTitle = await _context.JobTitle
                .Include(j => j.Candidates)
                .ToListAsync();
        }
    }
}
