using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class HoaDonBan
    {
        [Key]
        [Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaHDBan { get; set; }
        [Required]
        public int MaNV { get; set; }
        [Required]
        public int MaKH { get; set; }
        public DateTime ThoiGianBan { get; set; }
        public double TongTien { get; set; }

        [ForeignKey("MaNV")]
        public virtual NhanVien NhanVien { get; set; }
        [ForeignKey("MaKH")]
        public virtual KhachHang KhachHang { get; set; }

        public virtual ICollection<HoaDonBanSach> HoaDonBanSachs { get; set; }

        public HoaDonBan()
        {
            HoaDonBanSachs = new HashSet<HoaDonBanSach>();
        }
    }
}