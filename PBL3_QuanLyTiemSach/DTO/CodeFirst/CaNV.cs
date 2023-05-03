using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    [Table("CaNV")]
    public class CaNV
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MaCaNV { get; set; }
        [Required]
        public int MaCa { get; set; }
        [Required]
        public int MaNV { get; set; }

        [ForeignKey("MaCa")]
        public virtual Ca Ca { get; set; }
        [ForeignKey("MaNV")]
        public virtual NhanVien NhanVien { get; set; }
    }
}
