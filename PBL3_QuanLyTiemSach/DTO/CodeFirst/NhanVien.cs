using PBL3_QuanLyTiemSach.DTO.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    [Table("NhanVien")]
    public class NhanVien
    {
        [Key]
        [ForeignKey("TaiKhoan")]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaNV { get; set; }
        [StringLength(50)]
        public string TenNV { get; set; }
        public bool GioiTinh { get; set; }
        public DateTime NgaySinh { get; set; }
        [StringLength(50)]
        public string DiaChi { get; set; }
        public double Luong { get; set; }
        [StringLength(10)]
        public string SDT { get; set; }

        public virtual TaiKhoan TaiKhoan { get; set; }

        public virtual ICollection<CaNV> CaNVs { get; set; }
        public virtual ICollection<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }

        public NhanVien()
        {
            CaNVs = new HashSet<CaNV>();
            HoaDonNhaps = new HashSet<HoaDonNhap>();
            HoaDonBans = new HashSet<HoaDonBan>();
        }
    }
}