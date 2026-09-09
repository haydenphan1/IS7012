using System.ComponentModel.DataAnnotations;

namespace RecruitCatPhant2.Models
{
    public class TeamMember
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string FullName { get; set; } = string.Empty;

        [StringLength(100)]
        public string? Role { get; set; }

        [StringLength(1000)]
        public string? Bio { get; set; }

        [Url]
        public string? PhotoUrl { get; set; }
    }
}
