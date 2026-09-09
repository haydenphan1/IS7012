using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.OurTeam
{
    public class EditModel : PageModel
    {
        private readonly ITeamRepository _repo;

        public EditModel(ITeamRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public TeamMember Member { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            var m = await _repo.GetByIdAsync(id);
            if (m == null) return NotFound();
            Member = m;
            return Page();
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _repo.UpdateAsync(Member);
            return RedirectToPage("Index");
        }
    }
}
