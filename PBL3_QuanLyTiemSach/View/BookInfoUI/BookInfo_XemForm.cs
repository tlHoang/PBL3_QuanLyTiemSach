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
        private string BookName ; 
        public BookInfo_XemForm(string name)
        {
            InitializeComponent();
            this.BookName = name;
            setTextBox();
            setGUI(name);
        }
        private void setTextBox()
        {
            txtTenSach.Enabled = false;
            txtTacGia.Enabled = false;
            txtTheLoai.Enabled = false;
            txtSoLuong.Enabled = false;
            txtGiaBan.Enabled = false;
        }
        private void setGUI(string tenSach)
        {

            try
            {
                using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
                {               
                        List<Sach> SachFilter = db.Sachs.ToList();
                        List<SachTheLoai> theLoai = db.SachTheLoais.ToList();
                        var dataSach = SachFilter.GroupBy(sf => sf.TenSach)
                                                    .Where(g => (string.IsNullOrEmpty(tenSach) || g.FirstOrDefault().TenSach.Contains(tenSach)))                                              
                                                    .Select(g => new
                                                    {
                                                        TenSach = g.Key,
                                                        TacGia = g.FirstOrDefault().TacGia,
                                                        GiaBan = g.FirstOrDefault().GiaBan,
                                                        TheLoai = theLoai.Where(tl => tl.MaTheLoai == g.FirstOrDefault().MaTheLoai).Select(tl => tl.TenTheLoai),
                                                        SL = g.Sum(sf => sf.SoLuongConLai)
                                                    }).ToList();
                    txtTenSach.Text = dataSach[0].TenSach.ToString();
                    txtTacGia.Text = dataSach[0].TacGia.ToString();
                    txtGiaBan.Text = dataSach[0].GiaBan.ToString();
                    txtTheLoai.Text = string.Join(", ", dataSach[0].TheLoai); //Note Join
                    txtSoLuong.Text = dataSach[0].SL.ToString();
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
