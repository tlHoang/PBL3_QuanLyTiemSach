using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    [Table("DonViCC")]
    public class DonViCungCap
    {
        [Key]
        [Required]
        [StringLength(30)]
        public string MaDV { get; set; }

        public string TenDV { get; set; }
    }
}
