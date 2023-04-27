using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View
{
    public partial class ShiftManage : MetroFramework.Forms.MetroForm
    {
        public ShiftManage()
        {
            InitializeComponent();
        }
        private void setCBB()
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Ca> ca = new List<Ca>();
                List<NhanVien> nhanVien = new List<NhanVien>();
                List<CaNV> caNV = new List<CaNV>();
                var dataNV = nhanVien.Select(nv => new 
                {
                    MaNV = nv.MaNV.FirstOrDefault(),
                    TenNhanVien = nv.TenNV.FirstOrDefault(),
                  //  GioBatDau = ca.Where(c => c.MaCa == caNV.Select(cnv => cnv.MaCa).ToString() && )

                });
            }
        }
        private void btnSMThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
