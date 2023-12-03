using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class Request
    {
        [Key]
        public int RequestId { get; set; }

        [Required]
        public int RequestAmount { get; set; }
        [StringLength(100)]
        public string? RequestStatus { get; set; }
        public DateTime? RequestDate { get; set; }

        [ForeignKey("Kind")]
        public int KindId { get; set; }
        public Kind? Kind { get; set; }

        [ForeignKey("School")]
        public int SchoolId { get; set; }
        public School? School { get; set; }

    }
}
