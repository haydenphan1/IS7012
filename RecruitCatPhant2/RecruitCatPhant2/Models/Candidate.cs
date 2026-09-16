namespace RecruitCatPhant2.Models
{
    public class Candidate
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public int? YearExperience { get; set; }
        public decimal? TargetSalary { get; set; }
        public DateOnly? StartDate { get; set; }
    }
}
