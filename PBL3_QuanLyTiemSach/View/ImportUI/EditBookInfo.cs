using PBL3_QuanLyTiemSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View.ImportUI
{
    public partial class EditBookInfo : MetroFramework.Forms.MetroForm
    {
        Import f;

        public delegate void EditDGV(List<string> ls, int index);
        public EditDGV editDGV { get; set; }
        public int index { get; set; }
        public EditBookInfo(Import f1, int rowIndex, string TenSach, string TacGia, string TheLoai, string SoLuong, string GiaNhap)
        {
            InitializeComponent();
            this.f = f1;
            loadCBBTheLoai();
            this.index = rowIndex;
            txtTenSach.Text = TenSach;
            txtTacGia.Text = TacGia;
            cbbTheLoai.Text = TheLoai;
            txtSoLuong.Text = SoLuong;
            txtGiaNhap.Text = GiaNhap;
        }
        private void loadCBBTheLoai()
        {
            GetBookInfoBLL bll = new GetBookInfoBLL();
            cbbTheLoai.Items.AddRange(bll.getAllTenTheLoai().ToArray());
        }
        private bool checkNull()
        {
            if (txtTacGia.Text == "" || txtTenSach.Text == "" || txtGiaNhap.Text == "" || txtSoLuong.Text == "" || cbbTheLoai.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (checkNull() == true)
            {
                DialogResult dr = MetroFramework.MetroMessageBox.Show(this, "\nLưu thay đổi?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, 140);
                if (dr == DialogResult.Yes)
                {
                    List<string> ls = new List<string>() { txtTenSach.Text, txtGiaNhap.Text, txtSoLuong.Text, txtTacGia.Text, cbbTheLoai.Text };
                    editDGV(ls, index);
                    this.Close();
                }
            }
        }
    }
}
