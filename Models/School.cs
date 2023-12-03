using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class School
    {
        [Key]
        public int SchoolId { get; set; }

        [Required]
        [StringLength(200)]
        public string? SchoolName { get; set; }

        [StringLength(500)]
        public string? SchoolAddress { get; set; }
    }
}
