using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class Sach
    {
        [Key]
        [Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaSach { get; set; }
        [StringLength(100)]
        public string TenSach { get; set; }
        [StringLength(50)]
        public string TacGia { get; set; }
        public int SoLuongConLai { get; set; }
        public double GiaBan { get; set; }
        [Required]
        public int MaTheLoai { get; set; }

        [ForeignKey("MaTheLoai")]
        public virtual SachTheLoai SachTheLoai { get; set; }

        public virtual ICollection<HoaDonNhapSach> HoaDonNhapSachs { get; set; }
        public virtual ICollection<HoaDonBanSach> HoaDonBanSachs { get; set; }

        public Sach()
        {
            HoaDonBanSachs = new HashSet<HoaDonBanSach>();
            HoaDonNhapSachs = new HashSet<HoaDonNhapSach>();
        }
    }
}
