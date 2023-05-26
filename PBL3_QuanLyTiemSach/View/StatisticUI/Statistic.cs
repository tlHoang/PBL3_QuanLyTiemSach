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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PBL3_QuanLyTiemSach.View.StatisticUI
{
    public partial class Statistic : MetroFramework.Forms.MetroForm
    {
        public Statistic()
        {
            InitializeComponent();
            SetCBB();
            SetUI();
            LoadDGVDoanhThu(metroComboBox_month.SelectedIndex + 1, ((CBBItem)metroComboBox_year.SelectedItem).Value);
            LoadDGVSach();
            SetUIForDGV();
        }

        private void SetUI()
        {
            metroComboBox_month.SelectedIndex = Convert.ToInt32(DateTime.Now.Month) - 1;
            metroComboBox_year.SelectedIndex = 5;
        }

        private void SetUIForDGV()
        {
            dgv_doanhthu.Columns[0].HeaderText = "Ngày bán";
            dgv_doanhthu.Columns[1].HeaderText = "Số lượng đơn hàng";
            dgv_doanhthu.Columns[2].HeaderText = "Tổng tiền";
            dgv_doanhthu.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_sach.Columns[0].HeaderText = "Tên sách";
            dgv_sach.Columns[1].HeaderText = "Tác giả";
            dgv_sach.Columns[2].HeaderText = "Số lượng còn lại";
            dgv_sach.Columns[3].HeaderText = "Giá bán";
            dgv_sach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgv_sach.Columns["MaTheLoai"].Visible = false;
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
            int soLuongDonHang = 0;
            foreach (DataGridViewRow dr in dgv_doanhthu.Rows)
            {
                doanhThu += Convert.ToDouble(dr.Cells["TongTien"].Value.ToString());
                soLuongDonHang += Convert.ToInt32(dr.Cells["SoLuongDonHang"].Value.ToString());
            }
            metroLabel_doanhthuvalue.Text = doanhThu.ToString() + " vnđ";
            metroLabel_soluongdonhangvalue.Text = soLuongDonHang.ToString() + " đơn";
        }

        private void LoadDGVDoanhThu(int month, int year)
        {
            StatisticBLL statisticBLL = new StatisticBLL();
            dgv_doanhthu.DataSource = statisticBLL.GetSellInvoiceByMonth(month, year)
                .GroupBy(p => p.ThoiGianBan.Date)
                .Select(gr => new
                {
                    ThoiGianBan = gr.Key,
                    SoLuongDonHang = gr.Count(),
                    TongTien = gr.Sum(p => p.TongTien)
                })
                .ToList();
            //SetUIForDGV();
            SetInfoUI();
        }

        private void LoadDGVSach()
        {
            // chon cai duoi neu muon hien thi the loai
            StatisticBLL statisticBLL = new StatisticBLL();
            var books = statisticBLL.GetAllBooks()
                //.GroupBy(p => new { p.TenSach, p.TacGia, p.MaTheLoai, StringComparer.OrdinalIgnoreCase })
                //.Select(gr => new { TenSach = gr.Key.TenSach, TacGia = gr.Key.TacGia, SLCL = gr.Sum(p => p.SoLuongConLai), MaTheLoai = gr.Key.MaTheLoai })
                //.OrderBy(gr => gr.TenSach)
                .GroupBy(p => new { p.TenSach, p.TacGia, p.MaTheLoai, p.GiaBan, StringComparer.OrdinalIgnoreCase })
                .Select(gr => new { TenSach = gr.Key.TenSach, TacGia = gr.Key.TacGia, SLCL = gr.Sum(p => p.SoLuongConLai), GiaBan = gr.Key.GiaBan, MaTheLoai = gr.Key.MaTheLoai })
                .OrderBy(gr => gr.TenSach).ThenBy(gr => gr.GiaBan)
                //.Select(gr => new { TenSach = gr.Key.TenSach, TacGia = gr.Key.TacGia, TheLoai = gr.Where(p => p.SachTheLoai.MaTheLoai == gr.Key.MaTheLoai).Select(p => p.SachTheLoai.TenTheLoai).First(), SLCL = gr.Sum(p => p.SoLuongConLai) })
                .ToList();
            dgv_sach.DataSource = books;
        }

        private void metroButton_xem_Click(object sender, EventArgs e)
        {
            LoadDGVDoanhThu(((CBBItem)metroComboBox_month.SelectedItem).Value, ((CBBItem)metroComboBox_year.SelectedItem).Value);
        }

        private void metroButton_chitiet_Click(object sender, EventArgs e)
        {
            if (dgv_doanhthu.SelectedRows.Count == 1)
            {
                StatisticDetail detailForm = new StatisticDetail();
                //MessageBox.Show(Convert.ToDateTime(dgv_doanhthu.SelectedRows[0].Cells[0].Value).ToString());
                StatisticBLL statisticBLL = new StatisticBLL();
                DateTime date = Convert.ToDateTime(dgv_doanhthu.SelectedRows[0].Cells["ThoiGianBan"].Value);
                //statisticBLL.GetSellInvoiceByDate(date.Day, date.Month, date.Year);
                detailForm.DisplayForDoanhThu(statisticBLL.GetSellInvoiceByDate(date.Day, date.Month, date.Year));
                //Convert.ToDateTime(dgv_doanhthu.SelectedRows[0].Cells[0].Value).ToString();
                detailForm.ShowDialog();
            }
        }

        private void dgv_sach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string TenSach = dgv_sach.Rows[rowIndex].Cells["TenSach"].Value.ToString();
            string TacGia = dgv_sach.Rows[rowIndex].Cells["TacGia"].Value.ToString();
            int TheLoai = Convert.ToInt32(dgv_sach.Rows[rowIndex].Cells["MaTheLoai"].Value.ToString());

            //StatisticBLL statisticBLL = new StatisticBLL();
            StatisticDetail detailForm = new StatisticDetail();
            //detailForm.DisplayForBook(statisticBLL.GetBooksForDetail(TenSach, TacGia, TheLoai));
            detailForm.Month = ((CBBItem)metroComboBox_month.SelectedItem).Value;
            detailForm.Year = ((CBBItem)metroComboBox_year.SelectedItem).Value;
            detailForm.DisplayForBook(TenSach, TacGia, TheLoai);
            detailForm.ShowDialog();
        }

        private void button_changeprice_Click(object sender, EventArgs e)
        {
            if (dgv_sach.SelectedRows.Count == 1)
            {
                ChangePrice changePriceForm = new ChangePrice();
                if (changePriceForm.ShowDialog() == DialogResult.OK)
                {
                    StatisticBLL statisticBLL = new StatisticBLL();
                    double NewPrice = changePriceForm.newPrice;
                    string TenSach = dgv_sach.SelectedRows[0].Cells["TenSach"].Value.ToString();
                    string TacGia = dgv_sach.SelectedRows[0].Cells["TacGia"].Value.ToString();
                    int TheLoai = Convert.ToInt32(dgv_sach.SelectedRows[0].Cells["MaTheLoai"].Value.ToString());
                    statisticBLL.UpdateBooksPrice(TenSach, TacGia, TheLoai, NewPrice);
                    LoadDGVSach();
                }
            }
        }

        public void DisplayStatis()
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoadDGVSach();
        }
    }
}
