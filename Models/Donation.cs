using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class Donation
    {
        [Key]
        [Required]
        public int DonationId { get; set; }
        public int DonationAmount { get; set; }

        [StringLength(20)]
        public string? DonationStatus { get; set; }

        [ForeignKey("Kind")]
        public int KindId { get; set; }
        public Kind? Kind { get; set; }

        public DateTime? DonationDate { get; set; }
    }
}
