using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class StatisticBLL
    {
        public List<RevenueView> GetRevenueByMonth(int month, int year)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<HoaDonBan> li = new List<HoaDonBan>();
                if (month != 0)
                {
                    li = db.HoaDonBans
                        .Where(p => p.ThoiGianBan.Year == year && p.ThoiGianBan.Month == month)
                        .ToList();
                }
                else
                {
                    li = db.HoaDonBans
                        .Where(p => p.ThoiGianBan.Year == year)
                        .ToList();
                }
                return li
                    .GroupBy(p => p.ThoiGianBan.Date)
                    .Select(gr => new RevenueView
                    {
                        SellDate = gr.Key,
                        InvoiceNumber = gr.Count(),
                        Revenue = gr.Sum(p => p.TongTien)
                    })
                    .ToList();
            }
        }

        public List<HoaDonBan> GetSellInvoiceByDate(int day, int month, int year)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.HoaDonBans
                    .Where(p => p.ThoiGianBan.Year == year && p.ThoiGianBan.Month == month && p.ThoiGianBan.Day == day)
                    .Include(p => p.NhanVien)
                    .ToList();
            }
        }

        public List<BookView> GetAllBooks()
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs
                    .GroupBy(p => new { p.TenSach, p.TacGia, p.MaTheLoai, p.GiaBan })
                    .Select(gr => new BookView
                    {
                        TenSach = gr.Key.TenSach,
                        TacGia = gr.Key.TacGia,
                        SLCL = gr.Sum(p => p.SoLuongConLai),
                        GiaBan = gr.Key.GiaBan,
                        MaTheLoai = gr.Key.MaTheLoai
                    })
                    .OrderBy(gr => gr.TenSach).ThenBy(gr => gr.GiaBan)
                    .ToList();
            }
        }

        public List<BookDetailView> GetBooksForDetail(string BookName, string Author, int Category)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> li = db.Sachs
                    .Where(p => p.TenSach.ToLower() == BookName.ToLower() && p.TacGia.ToLower() == Author.ToLower() && p.MaTheLoai == Category)
                    .ToList();
                return li
                    .Select(p => new BookDetailView
                    {
                        MaSach = p.MaSach,
                        TenSach = p.TenSach,
                        GiaNhap = p.HoaDonNhapSachs.Where(hdn => hdn.MaSach == p.MaSach).Select(hdn => hdn.DonGiaNhap).FirstOrDefault(),
                        GiaBan = p.GiaBan,
                    })
                    .OrderBy(p => p.GiaBan)
                    .ToList();
            }
        }

        public void UpdateBooksPrice(string BookName, string Author, int Category, double NewPrice)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> Books = db.Sachs
                    .Where(p => p.TenSach.ToLower() == BookName.ToLower() && p.TacGia.ToLower() == Author.ToLower() && p.MaTheLoai == Category)
                    .ToList();
                foreach (Sach Book in Books)
                {
                    Book.GiaBan = NewPrice;
                }
                db.SaveChanges();
            }
        }

        public void UpdateBookPriceInDetailForm(List<int> IdBooks, double NewPrice)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> Books = db.Sachs
                    .Join(IdBooks, s => s.MaSach, li => li, (s, li) => s)
                    .ToList();
                foreach (Sach Book in Books)
                {
                    Book.GiaBan = NewPrice;
                }
                db.SaveChanges();
            }
        }
        
        public List<StaffSalaryView> GetStaffSalaryByMonth(int month, int year)
        {
            const int ThoiGianMotCa = 8;
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                DateTime today = DateTime.Now.Date;
                List<CaNV> li = new List<CaNV>();
                if (month != 0)
                {
                    li = db.CaNVs
                        .Where(p => p.Ca.Ngay.Year == year && p.Ca.Ngay.Month == month)
                        .ToList();
                }
                else
                {
                    li = db.CaNVs
                        .Where(p => p.Ca.Ngay.Year == year)
                        .ToList();
                }
                return li
                    .GroupBy(p => new { p.MaNV })
                    .Join(db.NhanViens, cnv => cnv.Key.MaNV, nv => nv.MaNV, (cnv, nv) => new StaffSalaryView
                    {
                        MaNV = nv.MaNV,
                        TenNV = nv.TenNV,
                        LuongTheoGio = nv.Luong,
                        SoCaLam = nv.CaNVs.Count(),
                        LuongTong = nv.CaNVs.Count() * ThoiGianMotCa * nv.Luong
                    })
                    .ToList();
                /*Tinh toan bo*/
                //return db.NhanViens
                //    .Select(p => new StaffSalaryView
                //    {
                //        MaNV = p.MaNV,
                //        TenNV = p.TenNV,
                //        LuongTheoGio = p.Luong,
                //        SoCaLam = p.CaNVs.Count(),
                //        LuongTong = p.CaNVs.Count() * THOIGIANMOTCA * p.Luong
                //    })
                //    .ToList();
            }
        }
    }
}
