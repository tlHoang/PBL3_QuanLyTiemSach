using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class HoaDonBan
    {
        [Key]
        [Required]
        [StringLength(20)]
        public string MaHDBan { get; set; }
        [Required]
        [StringLength(10)]
        public string MaSV { get; set; } //fk
        [Required]
        [StringLength(10)]
        public string MaKH { get; set; } // fk
        public double TongTien { get; set; }
        public  virtual ICollection<HoaDonBanSach> HoaDonBanSaches { get; set; }
        public HoaDonBan()
        {
            this.HoaDonBanSaches = new HashSet<HoaDonBanSach>();
        }
    }
}
