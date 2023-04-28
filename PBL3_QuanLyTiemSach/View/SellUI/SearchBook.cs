using MetroFramework;
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
    public partial class SearchBook : MetroFramework.Forms.MetroForm
    {
        Sell f;
        public delegate void SetBookInfo(string txt);
        public SetBookInfo setBookInfo;
        private string TenSach { get; set; }
        public SearchBook(Sell f1)
        {
            InitializeComponent();
            this.f = f1;
            this.TopMost = true;
            TenSach = string.Empty;
        }
        private void SearchBook_Load(object sender, EventArgs e)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var data = db.Sachs.GroupBy(p => p.TenSach)
                    .Select(p1 => new
                    {
                        TenSach = p1.Key,
                        SLCL = p1.Sum(p => p.SoLuongConLai)
                    })
                    //.Where(p => f.TenSach.All(p2 => p2.TenSach != p.TenSach) && p.SLCL > 0 && p.TenSach.Contains(f.SearchText)).ToList();
                    .ToList();
                var tmp = f.TenSach.Select(p => new
                {
                    TenSach = p.TenSach,
                    SLCL = 1
                }).ToList();
                dgvSearchBook.DataSource = data.Where(p => tmp.All(p1 => p1.TenSach != p.TenSach)).ToList();

                dgvSearchBook.Columns[0].HeaderText = "Tên sách";
                dgvSearchBook.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i <= dgvSearchBook.ColumnCount - 1; i++)
                {
                    int colw = dgvSearchBook.Columns[i].Width;
                    dgvSearchBook.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvSearchBook.Columns[i].Width = colw;
                }
            }
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
                this.TopMost = true;
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