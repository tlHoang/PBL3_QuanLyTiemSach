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
            SetUI();
            LoadDGV(metroComboBox_month.SelectedIndex + 1, ((CBBItem)metroComboBox_year.SelectedItem).Value);
        }

        private void SetUI()
        {
            metroComboBox_month.SelectedIndex = Convert.ToInt32(DateTime.Now.Month) - 1;
            metroComboBox_year.SelectedIndex = 5;
        }

        private void SetUIForDGV()
        {
            dgv_doanhthu.Columns[0].HeaderText = "Ngày bán";
            dgv_doanhthu.Columns[1].HeaderText = "Tổng tiền";
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

        private void SetInfoUI()
        {
            double doanhThu = 0;
            foreach (DataGridViewRow dr in dgv_doanhthu.Rows)
            {
                doanhThu += Convert.ToInt32(dr.Cells["TongTien"].Value.ToString());
            }
            metroLabel_doanhthuvalue.Text = doanhThu.ToString();
        }

        private void LoadDGV(int month, int year)
        {
            StatisticBLL statisticBLL = new StatisticBLL();
            dgv_doanhthu.DataSource = statisticBLL.GetSellInvoiceByMonth(month, year)
                .GroupBy(p => p.ThoiGianBan.Date)
                .Select(gr => new
                {
                    ThoiGianBan = gr.Key,
                    TongTien = gr.Sum(p => p.TongTien)
                })
                .ToList();
            SetUIForDGV();
            SetInfoUI();
        }

        private void metroButton_xem_Click(object sender, EventArgs e)
        {
            LoadDGV(((CBBItem)metroComboBox_month.SelectedItem).Value, ((CBBItem)metroComboBox_year.SelectedItem).Value);
        }

        private void metroButton_chitiet_Click(object sender, EventArgs e)
        {
            if (dgv_doanhthu.SelectedRows.Count == 1)
            {
                StatisticDetail detailForm = new StatisticDetail();
                //MessageBox.Show(Convert.ToDateTime(dgv_doanhthu.SelectedRows[0].Cells[0].Value).ToString());
                StatisticBLL statisticBLL = new StatisticBLL();
                DateTime date = Convert.ToDateTime(dgv_doanhthu.SelectedRows[0].Cells[0].Value);
                //statisticBLL.GetSellInvoiceByDate(date.Day, date.Month, date.Year);
                detailForm.Display(statisticBLL.GetSellInvoiceByDate(date.Day, date.Month, date.Year));
                //Convert.ToDateTime(dgv_doanhthu.SelectedRows[0].Cells[0].Value).ToString();
                detailForm.ShowDialog();
            }
        }
    }
}
