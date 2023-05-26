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
    public partial class BookInfo : KryptonForm
    {
        Form1 f;
        public BookInfo()
        //public BookInfo(Form1 f1)
        {
            InitializeComponent();
            //this.f = f1;
            setBookInfoDgv();
            GUI();
        }
        private void setBookInfoDgv()
        {
            QLTS_BI_BLL bll = new QLTS_BI_BLL();
            dgvBookInfo.DataSource = bll.getDataBaseListBook();
            dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvBookInfo.Columns["TenSach"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBookInfo.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBookInfo.Columns["SoLuong"].HeaderText = "Số Lượng";
            
        }
        public void GUI()
        {
            QLTS_BI_BLL bll = new QLTS_BI_BLL();
            cbbTheLoai.Items.AddRange(bll.getAllTheLoai().ToArray());
        }
        private void btnXem_Click(object sender, EventArgs e)
        {
            if (dgvBookInfo.SelectedRows.Count == 1)
            {

                DataGridViewRow selectedRow = dgvBookInfo.CurrentRow;
                
                if (selectedRow != null)
                {   
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
                    KryptonMessageBox.Show("Danh Sách rỗng !!! ", MessageBoxIcon.Information.ToString());
                }
            }
            else
            {
                KryptonMessageBox.Show("Chọn một hàng !!! ", MessageBoxIcon.Information.ToString());
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string txtTenSach = txtBookInfoTenSach.Text;
            string txtTacGia = txtBookInfoTacGia.Text;
            string txtTheLoai = cbbTheLoai.Text;
            QLTS_BI_BLL bll = new QLTS_BI_BLL();
            dgvBookInfo.DataSource = bll.getDataFindListBook(txtTenSach, txtTacGia, txtTheLoai);

            dgvBookInfo.Columns["TenSach"].HeaderText = "Tên Sách";
            dgvBookInfo.Columns["TenSach"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvBookInfo.Columns["TenSach"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvBookInfo.Columns["TacGia"].HeaderText = "Tác Giả";
            dgvBookInfo.Columns["TheLoai"].HeaderText = "Thể Loại";
            dgvBookInfo.Columns["SL"].HeaderText = "Số Lượng";
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
} 
   
