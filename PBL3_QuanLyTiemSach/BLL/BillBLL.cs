using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class BillBLL
    {
        public List<HoaDon> GetAllHoaDon(bool LoaiHD)
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                if (LoaiHD == true)
                {
                    return db.HoaDonNhaps.Select(p => new HoaDon
                    {
                        ID = p.MaHDNhap,
                        Date = p.ThoiGianNhap,
                        StaffName = getTenNV(p.MaNV),
                        TenKH_DVCC = getTenDVCC(p.MaDVCC),
                        Total = p.TongTien,
                    }).ToList();
                }
                else
                {
                    return db.HoaDonBans.Select(p => new HoaDon
                    {
                        ID = p.MaHDBan,
                        Date = p.ThoiGianBan,
                        StaffName = getTenNV(p.MaNV),
                        TenKH_DVCC = getTenKH(p.MaKH),
                        Total = p.TongTien,
                    }).ToList();
                }
            }
        }
        public string getTenNV(int MaNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens.Where(p => p.MaNV == MaNV).FirstOrDefault().TenNV;
            }
        }
        public string getTenDVCC(int MaDV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.DonViCungCaps.Where(p => p.MaDV == MaDV).FirstOrDefault().TenDV;
            }
        }
        public string getTenKH(int MaKH)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.KhachHangs.Where(p => p.MaKH == MaKH).FirstOrDefault().TenKH;
            }
        }
    }
}
