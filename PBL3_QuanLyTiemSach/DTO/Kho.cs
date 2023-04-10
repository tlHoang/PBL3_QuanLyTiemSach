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
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [StringLength(20)]
        public string ID { get; set; }
        [StringLength(20)]
        [Required]
        public string ID_Sach { get; set; }
        [StringLength(int.MaxValue)]
        public string TenSach { get; set; }
        public int SLSachConLai { get; set; }

        public virtual ICollection<Sach> Saches { get; set; }
        public Kho()
        {
            this.Saches = new HashSet<Sach>();
        }
    }
}
