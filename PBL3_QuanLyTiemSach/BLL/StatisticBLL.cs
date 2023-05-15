using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
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
                    .Where(p => p.ThoiGianBan.Month == month && p.ThoiGianBan.Year == year)
                    .ToList();
            }
        }
    }
}
