namespace RecruitCatPhant2.Models
{
    public class Company
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Website { get; set; }
        public bool? IsRemote { get; set; }
        public string? Position { get; set; }
        public decimal? MinimumSalary { get; set; }
        public decimal? MaximumSalary { get; private set; }
        public DateOnly? StartDate { get; set; }
        public string? Location { get; set; }
    }
}
