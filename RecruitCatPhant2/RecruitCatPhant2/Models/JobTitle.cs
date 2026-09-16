namespace RecruitCatPhant2.Models
{
    public class JobTitle
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Department { get; set; }
        public string? EmploymentType { get; set; }
        public decimal? MinimumSalary { get; set; }
        public decimal? MaximumSalary { get; set; }
    }
}
