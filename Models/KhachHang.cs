using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace QUOCDAT2KDEMO.Models
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        public string KhachHangId { get; set; }
        public string TenKhachHang { get; set; }
        public ICollection<HoaDon> hoadons { get; set; }
    }
}