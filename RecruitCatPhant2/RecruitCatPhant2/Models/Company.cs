using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatPhant2.Models
{
    public class Company
    {
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string? Name { get; set; }
        [Url]
        [StringLength(250)]
        public string? Website { get; set; }
        public bool? IsRemote { get; set; }
        [Required]
        [StringLength(200)]
        public string? Position { get; set; }
        [Range(typeof(decimal), "0", "1000000")]
        public decimal? MinimumSalary { get; set; }
        [Range(typeof(decimal), "0", "1000000")]
        public decimal? MaximumSalary { get; set; }
        [Range(typeof(DateOnly), "1000-01-01", "9999-12-31")]
        [DataType(DataType.Date)]
        public DateOnly? StartDate { get; set; }
        [StringLength(200)]
        public string? Location { get; set; }

        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
            = new List<Candidate>();

    }
}
