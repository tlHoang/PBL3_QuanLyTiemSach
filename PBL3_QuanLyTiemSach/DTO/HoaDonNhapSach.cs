﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class HoaDonNhapSach
    {
        [Key]
        [Required]
        [StringLength(30)]
        public string MaHDNhapSach { get; set; }
        [Required]
        [StringLength(30)]
        public string MaHDNhap { get; set; }
        [Required]
        [StringLength(30)]
        public string MaSach { get; set; }
        public int SoLuong { get; set; }
        public double DonGiaNhap { get; set; }

        [ForeignKey("MaSach")]
        public virtual Sach Sach { get; set; }
        [ForeignKey("MaHDNhap")]
        public virtual HoaDonNhap HoaDonNhap { get; set; }
    }
}
