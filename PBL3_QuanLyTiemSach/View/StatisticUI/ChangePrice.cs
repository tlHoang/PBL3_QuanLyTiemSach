using ComponentFactory.Krypton.Toolkit;
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
    public partial class ChangePrice : KryptonForm
    {
        Statistic F;
        public double NewPrice { get; set; }

        public ChangePrice(Statistic f)
        {
            InitializeComponent();
            this.F = f;
        }

        private void btn_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_xacnhan_Click(object sender, EventArgs e)
        {
            this.NewPrice = Convert.ToDouble(textBox1.Text);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
