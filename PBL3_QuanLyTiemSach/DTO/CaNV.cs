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
        [StringLength(10)]
        public string ID_CaNV { get; set; }

        [StringLength(10)]
        public string MaCa { get; set; }

        [StringLength(10)]
        public string MaNV { get; set; }
    }
}