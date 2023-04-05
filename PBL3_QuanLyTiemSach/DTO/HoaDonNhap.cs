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
		[StringLength(10)]
		public string MaHDNhap { get; set; }

		[StringLength(10)]
		public string MaNV { get; set; }

		[StringLength(10)]
		public string MaDV { get; set; }

		public double TongTien { get; set; }
	}
}