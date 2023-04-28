using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
