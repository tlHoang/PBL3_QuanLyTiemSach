using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
	[Table("HoaDonNhap")]
	public class HoaDonNhap
	{
		[Key]
		[Required]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int MaHDNhap { get; set; }
		[Required]
		public int MaNV { get; set; }
		[Required]
		public int MaDVCC { get; set; }
		public double TongTien { get; set; }

        [ForeignKey("MaNV")]
		public virtual NhanVien NhanVien { get; set; }
        [ForeignKey("MaDVCC")]
		public virtual DonViCungCap DonViCungCap { get; set; }

		public virtual ICollection<HoaDonNhapSach> HoaDonNhapSachs { get; set; }

		public HoaDonNhap()
		{
			HoaDonNhapSachs = new HashSet<HoaDonNhapSach>();
		}
	}
}
