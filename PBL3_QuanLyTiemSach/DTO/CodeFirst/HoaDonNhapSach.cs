using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class HoaDonNhapSach
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHDNhapSach { get; set; }
        [Required]
        public int MaHDNhap { get; set; }
        [Required]
        public int MaSach { get; set; }
        public double DonGiaNhap { get; set; }
        public int SoLuongNhap { get; set; }

        [ForeignKey("MaSach")]
        public virtual Sach Sach { get; set; }
        [ForeignKey("MaHDNhap")]
        public virtual HoaDonNhap HoaDonNhap { get; set; }
    }
}