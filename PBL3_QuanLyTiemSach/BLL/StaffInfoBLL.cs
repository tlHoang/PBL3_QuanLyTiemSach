using PBL3_QuanLyTiemSach.DTO;
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
        public NhanVien GetNhanVienInfo(int maNhanVien)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                NhanVien nhanvien = db.NhanViens
                    .Where(p => p.MaNV == maNhanVien)
                    .FirstOrDefault();
                return nhanvien;
            }
        }
        
        public TaiKhoan GetTaiKhoanInfo(int maNhanVien)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                TaiKhoan taikhoan = db.TaiKhoans
                    .Where(p => p.MaNV == maNhanVien)
                    .FirstOrDefault();
                return taikhoan;
            }
        }
    }
}
