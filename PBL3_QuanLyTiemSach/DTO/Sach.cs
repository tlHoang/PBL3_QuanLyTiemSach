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
        [StringLength(20)]
        public string MaSach { get; set; }
        [StringLength(int.MaxValue)]
        public string TenSach { get; set; }
        [StringLength(20)]
        public string TacGia { get; set; }
        public double GiaBan { get; set; }
        [StringLength(20)]
        [Required]
        public string ID_TheLoai { get; set; }//Fk
        [StringLength(20)]
        [Required]
        public string MaKho { get; set; } //fk
        [ForeignKey("MaKho")]
        public virtual Kho Kho { get; set; }
        [ForeignKey("ID_TheLoai")]
        public virtual SachTheLoai SachTheLoai { get; set; }

        public virtual ICollection<HoaDonNhapSach> HoaDonNhapSaches { get; set; }
        public virtual ICollection<HoaDonBanSach> HoaDonBanSaches { get; set; }

        public Sach()
        {
            this.HoaDonBanSaches = new HashSet<HoaDonBanSach>();
            this.HoaDonNhapSaches = new HashSet<HoaDonNhapSach>();
        }
    }
}
