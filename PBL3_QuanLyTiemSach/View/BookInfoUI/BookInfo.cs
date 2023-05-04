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

                List<Sach> SachFilter = db.Sachs.ToList();
                
                var sach = SachFilter.GroupBy(sf => sf.TenSach)
                                            .Select(g => new
                                            {
                                                TenSach = g.Key,
                                                SL = g.Sum( sf => sf.SoLuongConLai)
                                            });
                dgvBookInfo.DataSource = SachFilter.ToList() ;
            }
                dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
                dgvBookInfo.Columns["TenSach"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvBookInfo.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dgvBookInfo.Columns["SL"].HeaderText = "Số Lượng Còn Lại";
/*                dgvBookInfo.Columns["ID"].HeaderText = "Mã Sách";
                dgvBookInfo.Columns["ID"].Visible = false;*/
        }

        private void btnBookInfoTimKiem_Click(object sender, EventArgs e)
        {
           /* string txtTenSach = txtBookInfoTenSach.Text;
            string txtTacGia = txtBookInfoTacGia.Text;
            string txtTheLoai = txtBookInfoTheLoai.Text;
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> SachFilter = db.Sachs.ToList(); 
                List<SachTheLoai> theLoai = db.SachTheLoais.ToList();
                List<Sach> sach = SachFilter.GroupBy(sf => sf.TenSach).Select(g => g.)
               *//* var dataSach = SachFilter.GroupBy(sf => sf.TenSach)
                                            .Select(g => new
                                            {
                                            TenSach = g.Key,
                                            TacGia = g.FirstOrDefault().TacGia,
                                            TheLoai = theLoai.Where(tl => tl.MaTheLoai == g.FirstOrDefault().MaTheLoai).ToList(),
                                            SL = g.Sum(sf => sf.SoLuongConLai)
                                            }).ToList();
               
                var dataView = dataSach.Where(s => (string.IsNullOrEmpty(txtTenSach) || s.TenSach.Contains(txtTenSach))
                                            && (string.IsNullOrEmpty(txtTacGia) || s.TacGia.Contains(txtTacGia))
                                            && (string.IsNullOrEmpty(txtTheLoai) ||
                                            theLoai.Any(tl => tl.MaTheLoai == s.MaTheLoai && tl.TenTheLoai.Contains(txtTheLoai))))
                    .ToList();
                dgvBookInfo.DataSource = dataView;*//*
            }
            *//*dgvBookInfo.Columns["ID"].HeaderText = "Mã Sách";
            dgvBookInfo.Columns["ID"].Visible = false;*//*
            dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvBookInfo.Columns["TenSach"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBookInfo.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

            dgvBookInfo.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvBookInfo.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvBookInfo.Columns["SL"].HeaderText = "Số Lượng";*/
        }

        private void btnBookInfoXem_Click(object sender, EventArgs e)
        {
            /*if (dgvBookInfo.SelectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = dgvBookInfo.CurrentRow;
                string BookID = selectedRow.Cells["ID"].Value.ToString();
                BookInfo_XemForm BIXF = new BookInfo_XemForm(BookID);
                if (BIXF == null || BIXF.IsDisposed)
                {
                    BIXF = new BookInfo_XemForm(BookID);
                }
                BIXF.Show();
            }
            else
            {
                MessageBox.Show("Choose one row !!! ", MessageBoxIcon.Information.ToString());
            }*/
        }

        private void btnBIThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
} 
   
