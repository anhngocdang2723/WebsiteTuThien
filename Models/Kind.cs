using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class Kind
    {
        [Key]
        public int KindId { get; set; }

        [Required]
        [StringLength(200)]
        public string? KindName { get; set; }
        public int AmountOfKind { get; set; }
        public int PointOfKind { get; set; }
    }
}
