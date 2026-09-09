using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.OurTeam
{
    public class DetailsModel : PageModel
    {
        private readonly ITeamRepository _repo;

        public DetailsModel(ITeamRepository repo)
        {
            _repo = repo;
        }

        public TeamMember? Member { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Member = await _repo.GetByIdAsync(id);
            if (Member == null) return NotFound();
            return Page();
        }
    }
}
