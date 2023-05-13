using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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
                    List<HoaDon> hd = new List<HoaDon>();
                    var data = db.HoaDonNhaps.ToList();
                    foreach(HoaDonNhap p in data)
                    {
                        hd.Add(new HoaDon
                        {
                            ID = p.MaHDNhap,
                            Date = p.ThoiGianNhap,
                            StaffName = getTenNV(p.MaNV),
                            TenKH_DVCC = getTenDVCC(p.MaDVCC),
                            Total = p.TongTien,
                        });
                    }
                    return hd;
                }
                else
                {
                    List<HoaDon> hd = new List<HoaDon>();
                    var data = db.HoaDonBans.ToList();
                    foreach(HoaDonBan p in data)
                    {
                        hd.Add(new HoaDon
                        {
                            ID = p.MaHDBan,
                            Date = p.ThoiGianBan,
                            StaffName = getTenNV(p.MaNV),
                            TenKH_DVCC = getTenKH(p.MaKH),
                            Total = p.TongTien,
                        });
                    }
                    return hd;
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
        public List<HoaDon> GetAllHoaDonSortBy(bool LoaiHD, int index)
        {
            List<HoaDon> hd = GetAllHoaDon(LoaiHD);
            switch(index)
            {
                case 0:
                    hd = hd.OrderBy(p => p.ID).ToList();
                    break;
                case 1:
                    hd = hd.OrderBy(p => p.Date).ToList();
                    break;
                case 2:
                    hd = hd.OrderBy(p => p.StaffName).ToList();
                    break;
                case 3:
                    hd = hd.OrderBy(p => p.TenKH_DVCC).ToList();
                    break;
                case 4:
                    hd = hd.OrderBy(p => p.Total).ToList();
                    break;
            }
            return hd;
        }
        public string getSDTfromTenKH(string TenKH)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.KhachHangs.Where(p => p.TenKH == TenKH).FirstOrDefault().SDT;
            }
        }
        public List<HoaDonBanSach> getHDBSfromMaHDB(int MaHDB)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.HoaDonBanSachs.Where(p => p.MaHDBan == MaHDB).ToList();
            }
        }
        public List<HoaDonNhapSach> getHDNSfromMaHDN(int MaHDN)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.HoaDonNhapSachs.Where(p => p.MaHDNhap == MaHDN).ToList();
            }
        }
        public string getTenSachfromMaSach(int MaSach)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs.Where(p => p.MaSach == MaSach).FirstOrDefault().TenSach;
            }
        }
    }
}
