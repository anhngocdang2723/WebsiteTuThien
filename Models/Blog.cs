using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class Blog
    {
        [Key]
        public int BlogId { get; set; }

        [Required]
        [StringLength(200)]
        public string? BlogName { get; set; }

        [StringLength(50)]
        public string? BlodImg { get; set; }

        [StringLength(5000)]
        public string? BlogContent { get; set; }
    }
}
