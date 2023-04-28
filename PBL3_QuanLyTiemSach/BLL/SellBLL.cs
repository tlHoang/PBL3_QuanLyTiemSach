using System;
using System.Collections.Generic;
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
            for (int i = 0; i < ls.Count; i++)
            {
                int slcl = ls[i].SoLuongConLai;
                string ten = ls[i].TenSach;
                while (slcl > 0)
                {
                    using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
                    {
                        Sach s = 
                            (from p in db.Sachs
                            where p.TenSach == ten && p.SoLuongConLai > 0
                            select p)
                            .FirstOrDefault();
                        if (s.SoLuongConLai > slcl)
                        {
                            s.SoLuongConLai -= slcl;
                            slcl = 0;
                        }
                        else
                        {
                            slcl -= s.SoLuongConLai;
                            s.SoLuongConLai = 0;
                        }
                        db.SaveChanges();
                    }
                }
            }
        }
    }
}
