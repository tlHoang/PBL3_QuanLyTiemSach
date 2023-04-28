using System;
using System.Collections.Generic;
using System.Linq;
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
            for (int i = 0; i < ls.Count; i++)
            {
                while (ls[i].SoLuongConLai > 0)
                {
                    using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
                    {
                        (from p in db.Sachs
                         where p.TenSach == ls[i].TenSach && p.SoLuongConLai > 0
                         select p)
                        .ToList().ForEach(x => x.SoLuongConLai -= 1);
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
