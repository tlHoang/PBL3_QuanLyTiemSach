using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    [Table("KhachHang")]
    public class KhachHang
    {
        [Key]
        [Required]
        [StringLength(10)]
        public string MaKH { get; set; }
        public string TenKH { get; set; }
        [StringLength(10)]
        public string SDT { get; set; }
    }
}