using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class Account
    {
        [Key]
        public int AccountId { get; set; }

        [Required]
        [StringLength(100)]
        public string? AccountName { get; set; }

        [StringLength(100)]
        public string? Password { get; set; }

        [StringLength(10)]
        public string? Role { get; set; }
    }
}
