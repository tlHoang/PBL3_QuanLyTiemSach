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

namespace PBL3_QuanLyTiemSach.View
{
    public partial class BookInfo : MetroFramework.Forms.MetroForm
    {

        public BookInfo()
        {
            InitializeComponent();
            setBookInfoDgv();
        }
        private void setBookInfoDgv()
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {

                List<Sach> sach = db.Sachs.ToList();
                var data = sach.GroupBy(s => s.TenSach)
                                .Select(g => new
                                {
                                    TenSach = g.Key,
                                    SoLuong = g.Sum(s => s.SoLuongConLai)
                                }).ToList();
                dgvBookInfo.DataSource = data;
            }
                dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvBookInfo.Columns["TenSach"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvBookInfo.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvBookInfo.Columns["SoLuong"].HeaderText = "Số Lượng";

        }

        private void btnBookInfoTimKiem_Click(object sender, EventArgs e)
        {
            // Get Data
            string txtTenSach = txtBookInfoTenSach.Text;
            string txtTacGia = txtBookInfoTacGia.Text;
            string txtTheLoai = txtBookInfoTheLoai.Text;
            // DAL
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> SachFilter = db.Sachs.ToList();
                List<SachTheLoai> theLoai = db.SachTheLoais.ToList();
                var dataSach = SachFilter.GroupBy(sf => sf.TenSach)
                                            .Where(g => (string.IsNullOrEmpty(txtTenSach) || g.FirstOrDefault().TenSach.ToLower().Contains(txtTenSach.ToLower())
                                            && (string.IsNullOrEmpty(txtTacGia) || g.FirstOrDefault().TacGia.ToLower().Contains(txtTacGia.ToLower())
                                            && (string.IsNullOrEmpty(txtTheLoai) ||
                                            theLoai.Any(tl => tl.MaTheLoai == g.FirstOrDefault().MaTheLoai && tl.TenTheLoai.ToLower().Contains(txtTheLoai.ToLower()))))))
                                            .Select(g => new
                                            {
                                                TenSach = g.Key,
                                                TacGia = g.FirstOrDefault().TacGia,
                                                TheLoai = string.Join(" ,",theLoai.Where(tl => tl.MaTheLoai == g.FirstOrDefault().MaTheLoai).Select(tl => tl.TenTheLoai)),
                                                SL = g.Sum(sf => sf.SoLuongConLai)
                                            }).ToList();


                dgvBookInfo.DataSource = dataSach;
            }
            dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvBookInfo.Columns["TenSach"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBookInfo.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgvBookInfo.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvBookInfo.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvBookInfo.Columns["SL"].HeaderText = "Số Lượng";
        }

        private void btnBookInfoXem_Click(object sender, EventArgs e)
        {
            if (dgvBookInfo.SelectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = dgvBookInfo.CurrentRow;
                string BookName = selectedRow.Cells["TenSach"].Value.ToString();
                BookInfo_XemForm BIXF = new BookInfo_XemForm(BookName);
                if (BIXF == null || BIXF.IsDisposed)
                {
                    BIXF = new BookInfo_XemForm(BookName);
                }
                BIXF.Show();
            }
            else
            {
                MessageBox.Show("Choose one row !!! ", MessageBoxIcon.Information.ToString());
            }
        }

        private void btnBIThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
} 
   
