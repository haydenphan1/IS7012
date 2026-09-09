using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Data
{
    public class InMemoryTeamRepository : ITeamRepository
    {
        private readonly List<TeamMember> _items = new();
        private int _nextId = 1;
        private readonly object _lock = new();

        public InMemoryTeamRepository()
        {
            _items.Add(new TeamMember { Id = _nextId++, FullName = "Alice Johnson", Role = "CEO", Bio = "Founder and CEO.", PhotoUrl = "" });
            _items.Add(new TeamMember { Id = _nextId++, FullName = "Bob Smith", Role = "CTO", Bio = "Chief Technology Officer.", PhotoUrl = "" });
        }

        public Task AddAsync(TeamMember member)
        {
            lock (_lock)
            {
                member.Id = _nextId++;
                _items.Add(member);
            }
            return Task.CompletedTask;
        }

        public Task DeleteAsync(int id)
        {
            lock (_lock)
            {
                var idx = _items.FindIndex(x => x.Id == id);
                if (idx >= 0) _items.RemoveAt(idx);
            }
            return Task.CompletedTask;
        }

        public Task<IEnumerable<TeamMember>> GetAllAsync()
        {
            IEnumerable<TeamMember> snapshot;
            lock (_lock)
            {
                snapshot = _items.Select(x => new TeamMember { Id = x.Id, FullName = x.FullName, Role = x.Role, Bio = x.Bio, PhotoUrl = x.PhotoUrl }).ToList();
            }
            return Task.FromResult(snapshot);
        }

        public Task<TeamMember?> GetByIdAsync(int id)
        {
            TeamMember? found;
            lock (_lock)
            {
                var p = _items.FirstOrDefault(x => x.Id == id);
                found = p is null ? null : new TeamMember { Id = p.Id, FullName = p.FullName, Role = p.Role, Bio = p.Bio, PhotoUrl = p.PhotoUrl };
            }
            return Task.FromResult(found);
        }

        public Task UpdateAsync(TeamMember member)
        {
            lock (_lock)
            {
                var idx = _items.FindIndex(x => x.Id == member.Id);
                if (idx >= 0)
                {
                    _items[idx] = new TeamMember { Id = member.Id, FullName = member.FullName, Role = member.Role, Bio = member.Bio, PhotoUrl = member.PhotoUrl };
                }
            }
            return Task.CompletedTask;
        }
    }
}
