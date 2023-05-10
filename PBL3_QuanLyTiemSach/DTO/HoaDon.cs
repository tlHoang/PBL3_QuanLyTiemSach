using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach.DTO
{
    public class HoaDon
    {
        public int ID { get; set; }
        public DateTime Date { get; set; }
        public string StaffName { get; set; }
        public string TenKH_DVCC { get; set; }
        public double Total { get; set; }
    }
}
