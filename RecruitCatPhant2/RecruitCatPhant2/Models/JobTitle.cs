using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatPhant2.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string? Title { get; set; }
        [StringLength(100)]
        public string? Department { get; set; }
        [StringLength(100)]
        public string? EmploymentType { get; set; }
        [Range(typeof(decimal), "0", "1000000")]
        public decimal? MinimumSalary { get; set; }
        [Range(typeof(decimal), "0", "1000000")]
        public decimal? MaximumSalary { get; set; }

        public ICollection<Candidate> Candidates { get; set; }
            = new List<Candidate>();
    }
}
