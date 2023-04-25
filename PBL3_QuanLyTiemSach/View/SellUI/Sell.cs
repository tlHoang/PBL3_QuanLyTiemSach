using MetroFramework.Controls;
using PBL3_QuanLyTiemSach.View.SellUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach
{
    public partial class Sell : MetroFramework.Forms.MetroForm
    {
        public Sell()
        {
            InitializeComponent();
            this.ControlBox = false;
            this.Style = MetroFramework.MetroColorStyle.White;
            txtSearch.Text = "Tìm kiếm";
        }

        private void txtSearch_Enter(object sender, EventArgs e)
        {
            if(txtSearch.Text == "Tìm kiếm")
            {
                txtSearch.Text = "";
                txtSearch.ForeColor = Color.Black;
            }
        }

        private void txtSearch_Leave(object sender, EventArgs e)
        {
            if(txtSearch.Text == "")
            {
                txtSearch.Text = "Tìm kiếm";
                txtSearch.ForeColor =Color.Silver;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchBook f = new SearchBook();
            f.ShowDialog();
        }
    }
}
