using ComponentFactory.Krypton.Toolkit;
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

namespace PBL3_QuanLyTiemSach.View
{
    public partial class BookInfo_XemForm : KryptonForm
    {
        private string BookName ; 
        public BookInfo_XemForm(string name)
        {
            InitializeComponent();
            this.BookName = name;
            setGUI(name);
            this.BackColor = MetroFramework.MetroColors.Lime;
        }
        private void setGUI(string tenSach)
        {

            try
            {
                QLTS_BI_BLL bll = new QLTS_BI_BLL();
                DataTable dataSach = bll.getInfoBook(tenSach);
                txtTenSach.Text = dataSach.Rows[0]["TenSach"].ToString();
                txtTacGia.Text = dataSach.Rows[0]["TacGia"].ToString();
                txtGiaBan.Text = dataSach.Rows[0]["GiaBan"].ToString();
                txtTheLoai.Text = string.Join(", ", dataSach.Rows[0]["TheLoai"]);
                txtSoLuong.Text = dataSach.Rows[0]["SL"].ToString();
                
            }
            catch
            {
                KryptonMessageBox.Show("Error!!!", MessageBoxIcon.Error.ToString());
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
