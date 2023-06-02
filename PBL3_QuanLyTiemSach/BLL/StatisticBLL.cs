using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class StatisticBLL
    {
        public List<HoaDonBan> GetSellInvoiceByMonth(int month, int year)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.HoaDonBans
                    .Where(p => p.ThoiGianBan.Year == year && p.ThoiGianBan.Month == month)
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

        public List<Sach> GetAllBooks()
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs
                    .Select(p => p)
                    .Include(p => p.SachTheLoai)
                    .ToList();
            }
        }

        public List<Sach> GetBooksForDetail(string BookName, string Author, int Category)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs
                    .Where(p => p.TenSach.ToLower() == BookName.ToLower() && p.TacGia.ToLower() == Author.ToLower() && p.MaTheLoai == Category)
                    .Include(p => p.HoaDonNhapSachs)
                    .Include(p => p.HoaDonBanSachs)
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

        public double AAA(string BookName, string Author, int Category, double Price)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                //List<int> IdBooks = db.Sachs
                List<int> Ids = db.Sachs
                    .Where(p => p.TenSach.ToLower() == BookName.ToLower() && p.TacGia.ToLower() == Author.ToLower() && p.MaTheLoai == Category && p.GiaBan == Price)
                    .Select(p => p.MaSach)
                    .ToList();
                var hdbs = db.HoaDonBanSachs
                    .Where(p => Ids.Contains(p.MaSach))
                    .Select(p => new { p.DonGiaBan, p.SoLuongBan })
                    .ToList();
                var hdns = db.HoaDonNhapSachs
                    .Where(p => Ids.Contains(p.MaSach))
                    .Select(p => new { p.DonGiaNhap })
                    .ToList();
                double result = 0;
                foreach (var hdb in hdbs)
                {
                    result += hdb.DonGiaBan * hdb.SoLuongBan;
                }
                foreach (var hdn in hdns)
                {
                    result -= hdn.DonGiaNhap;
                }
                return result;
            }
        }
    }
}
