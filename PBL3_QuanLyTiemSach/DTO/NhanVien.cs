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
		[Required]
		[StringLength(10)]
		public string MaNV { get; set; }
		public string TenNV { get; set; }
		public bool GioiTinh { get; set; }
		public DateTime date { get; set; }
		public string DiaChi { get; set; }
		public double Luong { get; set; }
		[StringLength(10)]
		public string SDT { get; set; }
	}
}