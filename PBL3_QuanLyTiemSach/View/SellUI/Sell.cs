using MetroFramework;
using MetroFramework.Controls;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.View.SellUI;
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
using PBL3_QuanLyTiemSach.BLL;
using System.Globalization;

namespace PBL3_QuanLyTiemSach
{
    public partial class Sell : MetroFramework.Forms.MetroForm
    {
        Form1 f;
        public Sell(Form1 f1)
        {
            InitializeComponent();
            this.f = f1;
            SearchText = "";
            TenSach = new List<Sach>();
            Sach_HoaDon = new List<Sach>();
        }
        public string SearchText { get; set; }
        public int SL { get; set; }
        public List<Sach> TenSach { get; set; }
        public List<Sach> Sach_HoaDon { get; set; }
        public void SetBookInfo(string TenSach)
        {
            SellBLL sellBLL = new SellBLL();
            if (TenSach != null)
            {
                txtTenSach.Text = TenSach;
                txtDonGia.Text = sellBLL.getGiaBanSach(TenSach).ToString();
                SL = sellBLL.getSLSachConLai(TenSach);
            }
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void set_txtSearch()
        {
            txtSearch.Text = "Tìm kiếm";
            txtSearch.ForeColor = Color.Silver;
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                set_txtSearch();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm")
            {
                SearchText = "";
            }
            else
            {
                SearchText = txtSearch.Text;
            }
            SearchBookInfo f = new SearchBookInfo(this);
            f.setBookInfo = SetBookInfo;
            f.Show();
            delInfo();
            set_txtSearch();
        }
        private bool checkNullInfo()
        {
            if (txtTenSach.Text == null && txtSoLuong.Text == null)
            {
                return false;
            }
            return true;
        }
        private void delInfo()
        {
            txtTenSach.Text = txtDonGia.Text = txtSoLuong.Text = "";
            SL = 0;
        }
        private void setLabelTongTien()
        {
            labelTongTien.Text = dgvHoaDonBan.Rows.Cast<DataGridViewRow>().Sum(t => (Convert.ToInt32(t.Cells[1].Value) * Convert.ToInt32(t.Cells[2].Value))).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNullInfo() == true)
            {
                int SoLuong = 0;
                if (!int.TryParse(txtSoLuong.Text, out SoLuong) || Convert.ToInt32(txtSoLuong.Text) < 1 || Convert.ToInt32(txtSoLuong.Text) > SL)
                {
                    MetroFramework.MetroMessageBox.Show(f, "\nKiểm tra lại Số lượng sách!", "Thông báo", 140);
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)dgvHoaDonBan.Rows[0].Clone();
                    row.Cells[0].Value = txtTenSach.Text;
                    row.Cells[1].Value = txtDonGia.Text;
                    row.Cells[2].Value = txtSoLuong.Text;
                    dgvHoaDonBan.Rows.Add(row);

                    TenSach.Add(new Sach
                    {
                        TenSach = txtTenSach.Text,
                    });

                    setLabelTongTien();
                    delInfo();
                    set_txtSearch();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroMessageBox.Show(f, "\nBạn có muốn xóa những sách đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 140);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in dgvHoaDonBan.SelectedRows)
                    {
                        var itemToRemove = TenSach.Single(p => p.TenSach == dgvHoaDonBan.Rows[i.Index].Cells[0].Value.ToString());
                        TenSach.Remove(itemToRemove);
                        dgvHoaDonBan.Rows.RemoveAt(i.Index);
                    }
                    setLabelTongTien();
                }
                else
                {
                    return;
                }
            }
        }
        public int getSLSachDGV()
        {
            if (dgvHoaDonBan.SelectedRows[0].Index < dgvHoaDonBan.Rows.Count - 1)
            {
                return Convert.ToInt32(dgvHoaDonBan.SelectedRows[0].Cells[2].Value.ToString());
            }
            else return -1;
        }
        private void btnCong_Click(object sender, EventArgs e)
        {
            SellBLL sellBLL = new SellBLL();
            if (dgvHoaDonBan.SelectedRows.Count != 1)
            {
                MetroMessageBox.Show(f, "\nVui lòng chọn 1 mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
            }
            else
            {
                int SLinDGV = getSLSachDGV();
                if (SLinDGV == -1)
                {

                }
                else if (SLinDGV < sellBLL.getSLSachConLai(dgvHoaDonBan.SelectedRows[0].Cells[0].Value.ToString()))
                {
                    dgvHoaDonBan.SelectedRows[0].Cells[2].Value = SLinDGV + 1;
                    setLabelTongTien();
                }
                else
                {
                    MetroMessageBox.Show(f, "\nSố lượng đã đạt tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
                }
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.SelectedRows.Count != 1)
            {
                MetroMessageBox.Show(f, "\nVui lòng chọn 1 mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
            }
            else
            {
                int SLinDGV = getSLSachDGV();
                if (SLinDGV == -1)
                {

                }
                else if (SLinDGV == 1)
                {
                    MetroMessageBox.Show(f, "\nSố lượng đã đạt tối thiểu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
                }
                else
                {
                    dgvHoaDonBan.SelectedRows[0].Cells[2].Value = SLinDGV - 1;
                    setLabelTongTien();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonBan.RowCount > 1)
            {
                DialogResult dr = MetroMessageBox.Show(f, "\nBạn có muốn lưu hóa đơn?", "Lưu hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 140);
                if (dr == DialogResult.Yes)
                {
                    for (int i = 0; i < dgvHoaDonBan.Rows.Count - 1; i++)
                    {
                        Sach_HoaDon.Add(new Sach
                        {
                            TenSach = dgvHoaDonBan.Rows[i].Cells[0].Value.ToString(),
                            GiaBan = Convert.ToDouble(dgvHoaDonBan.Rows[i].Cells[1].Value.ToString()),
                            SoLuongConLai = Convert.ToInt32(dgvHoaDonBan.Rows[i].Cells[2].Value.ToString()),
                            // SoLuongConLai ở đây là số lượng sách có tên là TenSach mà khách mua được lưu trong hóa đơn
                        });
                    }

                    SellBLL sellBLL = new SellBLL();
                    sellBLL.updateSachinDatabase(Sach_HoaDon);
                    sellBLL.addHoaDonBan(Sach_HoaDon, getKH(), f.MaNV);
                    delInfo();
                    dgvHoaDonBan.Rows.Clear();
                    txtTenKH.Text = txtSDT.Text = "";
                    TenSach.Clear();
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(f, "Kiểm tra lại thông tin hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, 140);
            }
        }
        private KhachHang getKH()
        {
            if (txtTenKH.Text != "")
            {
                return new KhachHang
                {
                    TenKH = txtTenKH.Text,
                    SDT = txtSDT.Text,
                };
            }
            else
            {
                return new KhachHang
                {
                    TenKH = "Khách lẻ",
                    SDT = txtSDT.Text,
                };
            }
        }
    }
}
