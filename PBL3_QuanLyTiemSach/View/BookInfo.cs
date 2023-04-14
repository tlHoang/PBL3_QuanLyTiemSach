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
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> sach = db.Sachs.ToList();
                List<Kho> kho = db.Khos.ToList();
                var dataView = sach.Select(s => new
                {
                    ID = s.MaSach,
                    TenSach = s.TenSach,
                    SL = kho.Where(k => k.MaKho == s.MaKho).Select(k => k.SoLuongSachConLai).Single()
                }).ToList();
                dgvBookInfo.DataSource = dataView;
            }
            dgvBookInfo.Columns["ID"].HeaderText = "Mã Sách";
            dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvBookInfo.Columns["SL"].HeaderText = "Số Lượng";

        }

        private void btnBookInfoTimKiem_Click(object sender, EventArgs e)
        {
            string txtTenSach = txtBookInfoTenSach.Text;
            string txtTacGia = txtBookInfoTacGia.Text;
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Sach> sach = db.Sachs.ToList();
                List<Kho> kho = db.Khos.ToList();
                List<SachTheLoai> theLoai = db.SachTheLoais.ToList();
                var dataView = sach.Select(s => new
                {
                    ID = s.MaSach,
                    TenSach = s.TenSach,
                    TheLoai = theLoai.Where( tl => tl.MaTheLoai == s.MaTheLoai).Select(tl => tl.TenTheLoai).Single(),
                    SL = kho.Where(k => k.MaKho == s.MaKho).Select(k => k.SoLuongSachConLai).Single()
                }).ToList();
                dataView.Where(sach.Where(s => s.TenSach == txtTenSach && s.TacGia == txtTacGia).Single();
                dgvBookInfo.DataSource = dataView;
            }
            dgvBookInfo.Columns["ID"].HeaderText = "Mã Sách";
            dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvBookInfo.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvBookInfo.Columns["SL"].HeaderText = "Số Lượng";
        }
    }
}
