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
		[StringLength(30)]
		public string MaCa { get; set; }
		public int Thu { get; set; }
		public DateTime GioBatDau { get; set; }
		public DateTime GioKetThuc { get; set; }

        public virtual ICollection<CaNV> CaNVs { get; set; }

		public Ca()
		{
			CaNVs = new HashSet<CaNV>();
		}
	}
}