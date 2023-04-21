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
    public partial class BookInfo_XemForm : MetroFramework.Forms.MetroForm
    {
        private string BookID ; 
        public BookInfo_XemForm(string id)
        {
            InitializeComponent();
            this.BookID = id;
            setTextBox();
            setGUI(id);
        }
        private void setTextBox()
        {
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            txtTheLoai.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaBan.Enabled = false;
        }
        private void setGUI(string id)
        {
            
            try
            {
                using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
                {
                    List<Sach> sach = db.Sachs.ToList();
                    List<Kho> kho = db.Khos.ToList();
                    List<SachTheLoai> theLoai = db.SachTheLoais.ToList();
                    string MaTheLoai = sach.Where(s => s.MaSach == id).Select(s => s.MaTheLoai).FirstOrDefault().ToString();
                    string MaKho = sach.Where(s => s.MaSach == id).Select(s => s.MaKho).FirstOrDefault().ToString(); 
                    txtTenSach.Text = sach.Where(s => s.MaSach == id).Select(s => s.TenSach).FirstOrDefault().ToString();
                    txtTacGia.Text = sach.Where(s => s.MaSach == id).Select(s => s.TacGia).FirstOrDefault().ToString();
                    txtGiaBan.Text = sach.Where(s => s.MaSach == id).Select(s => s.GiaBan).FirstOrDefault().ToString();
                    txtTheLoai.Text = theLoai.Where(tl => tl.MaTheLoai == MaTheLoai).FirstOrDefault()?.TenTheLoai.ToString();
                    txtSoLuong.Text = kho.Where(k => k.MaKho == MaKho).FirstOrDefault()?.SoLuongSachConLai.ToString();
                }
            }
            catch 
            {
                MessageBox.Show("Error!!!", MessageBoxIcon.Error.ToString());
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
