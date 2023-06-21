using ComponentFactory.Krypton.Toolkit;
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
    public partial class StaffManager : KryptonForm
    {
        public StaffManager()
        {
            InitializeComponent();
            LoadInitDGV();
            SetCBBSort();
        }

        private void SetUIForDGV()
        {
            dgv_nhanvien.Columns[0].Visible = false;
            dgv_nhanvien.Columns[1].HeaderText = "Tài khoản";
            dgv_nhanvien.Columns[2].HeaderText = "Tên nhân viên";
            dgv_nhanvien.Columns[3].HeaderText = "Lương";
            dgv_nhanvien.Columns[4].HeaderText = "SĐT";
            dgv_nhanvien.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void LoadInitDGV()
        {
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            dgv_nhanvien.DataSource = staffManagerBLL.GetAllStaffs();
            SetUIForDGV();
        }

        private void LoadDGV()
        {
            string searchTxt = txtBox_search.Text;
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            dgv_nhanvien.DataSource = staffManagerBLL.GetSearchStaffs(searchTxt);
            SetUIForDGV();
        }

        private void SetCBBSort()
        {
            cbb_sort.Items.AddRange(new CBBItem[]
            {
                new CBBItem { Value = 0, Text = "Tài khoản" },
                new CBBItem { Value = 1, Text = "Tên nhân viên" },
                new CBBItem { Value = 2, Text = "Lương" },
            });
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (checkBox_showInactiveStaff.Checked == false)
            {
                LoadDGV();
            }
            else
            {
                StaffManagerBLL bll = new StaffManagerBLL();
                dgv_nhanvien.DataSource = bll.GetSearchInactiveStaff(txtBox_search.Text);
            }
        }

        private void btn_sort_Click(object sender, EventArgs e)
        {
            if (cbb_sort.SelectedIndex >= 0)
            {
                StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
                List<int> staffIDs = new List<int>();
                foreach (DataGridViewRow dr in dgv_nhanvien.Rows)
                {
                    staffIDs.Add(Convert.ToInt32(dr.Cells[0].Value.ToString()));
                }
                bool IsActive = false;
                if (checkBox_showInactiveStaff.Checked == false) IsActive = true;
                dgv_nhanvien.DataSource = staffManagerBLL.SortStaff(staffIDs, ((CBBItem)cbb_sort.SelectedItem).Value, IsActive);
            }
        }

        private void checkBox_showInactiveStaff_CheckedChanged(object sender, EventArgs e)
        {
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            if (checkBox_showInactiveStaff.Checked == true)
            {
                dgv_nhanvien.DataSource = staffManagerBLL.GetAllInactiveStaff();
                btn_chinhsua.Visible = false;
                btn_xoa.Visible = false;
                btn_them.Visible = false;
            }
            else
            {
                LoadDGV();
                btn_chinhsua.Visible = true;
                btn_xoa.Visible = true;
                btn_them.Visible = true;
            }
        }

        private void btn_them_Click(object sender, EventArgs e)
        {
            StaffInfo staffInfoForm = new StaffInfo(-1, true);
            staffInfoForm.LoadDGV += new StaffInfo.loadDGV(this.LoadDGV);
            staffInfoForm.ShowDialog();
        }

        private void btn_chinhsua_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count == 1)
            {
                StaffInfo staffInfoForm = new StaffInfo(Convert.ToInt32(dgv_nhanvien.SelectedRows[0].Cells[0].Value.ToString()), true);
                staffInfoForm.LoadDGV += new StaffInfo.loadDGV(this.LoadDGV);
                staffInfoForm.ShowDialog();
            }
        }

        private void btn_xoa_Click(object sender, EventArgs e)
        {
            if (dgv_nhanvien.SelectedRows.Count > 0)
            {
                StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
                List<int> inactiveIDs = new List<int>();
                foreach (DataGridViewRow dr in dgv_nhanvien.SelectedRows)
                {
                    inactiveIDs.Add(Convert.ToInt32(dr.Cells[0].Value.ToString()));
                }
                List<string> HaveShiftStaffNames = staffManagerBLL.CheckIfHaveShift(inactiveIDs);
                int count = HaveShiftStaffNames.Count;
                if (count > 0)
                {
                    string name = "";
                    for (int i = 0; i < (count <= 4 ? count : 4); i++)
                    {
                        name += $" {HaveShiftStaffNames[i]}";
                        name += ",";
                        if (count > 4) name += $" +{count - 4}";
                    }
                    DialogResult dialogResult = KryptonMessageBox.Show("Nhân viên: " + name + " có ca làm việc trong những ngày tới" + "\nBạn chắc chắn muốn xóa?", "Cảnh báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        staffManagerBLL.InactiveStaffs(inactiveIDs);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
                else
                {
                    DialogResult dialogResult = KryptonMessageBox.Show("Bạn chắn chắn muốn xóa chứ?", "Cảnh báo", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        staffManagerBLL.InactiveStaffs(inactiveIDs);
                    }
                    else if (dialogResult == DialogResult.No)
                    {
                        return;
                    }
                }
            }
            LoadDGV();
        }
    }
}
