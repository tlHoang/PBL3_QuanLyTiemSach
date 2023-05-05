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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCa { get; set; }
		public DateTime Ngay { get; set; }
		public TimeSpan GioBatDau { get; set; }
		public TimeSpan GioKetThuc { get; set; }

        public virtual ICollection<CaNV> CaNVs { get; set; }

		public Ca()
		{
			CaNVs = new HashSet<CaNV>();
		}
	}
}