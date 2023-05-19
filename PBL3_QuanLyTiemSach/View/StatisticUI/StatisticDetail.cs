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

namespace PBL3_QuanLyTiemSach.View.StatisticUI
{
    public partial class StatisticDetail : Form
    {
        public StatisticDetail()
        {
            InitializeComponent();
        }

        public void Display(List<HoaDonBan> hoaDonBans)
        {
            dgv_detail.DataSource = hoaDonBans
                .Select(p => new { p.ThoiGianBan.TimeOfDay, p.NhanVien.TenNV, p.TongTien })
                .ToList();
        }

        private void metroButton_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
