using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class HoaDonBanSach
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string MaHDBanSach { get; set; }
        [Required]
        [StringLength(20)]
        public string MaHDBan { get; set; } //fk
        [Required]
        [StringLength(20)]
        public string MaSach { get; set; } // fk
        public int SoLuong { get; set; }

        [ForeignKey("MaSach")]
        public virtual Sach Sach { get; set; }
        [ForeignKey("MaHDBan")]
        public virtual HoaDonBan HoaDonBan { get; set; }
    }
}
