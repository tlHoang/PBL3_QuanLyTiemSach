using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class GetBookInfoBLL
    {
        public List<string> getAllBookTitle(List<Sach> TenSach, string SearchText)
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var tmp1 = TenSach.Select(p => new
                {
                    TenSach = p.TenSach,
                    SLCL = 1
                }).ToList();

                var data = db.Sachs.GroupBy(p => p.TenSach)
                    .ToList();

                List<string> l = new List<string>();
                foreach (var item in data)
                {
                    l.Add(item.Key);
                }

                var tmp2 = l.Select(p => new { TenSach = p })
                    .Where(p => tmp1.All(p1 => p1.TenSach != p.TenSach) && p.TenSach.IndexOf(SearchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

                return tmp2.Select(p => p.TenSach).ToList();
            }
        }
        public List<string> getAllTenTheLoai()
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<string> result = new List<string>();
                var data = db.SachTheLoais.ToArray();
                foreach (var item in data)
                {
                    result.Add(item.TenTheLoai);
                }
                return result;
            }
        }
        public Sach getSachFromTenSach(string TenSach)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs.Where(p => p.TenSach.Contains(TenSach)).FirstOrDefault();
            }
        }
        public string getTheLoaiFromMaTheLoai(int MaTheLoai)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.SachTheLoais.Where(p => p.MaTheLoai == MaTheLoai).FirstOrDefault().TenTheLoai;
            }
        }
        public int getMaTheLoaiFromTenTheLoai(string TenTheLoai)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.SachTheLoais.Where(p => p.TenTheLoai == TenTheLoai).FirstOrDefault().MaTheLoai;
            }
        }
        public bool checkBook(string TenSach)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Sachs.Any(p => p.TenSach == TenSach);
            }
        }
        public void addBook(Sach s)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                db.Sachs.Add(s);
                db.SaveChanges();
            }
        }
    }
}
