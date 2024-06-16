using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAT03.Models
{
    public class SinhVien
    {
        [Key]
        [Display(Name = "Mã Sinh Viên")]
        [MaxLength(20)]
        public string MaSinhVien{ get; set; }
        [Display(Name = "Họ Tên")]
        [MaxLength(50)]
        public string HoTen{ get; set;}
        [Display(Name = "Mã Lớp")]
        [ForeignKey("MaLop")]
        public int? MaLop{ get; set; }
        public LopHoc? LopHoc{ get; set; }
    }
}