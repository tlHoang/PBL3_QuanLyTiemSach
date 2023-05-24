using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    internal class QLTS_BI_BLL
    {
        public List<string> getAllTheLoai()
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.SachTheLoais.Select(stl =>stl.TenTheLoai).ToList();
            }
        }
        public DataTable getDataBaseListBook()
        {
            DataTable dt = new DataTable();
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> sach = db.Sachs.ToList();
                var data = sach.GroupBy(s => s.TenSach)
                                .Select(g => new
                                {
                                    TenSach = g.Key,
                                    SoLuong = g.Sum(s => s.SoLuongConLai)
                                }).ToList();
                dt.Columns.Add("TenSach");
                dt.Columns.Add("SoLuong");
                foreach(var item in data)
                {
                    dt.Rows.Add(item.TenSach, item.SoLuong);
                }
            }
            return dt;
        }
        public DataTable getDataFindListBook(string tenSach, string tacGia, string type)
        {
            DataTable dt = new DataTable();
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> SachFilter = db.Sachs.ToList();
                List<SachTheLoai> theLoai = db.SachTheLoais.ToList();
                var dataSach = SachFilter.GroupBy(sf => sf.TenSach)
                                            .Where(g =>
                                            (string.IsNullOrEmpty(tenSach) || g.FirstOrDefault().TenSach.ToLower().Contains(tenSach.ToLower()))
                                            && (string.IsNullOrEmpty(tacGia) || g.FirstOrDefault().TacGia.ToLower().Contains(tacGia.ToLower()))
                                            && (string.IsNullOrEmpty(type) || theLoai.Any(tl => tl.MaTheLoai == g.FirstOrDefault().MaTheLoai 
                                            && tl.TenTheLoai.ToLower().Contains(type.ToLower()))))
                                            .Select(g => new
                                            {
                                                TenSach = g.Key,
                                                TacGia = g.FirstOrDefault().TacGia,
                                                TheLoai = string.Join(" ,", theLoai.Where(tl => tl.MaTheLoai == g.FirstOrDefault().MaTheLoai).Select(tl => tl.TenTheLoai)),
                                                SL = g.Sum(sf => sf.SoLuongConLai)
                                            }).ToList();
                dt.Columns.Add("TenSach");
                dt.Columns.Add("TacGia");
                dt.Columns.Add("TheLoai");
                dt.Columns.Add("SL");
                foreach(var item in dataSach)
                {
                    dt.Rows.Add(item.TenSach,item.TacGia,item.TheLoai,item.SL);
                }
            }
                return dt;
        }
        public DataTable getInfoBook(string tenSach)
        {
            DataTable dt = new DataTable();
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> SachFilter = db.Sachs.ToList();
                List<SachTheLoai> theLoai = db.SachTheLoais.ToList();
                var dataSach = SachFilter.GroupBy(sf => sf.TenSach)
                                            .Where(g => (string.IsNullOrEmpty(tenSach) || g.FirstOrDefault().TenSach.Contains(tenSach)))
                                            .Select(g => new
                                            {
                                                TenSach = g.Key,
                                                TacGia = g.FirstOrDefault().TacGia,
                                                GiaBan = g.FirstOrDefault().GiaBan,
                                                TheLoai = theLoai.Where(tl => tl.MaTheLoai == g.FirstOrDefault().MaTheLoai).Select(tl => tl.TenTheLoai),
                                                SL = g.Sum(sf => sf.SoLuongConLai)
                                            }).ToList();
                dt.Columns.Add("TenSach");
                dt.Columns.Add("TacGia");
                dt.Columns.Add("GiaBan");
                dt.Columns.Add("TheLoai");
                dt.Columns.Add("SL");
                foreach (var item in dataSach)
                {
                    dt.Rows.Add(item.TenSach, item.TacGia, item.GiaBan, string.Join(",", item.TheLoai), item.SL);
                }
            }
            return dt;
        }
    }
}
