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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHDBanSach { get; set; }
        [Required]
        public int MaHDBan { get; set; }
        [Required]
        public int MaSach { get; set; }
        public double DonGiaBan { get; set; }
        public int SoLuongBan { get; set; }

        [ForeignKey("MaSach")]
        public virtual Sach Sach { get; set; }
        [ForeignKey("MaHDBan")]
        public virtual HoaDonBan HoaDonBan { get; set; }
    }
}