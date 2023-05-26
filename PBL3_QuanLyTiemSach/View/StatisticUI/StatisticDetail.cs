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
    public partial class StatisticDetail : Form
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string TenSach { get; set; }
        public string TacGia { get; set; }
        public int TheLoai { get; set; }
        public StatisticDetail()
        {
            InitializeComponent();
        }

        public void DisplayForDoanhThu(List<HoaDonBan> SellInvoices)
        {
            dgv_detail.DataSource = SellInvoices
                .Select(p => new { p.ThoiGianBan.TimeOfDay, p.NhanVien.TenNV, p.TongTien })
                .ToList();
            SetUIForDGVDoanhThu();
        }

        public void DisplayForBook(string tenSach, string tacGia, int theLoai)
        {
            TenSach = tenSach;
            TacGia = tacGia;
            TheLoai = theLoai;
            StatisticBLL statisticBLL = new StatisticBLL();
            dgv_detail.DataSource = statisticBLL.GetBooksForDetail(TenSach, TacGia, TheLoai)
                .Select(p => new { p.MaSach, p.TenSach, GiaNhap = p.HoaDonNhapSachs.Where(hdn => hdn.MaSach == p.MaSach).Select(hdn => hdn.DonGiaNhap).FirstOrDefault(), p.GiaBan, })
                .OrderBy(p => p.GiaBan)
                .ToList();
            btn_changeprice.Visible = true;
        }

        private void SetUIForDGVDoanhThu()
        {
            dgv_detail.Columns[0].HeaderText = "Thời gian bán";
            dgv_detail.Columns[1].HeaderText = "Nhân viên bán";
            dgv_detail.Columns[2].HeaderText = "Tổng tiền";
        }

        private void metroButton_back_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button_changeprice_Click(object sender, EventArgs e)
        {
            ChangePrice changePriceForm = new ChangePrice();
            if (changePriceForm.ShowDialog() == DialogResult.OK)
            {
                List<int> IdBooks = new List<int>();
                foreach (DataGridViewRow dr in dgv_detail.SelectedRows)
                {
                    IdBooks.Add(Convert.ToInt32(dr.Cells["MaSach"].Value.ToString()));
                }
                StatisticBLL statisticBLL = new StatisticBLL();
                double NewPrice = changePriceForm.newPrice;
                statisticBLL.UpdateBookPriceInDetailForm(IdBooks, NewPrice);
                dgv_detail.DataSource = statisticBLL.GetBooksForDetail(TenSach, TacGia, TheLoai)
                    .Select(p => new { p.MaSach, p.TenSach, p.GiaBan })
                    .ToList();
                //LoadDGVSach();
            }
        }
    }
}
