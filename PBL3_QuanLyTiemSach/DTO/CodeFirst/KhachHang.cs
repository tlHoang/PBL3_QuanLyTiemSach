using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        [Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaKH { get; set; }
        [StringLength(50)]
        public string TenKH { get; set; }
        [StringLength(10)]
        public string SDT { get; set; }

        public virtual ICollection<HoaDonBan> HoaDonBans { get; set; }

        public KhachHang()
        {
            HoaDonBans = new HashSet<HoaDonBan>();
        }
    }
}
