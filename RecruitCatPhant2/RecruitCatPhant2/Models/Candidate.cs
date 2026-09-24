using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatPhant2.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string? FirstName { get; set; }
        [StringLength(50)]
        public string? LastName { get; set; }
        [EmailAddress]
        [StringLength(200)]
        public string? Email { get; set; }
        public int? YearExperience { get; set; }
        [Range(typeof(decimal), "0", "1000000")]
        public decimal? TargetSalary { get; set; }
        [Range(typeof(DateOnly), "1000-01-01", "9999-12-31")]
        [DataType(DataType.Date)]
        public DateOnly? StartDate { get; set; }

        public int? CompanyId { get; set; }
        public Company? Company { get; set; }
        public int? JobTitleId { get; set; }
        public JobTitle? JobTitle { get; set; }
        public int? IndustryId { get; set; }
        public Industry? Industry { get; set; }

    }
}
