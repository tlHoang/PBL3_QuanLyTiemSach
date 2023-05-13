using MetroFramework;
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

namespace PBL3_QuanLyTiemSach.View.SellUI
{
    public partial class SearchBookInfo : MetroFramework.Forms.MetroForm
    {
        Sell f;
        public delegate void SetBookInfo(string txt);
        public SetBookInfo setBookInfo;
        private string TenSach { get; set; }
        public SearchBookInfo(Sell f1)
        {
            InitializeComponent();
            this.f = f1;
            TenSach = string.Empty;
        }
        private void SearchBook_Load(object sender, EventArgs e)
        {
            SellBLL bll = new SellBLL();
            dgvSearchBook.DataSource = bll.setDGVSBI(f.TenSach, f.SearchText);
            dgvSearchBook.Columns[0].HeaderText = "Tên sách";
            dgvSearchBook.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            if(dgvSearchBook.SelectedRows.Count > 1)
            {
                MetroFramework.MetroMessageBox.Show(this, "\nChỉ được chọn 1 sách!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning, 140);
            }
            else
            {
                TenSach = dgvSearchBook.SelectedRows[0].Cells[0].Value.ToString();
                setBookInfo(TenSach);
                this.Close();
            }
        }
    }
}