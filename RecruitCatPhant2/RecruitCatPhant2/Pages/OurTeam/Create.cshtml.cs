using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RecruitCatPhant2.Data;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Pages.OurTeam
{
    public class CreateModel : PageModel
    {
        private readonly ITeamRepository _repo;

        public CreateModel(ITeamRepository repo)
        {
            _repo = repo;
        }

        [BindProperty]
        public TeamMember Member { get; set; } = new();

        public void OnGet()
        {
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid) return Page();
            await _repo.AddAsync(Member);
            return RedirectToPage("Index");
        }
    }
}
