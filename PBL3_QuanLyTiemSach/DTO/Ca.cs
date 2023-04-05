using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
	[Table("Ca")]
	public class Ca
	{
		[Key]
		[Required]
		[StringLength(10)]
		public string MaCa { get; set; }

		public int Thu { get; set; }
		public int GioBatDau { get; set; }
		public int GioKetThuc { get; set; }
	}
}