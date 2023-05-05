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

namespace PBL3_QuanLyTiemSach.View.StaffManager
{
    public partial class StaffManager : MetroFramework.Forms.MetroForm
    {
        public StaffManager()
        {
            InitializeComponent();
            LoadDGV();
            SetCBBSort();
        }

        private void SetUIForDGV()
        {
            metroGrid_nhanvien.Columns[0].HeaderText = "Mã nhân viên";
            metroGrid_nhanvien.Columns[1].HeaderText = "Tài khoản";
            metroGrid_nhanvien.Columns[2].HeaderText = "Tên nhân viên";
            metroGrid_nhanvien.Columns[3].HeaderText = "SĐT";
            metroGrid_nhanvien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadDGV()
        {
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            metroGrid_nhanvien.DataSource = staffManagerBLL.GetAllStaffList()
                .Select(p => new { p.MaNV, p.TaiKhoan.Username, p.TenNV, p.SDT })
                .ToList();
            SetUIForDGV();
        }

        private void metroButton_search_Click(object sender, EventArgs e)
        {
            string searchTxt = metroTextBox_search.Text;
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            metroGrid_nhanvien.DataSource = staffManagerBLL.GetSearchStaffList(searchTxt)
                .Select(p => new { p.MaNV, p.TaiKhoan.Username, p.TenNV, p.SDT })
                .ToList();
            SetUIForDGV();
        }

        private void SetCBBSort()
        {
            List<CBBItem> cbbSort = new List<CBBItem>();
            for (int i = 0; i < metroGrid_nhanvien.ColumnCount - 1; i++)
            {
                cbbSort.Add(new CBBItem
                {
                    Value = i,
                    Text = metroGrid_nhanvien.Columns[i].Name
                });
            }
            metroComboBox_sort.Items.AddRange(cbbSort.ToArray());
        }

        private void metroButton_sort_Click(object sender, EventArgs e)
        {
            if (metroComboBox_sort.SelectedIndex >= 0)
            {
                StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
                List<string> staffID = new List<string>();
                foreach (DataGridViewRow dr in metroGrid_nhanvien.Rows)
                {
                    staffID.Add(dr.Cells[0].Value.ToString());
                }
                metroGrid_nhanvien.DataSource = staffManagerBLL.SortStaff(staffID, ((CBBItem)metroComboBox_sort.SelectedItem).Value)
                    .Select(p => new { p.MaNV, p.TaiKhoan.Username, p.TenNV, p.SDT })
                    .ToList();
            }
        }

        private void metroButton_xoa_Click(object sender, EventArgs e)
        {
            if (metroGrid_nhanvien.SelectedRows.Count > 0)
            {
                StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
                List<string> deleteIDs = new List<string>();
                foreach (DataGridViewRow dr in metroGrid_nhanvien.Rows)
                {
                    deleteIDs.Add(dr.Cells[0].Value.ToString());
                }
                staffManagerBLL.DeleteStaffs(deleteIDs);
            }
        }

        private void metroButton_them_Click(object sender, EventArgs e)
        {
            StaffInfo staffInfoForm = new StaffInfo("", true);
            staffInfoForm.ShowDialog();
        }

        private void metroButton_chinhsua_Click(object sender, EventArgs e)
        {
            if (metroGrid_nhanvien.SelectedRows.Count == 1)
            {
                StaffInfo staffInfoForm = new StaffInfo(metroGrid_nhanvien.SelectedRows[0].Cells[0].Value.ToString(), true);
                staffInfoForm.ShowDialog();
            }
        }
    }
}
