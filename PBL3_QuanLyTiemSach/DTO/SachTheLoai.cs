using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class SachTheLoai
    {
        [Key]
        [Required]
        [StringLength(30)]
        public string MaTheLoai { get; set; }
        [StringLength(30)]
        public string TenTheLoai { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
        public SachTheLoai()
        {
            Saches = new HashSet<Sach>();
        }
    }
}
