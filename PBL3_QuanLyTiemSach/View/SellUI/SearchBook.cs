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
        public SearchBook()
        {
            InitializeComponent();
        }
        private void SearchBook_Load(object sender, EventArgs e)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var data = db.Khos.GroupBy(p => p.TenSach)
                    .Select(p1 => new
                    {
                        TenSach = p1.Key,
                        SLCL = p1.Sum(p => p.SoLuongSachConLai)
                    }).Where(p => p.SLCL > 0).ToList();

                dgvSearchBook.DataSource = data;

                dgvSearchBook.Columns[0].HeaderText = "Tên sách";
                dgvSearchBook.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
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
                //DialogResult dr = MetroFramework.MetroMessageBox.Show(this,"\nChỉ được chọn 1 sách!","Thông báo",150);
                //if (dr == DialogResult.OK)
                //{

                //}
                MessageBox.Show(this, "\nChỉ được chọn 1 sách!", "Thông báo");
            }

        }
    }
}