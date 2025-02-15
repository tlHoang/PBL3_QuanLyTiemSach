﻿using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.DTO.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class StaffInfoBLL
    {
        public NhanVien GetStaffInfo(int staffID)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                NhanVien nhanvien = db.NhanViens
                    .Where(p => p.MaNV == staffID)
                    .FirstOrDefault();
                return nhanvien;
            }
        }
        
        public TaiKhoan GetAccountInfo(int staffID)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                TaiKhoan taikhoan = db.TaiKhoans
                    .Where(p => p.MaNV == staffID)
                    .FirstOrDefault();
                return taikhoan;
            }
        }
    }
}
