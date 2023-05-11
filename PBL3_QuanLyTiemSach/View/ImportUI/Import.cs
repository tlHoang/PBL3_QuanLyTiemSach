using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
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
            loadCBB_TheLoai();
            SearchText = "";
            TenSach = new List<Sach>();
            Sach_HDB = new List<Sach>();
        }
        public string SearchText { get; set; }

        public List<Sach> TenSach;
        public List<Sach> Sach_HDB;
        private void loadCBB_DVCC()
        {
            ImportBLL bll = new ImportBLL();
            cbbDVCC.Items.AddRange(bll.getAllNameDVCC().ToArray());
        }
        private void loadCBB_TheLoai()
        {
            GetBookInfoBLL bll = new GetBookInfoBLL();
            cbbTheLoai.Items.AddRange(bll.getAllTenTheLoai().ToArray());
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
        private bool checkNullInfo()
        {
            if (txtTenSach.Text == null || txtSoLuong.Text == null || txtGiaNhap.Text == null || txtTacGia.Text == null || cbbTheLoai.Text == "")
            {
                return false;
            }
            return true;
        }
        private void delInfo()
        {
            txtTacGia.Text = txtTenSach.Text = txtSoLuong.Text = txtGiaNhap.Text = "";
            cbbTheLoai.SelectedItem = null;
        }
        public void setBookTitle(string title)
        {
            GetBookInfoBLL bll = new GetBookInfoBLL();
            txtTenSach.Text = title;
            Sach tmp = bll.getSachFromTenSach(title);
            txtTacGia.Text = tmp.TacGia;
            cbbTheLoai.Text = bll.getTheLoaiFromMaTheLoai(tmp.MaTheLoai);
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
            delInfo();
            set_txtSearch();
        }
        private void setLabelTongTien()
        {
            labelTongTien.Text = dgvHoaDonNhap.Rows.Cast<DataGridViewRow>().Sum(t => (Convert.ToInt32(t.Cells[1].Value) * Convert.ToInt32(t.Cells[2].Value))).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        }
        private void checkCBB()
        {
            if (cbbTheLoai.FindString(cbbTheLoai.Text) == -1)
            {
                ImportBLL bll = new ImportBLL();
                bll.addTheLoai(cbbTheLoai.Text);
            }
            if (cbbDVCC.FindString(cbbDVCC.Text) == -1)
            {
                ImportBLL bll = new ImportBLL();
                bll.addDVCC(cbbDVCC.Text);
            }
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
                    row.Cells[3].Value = txtTacGia.Text;
                    row.Cells[4].Value = cbbTheLoai.Text;
                    dgvHoaDonNhap.Rows.Add(row);

                    TenSach.Add(new Sach
                    {
                        TenSach = txtTenSach.Text
                    });

                    setLabelTongTien();
                    delInfo();
                    set_txtSearch();
                }
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhap.RowCount > 1 && cbbDVCC.Text != "")
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(f, "\nBạn có muốn lưu hóa đơn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 140);
                if (dr == DialogResult.Yes)
                {
                    checkCBB();
                    for (int i = 0; i < dgvHoaDonNhap.RowCount - 1; i++)
                    {
                        GetBookInfoBLL bll = new GetBookInfoBLL();
                        Sach s = new Sach
                        {
                            TenSach = dgvHoaDonNhap.Rows[i].Cells[0].Value.ToString(),
                            TacGia = dgvHoaDonNhap.Rows[i].Cells[3].Value.ToString(),
                            MaTheLoai = bll.getMaTheLoaiFromTenTheLoai(dgvHoaDonNhap.Rows[i].Cells[4].Value.ToString()),
                            GiaBan = Convert.ToDouble(dgvHoaDonNhap.Rows[i].Cells[1].Value.ToString()),
                            // Đây là giá nhập vào của sách này
                            SoLuongConLai = Convert.ToInt32(dgvHoaDonNhap.Rows[i].Cells[2].Value.ToString())
                            // == số lượng nhập
                        };
                        bll.addBook(s);
                        // Sách mới thêm có GiaBan == GiaNhap
                        Sach_HDB.Add(s);
                    }
                    ImportBLL ibll = new ImportBLL();
                    ibll.addHDN(Sach_HDB, f.MaNV, cbbDVCC.Text);
                }
            }
            else
            {
                MetroFramework.MetroMessageBox.Show(f, "Kiểm tra lại thông tin hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error, 140);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhap.SelectedRows.Count > 0)
            {
                DialogResult dr = MetroMessageBox.Show(f, "\nBạn có muốn xóa những sách đã chọn?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 140);
                if (dr == DialogResult.Yes)
                {
                    foreach (DataGridViewRow i in dgvHoaDonNhap.SelectedRows)
                    {
                        if (i.Index != dgvHoaDonNhap.RowCount - 1)
                        {
                            var itemToRemove = TenSach.Single(p => p.TenSach == dgvHoaDonNhap.Rows[i.Index].Cells[0].Value.ToString());
                            TenSach.Remove(itemToRemove);
                            dgvHoaDonNhap.Rows.RemoveAt(i.Index);
                        }
                    }
                    setLabelTongTien();
                }
            }
        }
        private void editRowInDGV(List<string> ls, int rowIndex)
        {
            for (int i = 0; i < ls.Count; i++)
            {
                dgvHoaDonNhap.Rows[rowIndex].Cells[i].Value = ls[i];
            }
            setLabelTongTien();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvHoaDonNhap.SelectedRows.Count > 1 || dgvHoaDonNhap.SelectedRows.Count == 0 || dgvHoaDonNhap.CurrentCell.RowIndex == dgvHoaDonNhap.RowCount - 1)
            {
                MetroFramework.MetroMessageBox.Show(f, "\nChọn 1 mục để sửa", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
            }
            else
            {
                int RowIndex = dgvHoaDonNhap.SelectedCells[0].RowIndex;
                EditBookInfo f = new EditBookInfo(this, RowIndex,
                    dgvHoaDonNhap.Rows[RowIndex].Cells[0].Value.ToString(),
                    dgvHoaDonNhap.Rows[RowIndex].Cells[3].Value.ToString(),
                    dgvHoaDonNhap.Rows[RowIndex].Cells[4].Value.ToString(),
                    dgvHoaDonNhap.Rows[RowIndex].Cells[2].Value.ToString(),
                    dgvHoaDonNhap.Rows[RowIndex].Cells[1].Value.ToString()
                    );
                f.editDGV = editRowInDGV;
                f.Show();
            }
        }
    }
}
