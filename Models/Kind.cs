using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace WebsiteTuThien.Models
{
    public class Kind
    {
        [Key]
        public int KindId { get; set; }

        [Required]
        [StringLength(200)]
        [DisplayName("Tên đồ dùng")]
        public string? KindName { get; set; }
        [DisplayName("Số lượng")]
        public int AmountOfKind { get; set; }
        [DisplayName("Điểm cho mỗi đơn vị")]
        public int PointOfKind { get; set; }
    }
}
