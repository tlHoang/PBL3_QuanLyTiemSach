using ComponentFactory.Krypton.Toolkit;
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
    public partial class Statistic : KryptonForm
    {
        public Statistic()
        {
            InitializeComponent();
            SetCBB();
            SetUI();
            LoadDGVDoanhThu(((CBBItem)metroComboBox_month.SelectedItem).Value, ((CBBItem)metroComboBox_year.SelectedItem).Value);
            LoadDGVSach();
            LoadDGVLuong(((CBBItem)metroComboBox_month.SelectedItem).Value, ((CBBItem)metroComboBox_year.SelectedItem).Value);
            SetUIForDGV();
        }

        private void SetUI()
        {
            metroComboBox_month.SelectedIndex = Convert.ToInt32(DateTime.Now.Month);
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

            dgv_luong.Columns[0].HeaderText = "Mã nhân viên";
            dgv_luong.Columns[1].HeaderText = "Tên nhân viên";
            dgv_luong.Columns[2].HeaderText = "Lương theo giờ";
            dgv_luong.Columns[3].HeaderText = "Số ca trong tháng";
            dgv_luong.Columns[4].HeaderText = "Lương trong tháng";
            dgv_luong.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_luong.Columns[0].Visible = false;

            dgv_sach.Columns["MaTheLoai"].Visible = false;
        }

        private void SetCBB()
        {
            metroComboBox_month.Items.Add(new CBBItem
            {
                Value = 0,
                Text = "Tất cả"
            });
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

        private void SetInfoRevenue()
        {
            double doanhThu = 0;
            int soLuongDonHang = 0;
            foreach (DataGridViewRow dr in dgv_doanhthu.Rows)
            {
                doanhThu += Convert.ToDouble(dr.Cells["Revenue"].Value.ToString());
                soLuongDonHang += Convert.ToInt32(dr.Cells["InvoiceNumber"].Value.ToString());
            }
            metroLabel_doanhthuvalue.Text = doanhThu.ToString() + " vnd";
            metroLabel_soluongdonhangvalue.Text = soLuongDonHang.ToString() + " đơn";
        }

        private void SetTongLuong()
        {
            double luong = 0;

            foreach (DataGridViewRow dr in dgv_luong.Rows)
            {
                luong += Convert.ToDouble(dr.Cells[4].Value.ToString());
            }
            label_luong.Text = luong.ToString() + " vnd";
        }

        private void LoadDGVDoanhThu(int month, int year)
        {
            StatisticBLL statisticBLL = new StatisticBLL();
            dgv_doanhthu.DataSource = statisticBLL.GetRevenueByMonth(month, year);
            SetInfoRevenue();
        }

        public void LoadDGVSach()
        {
            StatisticBLL statisticBLL = new StatisticBLL();
            dgv_sach.DataSource = statisticBLL.GetAllBooks();
        }

        public void LoadDGVLuong(int month, int year)
        {
            StatisticBLL statisticBLL = new StatisticBLL();
            dgv_luong.DataSource = statisticBLL.GetStaffSalaryByMonth(month, year);
            SetTongLuong();
        }

        private void dgv_sach_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int rowIndex = e.RowIndex;
            string TenSach = dgv_sach.Rows[rowIndex].Cells["TenSach"].Value.ToString();
            string TacGia = dgv_sach.Rows[rowIndex].Cells["TacGia"].Value.ToString();
            int TheLoai = Convert.ToInt32(dgv_sach.Rows[rowIndex].Cells["MaTheLoai"].Value.ToString());

            StatisticDetail detailForm = new StatisticDetail(this);
            detailForm.Month = ((CBBItem)metroComboBox_month.SelectedItem).Value;
            detailForm.Year = ((CBBItem)metroComboBox_year.SelectedItem).Value;
            detailForm.updateBook += LoadDGVSach;
            detailForm.DisplayForBook(TenSach, TacGia, TheLoai);
            detailForm.ShowDialog();
        }

        private void btn_chitiet_Click(object sender, EventArgs e)
        {
            if (dgv_doanhthu.SelectedRows.Count == 1)
            {
                StatisticDetail detailForm = new StatisticDetail(this);
                StatisticBLL statisticBLL = new StatisticBLL();
                DateTime date = Convert.ToDateTime(dgv_doanhthu.SelectedRows[0].Cells["SellDate"].Value);
                detailForm.DisplayForDoanhThu(statisticBLL.GetSellInvoiceByDate(date.Day, date.Month, date.Year));
                detailForm.ShowDialog();
            }
        }

        private void btn_xem_Click(object sender, EventArgs e)
        {
            int month = ((CBBItem)metroComboBox_month.SelectedItem).Value;
            int year = ((CBBItem)metroComboBox_year.SelectedItem).Value;
            LoadDGVDoanhThu(month, year);
            LoadDGVLuong(month, year);
        }

        private void btn_chinhgia_Click(object sender, EventArgs e)
        {
            if (dgv_sach.SelectedRows.Count == 1)
            {
                ChangePrice changePriceForm = new ChangePrice(this);
                if (changePriceForm.ShowDialog() == DialogResult.OK)
                {
                    StatisticBLL statisticBLL = new StatisticBLL();
                    double NewPrice = changePriceForm.NewPrice;
                    string TenSach = dgv_sach.SelectedRows[0].Cells["TenSach"].Value.ToString();
                    string TacGia = dgv_sach.SelectedRows[0].Cells["TacGia"].Value.ToString();
                    int TheLoai = Convert.ToInt32(dgv_sach.SelectedRows[0].Cells["MaTheLoai"].Value.ToString());
                    statisticBLL.UpdateBooksPrice(TenSach, TacGia, TheLoai, NewPrice);
                    LoadDGVSach();
                }
            }
        }
    }
}
