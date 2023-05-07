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
    public partial class SearchBookTitle : MetroFramework.Forms.MetroForm
    {
        Import f;
        public delegate void SetBookTitle(string title);
        public SetBookTitle setBookTitle;
        public SearchBookTitle(Import f1)
        {
            InitializeComponent();
            LoadBookTitleDGV();
            this.f = f1;
            this.TopMost = true;
        }
        private void LoadBookTitleDGV()
        {
            GetBookInfoBLL getBookInfoBLL = new GetBookInfoBLL();
            dgvTenSach.DataSource = getBookInfoBLL.getAllBookTitle()
                .Select(p => new { TenSach = p }).ToList();
            dgvTenSach.Columns[0].HeaderText = "Tên sách";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if (dgvTenSach.SelectedRows.Count > 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "\nChỉ được chọn 1 sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
                this.TopMost = true;
            }
            else
            {
                string TenSach = dgvTenSach.SelectedRows[0].Cells[0].Value.ToString();
                setBookTitle(TenSach);
                this.Close();
            }
        }
    }
}
