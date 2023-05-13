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
            LoadInitDGV();
            SetCBBSort();
            SetUI();
        }

        private void SetUI()
        {
            //this.ControlBox = false;
            this.Style = MetroFramework.MetroColorStyle.White;
        }

        private void SetUIForDGV()
        {
            dgv_nhanvien.Columns[0].HeaderText = "Mã nhân viên";
            dgv_nhanvien.Columns[1].HeaderText = "Tài khoản";
            dgv_nhanvien.Columns[2].HeaderText = "Tên nhân viên";
            dgv_nhanvien.Columns[3].HeaderText = "Lương";
            dgv_nhanvien.Columns[4].HeaderText = "SĐT";
            dgv_nhanvien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadInitDGV()
        {
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            dgv_nhanvien.DataSource = staffManagerBLL.GetAllStaffList()
                .Select(p => new { p.MaNV, p.TaiKhoan.Username, p.TenNV, p.Luong, p.SDT })
                .ToList();
            SetUIForDGV();
        }

        private void LoadDGV()
        {
            // chua quay lai duoc y nhu cu neu da sort tu truoc
            string searchTxt = metroTextBox_search.Text;
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            dgv_nhanvien.DataSource = staffManagerBLL.GetSearchStaffList(searchTxt)
                .Select(p => new { p.MaNV, p.TaiKhoan.Username, p.TenNV, p.Luong, p.SDT })
                .ToList();
            SetUIForDGV();
        }

        private void metroButton_search_Click(object sender, EventArgs e)
        {
            LoadDGV();
        }

        private void SetCBBSort()
        {
            //List<CBBItem> cbbSort = new List<CBBItem>();
            //for (int i = 0; i < metroGrid_nhanvien.ColumnCount - 1; i++)
            //{
            //    cbbSort.Add(new CBBItem
            //    {
            //        Value = i,
            //        Text = metroGrid_nhanvien.Columns[i].Name
            //    });
            //}
            //metroComboBox_sort.Items.AddRange(cbbSort.ToArray());
            metroComboBox_sort.Items.AddRange(new CBBItem[]
            {
                new CBBItem { Value = 0, Text = "Mã nhân viên" },
                new CBBItem { Value = 1, Text = "Tài khoản" },
                new CBBItem { Value = 2, Text = "Tên nhân viên" },
                new CBBItem { Value = 3, Text = "Lương" }
            });
        }

        private void metroButton_sort_Click(object sender, EventArgs e)
        {
            if (metroComboBox_sort.SelectedIndex >= 0)
            {
                StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
                List<int> staffIDs = new List<int>();
                foreach (DataGridViewRow dr in dgv_nhanvien.Rows)
                {
                    staffIDs.Add(Convert.ToInt32(dr.Cells[0].Value.ToString()));
                }
                dgv_nhanvien.DataSource = staffManagerBLL.SortStaff(staffIDs, ((CBBItem)metroComboBox_sort.SelectedItem).Value)
                    .Select(p => new { p.MaNV, p.TaiKhoan.Username, p.TenNV, p.Luong, p.SDT })
                    .ToList();
            }
        }

        private void metroButton_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
                List<int> deleteIDs = new List<int>();
                foreach (DataGridViewRow dr in dgv_nhanvien.SelectedRows)
                {
                    deleteIDs.Add(Convert.ToInt32(dr.Cells[0].Value.ToString()));
                }
                staffManagerBLL.DeleteStaffs(deleteIDs);
            }
            LoadDGV();
        }

        private void metroButton_them_Click(object sender, EventArgs e)
        {
            StaffInfo staffInfoForm = new StaffInfo(-1, true);
            staffInfoForm.LoadDGV += new StaffInfo.loadDGV(this.LoadDGV);
            staffInfoForm.ShowDialog();
        }

        private void metroButton_chinhsua_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count == 1)
            {
                StaffInfo staffInfoForm = new StaffInfo(Convert.ToInt32(dgv_nhanvien.SelectedRows[0].Cells[0].Value.ToString()), true);
                staffInfoForm.LoadDGV += new StaffInfo.loadDGV(this.LoadDGV);
                staffInfoForm.ShowDialog();
            }
        }
    }
}
