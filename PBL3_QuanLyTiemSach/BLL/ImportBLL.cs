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
    }
}
