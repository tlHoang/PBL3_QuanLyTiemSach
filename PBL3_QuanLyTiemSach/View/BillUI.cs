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

namespace PBL3_QuanLyTiemSach.View
{
    public partial class BillUI : MetroFramework.Forms.MetroForm
    {
        public BillUI()
        {
            InitializeComponent();
            loadDGV(true);
        }

        private void cbbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbHoaDon.Text == "Hóa đơn nhập")
            {
                loadDGV(true);
            }
            else
            {
                loadDGV(false);
            }
        }
        private void loadDGV(bool LoaiHD)
        {
            BillBLL bll = new BillBLL();
            dgvListHoaDon.DataSource = bll.GetAllHoaDon(LoaiHD);

            if (LoaiHD == true)
            {
                dgvListHoaDon.Columns[3].HeaderText = "Tên DVCC";
            }
            else
            {
                dgvListHoaDon.Columns[3].HeaderText = "Tên KH";
            }

            DataGridViewLinkColumn des = new DataGridViewLinkColumn();
            dgvListHoaDon.Columns.Add(des);
            des.HeaderText = "Chi tiết";
            des.Name = "Column6";
            des.Text = "Show";
            des.UseColumnTextForLinkValue = true;

            
        }
    }
}
