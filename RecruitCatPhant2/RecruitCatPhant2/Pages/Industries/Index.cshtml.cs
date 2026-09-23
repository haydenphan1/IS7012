using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.Industries
{
    public class IndexModel : PageModel
    {
        private readonly RecruitCatPhant2Context _context;

        public IndexModel(RecruitCatPhant2Context context)
        {
            _context = context;
        }

        public IList<Industry> Industry { get; set; } = default!;

        public async Task OnGetAsync()
        {
            Industry = await _context.Industry.ToListAsync();
        }
    }
}
