using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatPhant2.Models
{
    public class Industry
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? Name { get; set; }

        public ICollection<Company> Companies { get; set; }
            = new List<Company>();
        public ICollection<Candidate> Candidates { get; set; }
            = new List<Candidate>();
    }
}
