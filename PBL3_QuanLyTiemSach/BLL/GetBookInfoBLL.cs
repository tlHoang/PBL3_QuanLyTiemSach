using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class GetBookInfoBLL
    {
        public List<string> getAllBookTitle()
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<string> result = new List<string>();
                var data = db.Sachs.GroupBy(p => p.TenSach)
                    .ToList();
                foreach (var item in data)
                {
                    result.Add(item.Key);
                }
                return result;
            }
        }
    }
}
