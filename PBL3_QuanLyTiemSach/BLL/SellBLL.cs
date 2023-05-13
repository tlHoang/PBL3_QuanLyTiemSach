using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.DTO.CodeFirst;
using static System.Net.Mime.MediaTypeNames;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class SellBLL
    {
        public int getSLSachConLai(string TenSach)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var data = db.Sachs.GroupBy(p => p.TenSach)
                    .Select(p1 => new
                    {
                        TenSach = p1.Key,
                        SLCL = p1.Sum(p => p.SoLuongConLai)
                    }).Where(p2 => p2.TenSach.Contains(TenSach))
                    .FirstOrDefault();
                return data.SLCL;
            }
        }
        public double getGiaBanSach(string TenSach)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var data = db.Sachs.Where(p => p.TenSach.Contains(TenSach)).FirstOrDefault();
                return data.GiaBan;
            }
        }
        public void updateSachinDatabase(List<Sach> ls)
        {
            //Trừ số lượng sách được mua
            for (int i = 0; i < ls.Count; i++)
            {
                int sl = ls[i].SoLuongConLai;
                string ten = ls[i].TenSach;
                while (sl > 0)
                {
                    using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
                    {
                        Sach s = 
                            (from p in db.Sachs
                            where p.TenSach == ten && p.SoLuongConLai > 0
                            select p)
                            .FirstOrDefault();
                        if (s.SoLuongConLai > sl)
                        {
                            s.SoLuongConLai -= sl;
                            sl = 0;
                        }
                        else
                        {
                            sl -= s.SoLuongConLai;
                            s.SoLuongConLai = 0;
                        }
                        db.SaveChanges();
                    }
                }
            }
        }
        public List<BookInfo> setDGVSBI(List<Sach> TenSach, string SearchText)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var data = db.Sachs.GroupBy(p => p.TenSach)
                    .Select(p1 => new
                    {
                        TenSach = p1.Key,
                        SLCL = p1.Sum(p => p.SoLuongConLai)
                    })
                    .ToList();
                var tmp = TenSach.Select(p => new
                {
                    TenSach = p.TenSach,
                    SLCL = 1
                }).ToList();

                data = data.Where(p => tmp.All(p1 => p1.TenSach != p.TenSach) && p.TenSach.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0).ToList();
                List<BookInfo> l = data.Select(p => new BookInfo
                {
                    TenSach = p.TenSach,
                    SLCL = p.SLCL,
                }).ToList();

                return l;
            }
        }
        private bool checkKH(KhachHang kh)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.KhachHangs.Any(p => p.TenKH == kh.TenKH && p.SDT == kh.SDT);
            }
        }
        public void addKH(KhachHang kh)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                db.KhachHangs.Add(kh);
                db.SaveChanges();
            }
        }
        private int getMaKH(string TenKH)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.KhachHangs.Where(p => p.TenKH == TenKH).FirstOrDefault().MaKH;
            }
        }
        private int getMaSach(string TenSach)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs.Where(p => p.TenSach == TenSach).FirstOrDefault().MaSach;
            }
        }
        public void addHoaDonBan(List<Sach> ls, KhachHang kh, int MaNV)
        {
            if (checkKH(kh) == false)
            {
                addKH(kh);
            }

            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                HoaDonBan hdb = new HoaDonBan
                {
                    MaNV = MaNV,
                    MaKH = getMaKH(kh.TenKH),
                    ThoiGianBan = DateTime.Now,
                };
                db.HoaDonBans.Add(hdb);
                db.SaveChanges();

                foreach (Sach i in ls)
                {
                    HoaDonBanSach hdbs = new HoaDonBanSach
                    {
                        MaHDBan = hdb.MaHDBan,
                        MaSach = getMaSach(i.TenSach),
                        DonGiaBan = i.GiaBan,
                        SoLuongBan = i.SoLuongConLai,
                    };
                    db.HoaDonBanSachs.Add(hdbs);
                    db.SaveChanges();
                }

                hdb.TongTien = 
                    db.HoaDonBanSachs.Where(p => p.MaHDBan == hdb.MaHDBan).ToArray()
                    .Select(p1 => new
                    {
                        TongTien = p1.SoLuongBan * p1.DonGiaBan,
                    }).Sum(p2 => p2.TongTien);
                db.SaveChanges();
            }
        }
    }
}
