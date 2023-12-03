using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }

        [Required]
        [StringLength(100)]
        public string? UserName { get; set; }

        [StringLength(300)]
        public string? UserAddress { get; set; }

        public int AccumulatedPoints { get; set; }

        [ForeignKey("Account")]
        public int AccounntId { get; set; }
        public Account? Account { get; set; }


        [ForeignKey("Donation")]
        public int DonationId { get; set; }
        public Donation? Donation { get; set; }
    }
}
