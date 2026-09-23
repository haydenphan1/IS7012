using Microsoft.EntityFrameworkCore;
using RecruitCatPhant2.Models;

namespace RecruitCatPhant2.Data
{
    public class RecruitCatPhant2Context : DbContext
    {
        public RecruitCatPhant2Context(DbContextOptions<RecruitCatPhant2Context> options)
            : base(options)
        {
        }

        public DbSet<Candidate> Candidate { get; set; } = default!;
        public DbSet<Company> Company { get; set; } = default!;
        public DbSet<JobTitle> JobTitle { get; set; } = default!;
        public DbSet<Industry> Industry { get; set; } = default!;
    }
}
