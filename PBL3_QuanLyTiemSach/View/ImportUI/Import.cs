using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.View.ImportUI;

namespace PBL3_QuanLyTiemSach.View
{
    public partial class Import : MetroFramework.Forms.MetroForm
    {
        Form1 f;
        public Import(Form1 f1)
        {
            InitializeComponent();
            this.f = f1;
            loadCBB_DVCC();
            SearchText = "";
            TenSach = new List<Sach>();
        }
        public string SearchText { get; set; }

        public List<Sach> TenSach;
        private void loadCBB_DVCC()
        {
            ImportBLL importBLL = new ImportBLL();
            cbbDVCC.Items.AddRange(importBLL.getAllNameDVCC().ToArray());
        }
        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if (txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }
        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if (txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm";
                txtSearch.ForeColor = Color.Silver;
            }
        }
        private bool checkNullInfo()
        {
            if (txtTenSach.Text == null || txtSoLuong.Text == null || txtGiaNhap.Text == null)
            {
                return false;
            }
            return true;
        }
        private void delInfo()
        {
            txtTenSach.Text = txtSoLuong.Text = txtGiaNhap.Text = "";
        }
        public void setBookTitle(string title)
        {
            txtTenSach.Text = title;
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
            SearchBookTitle f = new SearchBookTitle(this);
            f.setBookTitle = setBookTitle;
            f.Show(this);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (checkNullInfo() == true)
            {
                if (!int.TryParse(txtSoLuong.Text, out int SoLuong) || Convert.ToInt32(txtSoLuong.Text) < 1)
                {
                    MetroFramework.MetroMessageBox.Show(f, "\nKiểm tra lại Số lượng sách!", "Thông báo", 140);
                }
                else
                {
                    DataGridViewRow row = (DataGridViewRow)dgvHoaDonNhap.Rows[0].Clone();
                    row.Cells[0].Value = txtTenSach.Text;
                    row.Cells[1].Value = txtGiaNhap.Text;
                    row.Cells[2].Value = txtSoLuong.Text;
                    dgvHoaDonNhap.Rows.Add(row);

                    labelTongTien.Text = dgvHoaDonNhap.Rows.Cast<DataGridViewRow>().Sum(t => (Convert.ToInt32(t.Cells[1].Value) * Convert.ToInt32(t.Cells[2].Value))).ToString() + " đ";
                }
            }
        }
    }
}
