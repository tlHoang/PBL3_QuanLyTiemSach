using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View.StatisticUI
{
    public partial class ChangePrice : Form
    {
        public double newPrice { get; set; }

        public ChangePrice()
        {
            InitializeComponent();
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            this.newPrice = Convert.ToDouble(textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
