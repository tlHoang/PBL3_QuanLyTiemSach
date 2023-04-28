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

namespace PBL3_QuanLyTiemSach
{
    public partial class Sell : MetroFramework.Forms.MetroForm
    {
        Form1 f;
        public Sell(Form1 f1)
        {
            InitializeComponent();
            this.f = f1;
            this.TopMost = true;
            this.ControlBox = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            txtSearch.Text = "Tìm kiếm";
            txtSearch.ForeColor = Color.Silver;
            txtTenSach.Enabled = false;
            txtDonGia.Enabled = false;
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
            if(txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm";
                txtSearch.ForeColor = Color.Silver;
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Tìm kiếm")
            {
                SearchText = "";
            }
            else
            {
                SearchText = txtSearch.Text;
            }
            SearchBook f = new SearchBook(this);
            f.setBookInfo = SetBookInfo;
            f.Show();
            delInfo();
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

                    labelTongTien.Text = dgvHoaDonBan.Rows.Cast<DataGridViewRow>().Sum(t => (Convert.ToInt32(t.Cells[1].Value) * Convert.ToInt32(t.Cells[2].Value))).ToString() + " đ";
                    delInfo();
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
                    labelTongTien.Text = dgvHoaDonBan.Rows.Cast<DataGridViewRow>().Sum(t => (Convert.ToInt32(t.Cells[1].Value) * Convert.ToInt32(t.Cells[2].Value))).ToString() + " đ";
                }
                else
                {
                    return;
                }
            }
        }
        public int getSLSachDGV()
        {
            return Convert.ToInt32(dgvHoaDonBan.SelectedRows[0].Cells[2].Value.ToString());
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
                SL = sellBLL.getSLSachConLai(dgvHoaDonBan.SelectedRows[0].Cells[0].Value.ToString());
                int SLinDGV = getSLSachDGV();
                if (SLinDGV < SL)
                {
                    dgvHoaDonBan.SelectedRows[0].Cells[2].Value = SLinDGV + 1;
                }
                else
                {
                    MetroMessageBox.Show(f, "\nSố lượng đã đạt tối đa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
                }
            }
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            SellBLL sellBLL = new SellBLL();
            if (dgvHoaDonBan.SelectedRows.Count != 1)
            {
                MetroMessageBox.Show(f, "\nVui lòng chọn 1 mục!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
            }
            else
            {
                int SLinDGV = getSLSachDGV();
                if (SLinDGV == 1)
                {
                    MetroMessageBox.Show(f, "\nSố lượng đã đạt tối thiểu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
                }
                else
                {
                    dgvHoaDonBan.SelectedRows[0].Cells[2].Value = SLinDGV - 1;
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                (from p in db.Sachs
                where p.TenSach == "Duy Tân" select p)
                .ToList().ForEach(x => x.SoLuongConLai -= 1);
                db.SaveChanges();
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = MetroMessageBox.Show(f, "\nBạn có muốn lưu hóa đơn?", "Lưu hóa đơn", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 140);
            if (dr == DialogResult.Yes)
            {
                for (int i = 0; i < dgvHoaDonBan.Rows.Count - 1; i++)
                {
                    Sach_HoaDon.Add(new Sach
                    {
                        TenSach = dgvHoaDonBan.Rows[i].Cells[0].Value.ToString(),
                        SoLuongConLai = Convert.ToInt32(dgvHoaDonBan.Rows[i].Cells[2].Value.ToString()),
                    });
                }
                //foreach (DataGridViewRow i in dgvHoaDonBan.Rows)
                //{
                //    Sach_HoaDon.Add(new Sach
                //    {
                //        TenSach = i.Cells[0].Value.ToString(),
                //        SoLuongConLai = Convert.ToInt32(i.Cells[2].Value.ToString()),
                //    });
                //}
                SellBLL sellBLL = new SellBLL();
                sellBLL.updateSachinDatabase(Sach_HoaDon);
            }
            else return;
        }
    }
}
