using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Data
{
    public interface ITeamRepository
    {
        Task<IEnumerable<TeamMember>> GetAllAsync();
        Task<TeamMember?> GetByIdAsync(int id);
        Task AddAsync(TeamMember member);
        Task UpdateAsync(TeamMember member);
        Task DeleteAsync(int id);
    }
}
