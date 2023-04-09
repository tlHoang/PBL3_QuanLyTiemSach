using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class Kho
    {
        [Key]
        [Required]
        [StringLength(30)]
        public string MaKho { get; set; }
        [StringLength(100)]
        public string TenSach { get; set; }
        public int SoLuongSachConLai { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
        public Kho()
        {
            Saches = new HashSet<Sach>();
        }
    }
}
