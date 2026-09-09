using Microsoft.AspNetCore.Mvc.RazorPages;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.OurTeam
{
    public class IndexModel : PageModel
    {
        private readonly ITeamRepository _repo;

        public IndexModel(ITeamRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<TeamMember> Members { get; set; } = Enumerable.Empty<TeamMember>();

        public async Task OnGetAsync()
        {
            Members = await _repo.GetAllAsync();
        }
    }
}
