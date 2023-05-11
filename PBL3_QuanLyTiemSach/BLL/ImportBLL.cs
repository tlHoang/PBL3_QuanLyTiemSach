using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class ImportBLL
    {
        public List<string> getAllNameDVCC()
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<string> result = new List<string>();
                var data = db.DonViCungCaps.Select(p => new { p.TenDV }).ToList();
                foreach(var item in data)
                {
                    result.Add(item.TenDV.ToString());
                }
                return result;
            }
        }
        public void addTheLoai(string TenTheLoai)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                SachTheLoai stl = new SachTheLoai
                {
                    TenTheLoai = TenTheLoai,
                };
                db.SachTheLoais.Add(stl);
                db.SaveChanges();
            }
        }
        public void addDVCC(string TenDVCC)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                DonViCungCap d = new DonViCungCap
                {
                    TenDV = TenDVCC,
                };
                db.DonViCungCaps.Add(d);
                db.SaveChanges();
            }
        }
        public int getMaDVCC(string TenDVCC)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.DonViCungCaps.Where(p => p.TenDV == TenDVCC).FirstOrDefault().MaDV;
            }
        }
        private int getMaSach(string TenSach)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs.Where(p => p.TenSach == TenSach).FirstOrDefault().MaSach;
            }
        }
        public void addHDN(List<Sach> ls, int MaNV, string TenDVCC)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                HoaDonNhap hdn = new HoaDonNhap()
                {
                    MaNV = MaNV,
                    MaDVCC = getMaDVCC(TenDVCC),
                };
                db.HoaDonNhaps.Add(hdn);
                db.SaveChanges();

                foreach (Sach i in ls)
                {
                    HoaDonNhapSach hdns = new HoaDonNhapSach()
                    {
                        MaHDNhap = hdn.MaHDNhap,
                        MaSach = getMaSach(i.TenSach),
                        DonGiaNhap = i.GiaBan,
                        SoLuongNhap = i.SoLuongConLai,
                    };
                    db.HoaDonNhapSachs.Add(hdns);
                    db.SaveChanges();
                }

                hdn.TongTien =
                    db.HoaDonNhapSachs.Where(p => p.MaHDNhap == hdn.MaHDNhap)
                    .Select(p1 => new
                    {
                        TongTien = p1.SoLuongNhap * p1.DonGiaNhap
                    })
                    .Sum(p2 => p2.TongTien);
                db.SaveChanges();
            }
        }
    }
}
