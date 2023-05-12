using MetroFramework;
using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.DTO.CodeFirst;
using PBL3_QuanLyTiemSach.View.StaffInfoUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View
{
    public partial class StaffInfo : MetroFramework.Forms.MetroForm
    {
        Form f;
        public int StaffID { get; set; }
        public bool IsAdmin { get; set; }

        public delegate void loadDGV();
        public loadDGV LoadDGV { get; set; }

        public StaffInfo(int staffID,  bool isAdmin = false, Form1 f1 = default)
        {
            this.f = f1;

            StaffID = staffID;
            IsAdmin = isAdmin;
            InitializeComponent();

            SetUIAlway();
            if (IsAdmin == false)
            {
                SetUIForStaff();
            }
            else
            {
                SetUIForAdmin();
            }
            if (staffID != -1)
            {
                LoadInfo();
            }

        }

        public void SetUIAlway()
        {
            metroTextBox_ma.Enabled = false;
        }

        private void SetUIForStaff()
        {
            this.ControlBox = false;
            this.Style = MetroFramework.MetroColorStyle.White;

            metroPanel_thongtin.Enabled = false;
            metroTextBox_taikhoan.Enabled = false;
            //metroPanel_taikhoan.Enabled = false;
            metroTextBox_taikhoan.Enabled = false;
            metroButton_thoat.Visible = false;
            metroButton_xacnhan.Visible = false;
            metroButton_resetpass.Visible = false;
        }

        private void SetUIForAdmin()
        {
            metroButton_doimk.Visible = false;
            // add
            if (StaffID == -1)
            {
                metroTextBox_ma.Text = "Mã sẽ tự động tạo";
                metroButton_resetpass.Visible = false;
            }
            // edit
            else
            {
                metroTextBox_taikhoan.Enabled = false;
                metroButton_doimk.Visible = false;
                metroButton_resetpass.Location = new Point(190, 170);
            }
        }

        private void LoadInfo()
        {
            StaffInfoBLL staffInfoBLL = new StaffInfoBLL();
            NhanVien nhanvien = staffInfoBLL.GetStaffInfo(StaffID);
            TaiKhoan taikhoan = staffInfoBLL.GetAccountInfo(StaffID);

            metroTextBox_ma.Text = nhanvien.MaNV.ToString();
            metroTextBox_ten.Text = nhanvien.TenNV;
            if (nhanvien.GioiTinh == true) metroRadioButton_nam.Checked = true;
            else metroRadioButton_nu.Checked = true;
            dateTimePicker_ngaysinh.Value = nhanvien.NgaySinh;
            metroTextBox_diachi.Text = nhanvien.DiaChi;
            metroTextBox_luong.Text = nhanvien.Luong.ToString();
            metroTextBox_sdt.Text = nhanvien.SDT;

            metroTextBox_taikhoan.Text = taikhoan.Username;
        }

        private void metroButton_doimk_Click(object sender, EventArgs e)
        {
            ChangePassword changePassForm = new ChangePassword(metroTextBox_taikhoan.Text);
            changePassForm.ShowDialog();
        }

        private void metroButton_resetpass_Click(object sender, EventArgs e)
        {
            TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
            taiKhoanBLL.UpdatePassword(metroTextBox_taikhoan.Text, "123456");
        }

        // main button
        private void metroButton_thoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void metroButton_xacnhan_Click(object sender, EventArgs e)
        {
            if (!ValidateInfo())
            {
                MetroMessageBox.Show(this, "Cảnh báo", "Dữ liệu không hợp lệ");
                return;
            }
            StaffManagerBLL staffManagerBLL = new StaffManagerBLL();
            if (StaffID == -1)
            {
                TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
                // add
                if (staffManagerBLL.IsUsernameDuplicate(metroTextBox_taikhoan.Text))
                {
                    MetroMessageBox.Show(this, "Tên tài khoản đã tồn tại", "Thông báo");
                }
                else
                {
                    string salt = taiKhoanBLL.RandomString(12);
                    TaiKhoan NewAccount = new TaiKhoan
                    {
                        Username = metroTextBox_taikhoan.Text,
                        Password = taiKhoanBLL.HashPassword("123456", salt),
                        Salt = salt
                    };
                    NhanVien NewStaff = new NhanVien
                    {
                        MaNV = NewAccount.MaNV,
                        TenNV = metroTextBox_ten.Text,
                        GioiTinh = (metroRadioButton_nam.Checked == true ? true : false),
                        NgaySinh = dateTimePicker_ngaysinh.Value,
                        DiaChi = metroTextBox_diachi.Text,
                        Luong = Convert.ToDouble(metroTextBox_luong.Text),
                        SDT = metroTextBox_sdt.Text,
                    };
                    staffManagerBLL.AddNewStaff(NewAccount, NewStaff);
                    this.Dispose();
                }
            }
            else
            {
                NhanVien UpdatedStaff = new NhanVien
                {
                    MaNV = Convert.ToInt32(metroTextBox_ma.Text),
                    TenNV = metroTextBox_ten.Text,
                    GioiTinh = (metroRadioButton_nam.Checked == true ? true : false),
                    NgaySinh = dateTimePicker_ngaysinh.Value,
                    DiaChi = metroTextBox_diachi.Text,
                    Luong = Convert.ToDouble(metroTextBox_luong.Text),
                    SDT = metroTextBox_sdt.Text,
                };
                staffManagerBLL.UpdateStaff(UpdatedStaff);
                this.Dispose();
            }
            LoadDGV();
        }

        private bool ValidateInfo()
        {
            // ten
            if (Regex.IsMatch(metroTextBox_ten.Text, @"(^\s*$|\d)"))
                return false;
            //gioi tinh
            if (metroRadioButton_nam.Checked == false && metroRadioButton_nu.Checked == false)
                return false;
            //dia chi
            if (Regex.IsMatch(metroTextBox_diachi.Text, @"^\s*$"))
                return false;
            //luong
            if (Regex.IsMatch(metroTextBox_luong.Text, @"^\s*$|\D"))
                return false;
            //sdt
            if (!Regex.IsMatch(metroTextBox_sdt.Text, @"^\d{10}$"))
                return false;
            return true;
        }
    }
}
