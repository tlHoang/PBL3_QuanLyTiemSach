using PBL3_QuanLyTiemSach.BLL;
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
    public partial class Statistic : MetroFramework.Forms.MetroForm
    {
        public Statistic()
        {
            InitializeComponent();
            SetCBB();
        }

        private void SetCBB()
        {
            for (int i = 1; i <= 12; i++)
            {
                metroComboBox_month.Items.Add(new CBBItem
                {
                    Value = i,
                    Text = $"Tháng {i}"
                });
            }
            int thisYear = Convert.ToInt32(DateTime.Now.Year);
            for (int i = thisYear - 5; i <= thisYear; i++)
            {
                metroComboBox_year.Items.Add(new CBBItem
                {
                    Value = i,
                    Text = $"Năm {i}"
                });
            }
        }

        private void LoadDGV()
        {
            StatisticBLL statisticBLL = new StatisticBLL();
            int month = ((CBBItem)metroComboBox_month.SelectedItem).Value;
            int year = ((CBBItem)metroComboBox_year.SelectedItem).Value;
            dgv_doanhthu.DataSource = statisticBLL.GetSellInvoiceByMonth(month, year)
                .Select(p => new { p.MaHDBan, p.ThoiGianBan.Date, p.TongTien });
        }

        private void metroButton_xem_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }
    }
}
