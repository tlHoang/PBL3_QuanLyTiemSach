using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO.CodeFirst
{
    public class Account
    {
        [Key]
        [Required]
        [StringLength(30)]
        public string MaNV { get; set; }
        [Required]
        [StringLength(30)]
        public string Username { get; set; }
        [Required]
        [StringLength(30)]
        public string Password { get; set; }

        public virtual NhanVien NhanVien { get; set; }
    }
}
