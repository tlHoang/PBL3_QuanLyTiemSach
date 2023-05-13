using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.View.BillUI;
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
    public partial class Bill : MetroFramework.Forms.MetroForm
    {
        public Bill()
        {
            InitializeComponent();

            cbbHoaDon.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSort.DropDownStyle = ComboBoxStyle.DropDownList;
            cbbSort.Enabled = false;
            metroDateTime1.MaxDate = DateTime.Now;

            DataGridViewLinkColumn des = new DataGridViewLinkColumn();
            dgvListHoaDon.Columns.Add(des);
            des.HeaderText = "Chi tiết";
            des.Name = "Column6";
            des.Text = "Show";
            des.UseColumnTextForLinkValue = true;

            dgvListHoaDon.Columns[0].Visible = false;
            SortColIndex = -1;
        }
        private bool LoaiHD { get; set; }
        private int SortColIndex { get; set; }

        private void setNameColumnDGV()
        {
            if (LoaiHD == true)
            {
                dgvListHoaDon.Columns["TenKH_DVCC"].HeaderText = "Tên DVCC";
            }
            else
            {
                dgvListHoaDon.Columns["TenKH_DVCC"].HeaderText = "Tên KH";
            }
            dgvListHoaDon.Columns["ID"].HeaderText = "Mã HĐ";
            dgvListHoaDon.Columns["Date"].HeaderText = "Ngày lập";
            dgvListHoaDon.Columns["StaffName"].HeaderText = "Nhân viên lập";
            dgvListHoaDon.Columns["Total"].HeaderText = "Tổng tiền";
        }
        private void loadDGV(bool LoaiHD, string SearchText, int index)
        {
            BillBLL bll = new BillBLL();
            if (index == -1)
            {
                dgvListHoaDon.DataSource = bll.GetAllHoaDon(LoaiHD).Where(p => p.Date.ToString().Contains(SearchText)).ToList();
            }
            else
            {
                dgvListHoaDon.DataSource = bll.GetAllHoaDonSortBy(LoaiHD, index).Where(p => p.Date.ToString().Contains(SearchText)).ToList();
            }
            setNameColumnDGV();
            dgvListHoaDon.Columns[0].Visible = true;
            dgvListHoaDon.Columns[0].DisplayIndex = dgvListHoaDon.Columns.Count - 1;
        }
        private void metroButton1_Click(object sender, EventArgs e)
        {
            loadDGV(LoaiHD, "", -1);
        }
        private void metroButton2_Click(object sender, EventArgs e)
        {
            loadDGV(LoaiHD, metroDateTime1.Value.ToString("d/M/yyyy"), SortColIndex);
        }

        private void cbbHoaDon_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbbSort.SelectedItem = null;
            SortColIndex = -1;
            cbbSort.Enabled = true;

            if (cbbHoaDon.Text == "Hóa đơn nhập")
            {
                LoaiHD = true;
                loadDGV(true, "", SortColIndex);
                cbbSort.Items[cbbSort.Items.Count - 2] = "Tên DVCC";
            }
            else
            {
                LoaiHD = false;
                loadDGV(false, "", SortColIndex);
                cbbSort.Items[cbbSort.Items.Count - 2] = "Tên Khách Hàng";
            }
        }

        private void cbbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            SortColIndex = cbbSort.SelectedIndex;
        }

        private void metroButton1_Click_1(object sender, EventArgs e)
        {
            loadDGV(LoaiHD, "", SortColIndex);
        }

        private void dgvListHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvListHoaDon.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0)
            {
                List<string> li = new List<string>();
                li.Add(LoaiHD.ToString());
                for (int i = 1; i < 6; i++)
                {
                    if (i != 2)
                    {
                        li.Add(dgvListHoaDon.Rows[e.RowIndex].Cells[i].Value.ToString());
                    }
                    else
                    {
                        string[] fullDate = dgvListHoaDon.Rows[e.RowIndex].Cells[i].Value.ToString().Split(' ');
                        li.Add(fullDate[0]);
                    }
                }

                Bill_Info f = new Bill_Info(li);
                f.Show();
            }
        }
    }
}
