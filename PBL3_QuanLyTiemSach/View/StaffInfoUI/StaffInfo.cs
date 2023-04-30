using MetroFramework;
using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.DTO.CodeFirst;
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
        public string MaNhanVien { get; set; }

        public StaffInfo(string maNhanVien)
        {
            MaNhanVien = maNhanVien;
            InitializeComponent();
            SetUI();
            LoadInfo();
        }

        public void SetUI()
        {
            this.ControlBox = false;
            this.Style = MetroFramework.MetroColorStyle.White;

            metroPanel_pass.Visible = false;
            metroTextBox_mkcu.UseSystemPasswordChar = true;
            metroTextBox_matkhau.UseSystemPasswordChar = true;
            metroTextBox_nhaplaimk.UseSystemPasswordChar = true;
            metroLabel_noti1.Text = "";
            metroLabel_noti2.Text = "";
            if (true/*la nhan vien*/)
            {
                metroPanel_thongtin.Enabled = false;
                metroTextBox_taikhoan.Enabled = false;
                metroPanel_taikhoan.Enabled = false;
            }
        }

        public void LoadInfo()
        {
            StaffInfoBLL staffInfoBLL = new StaffInfoBLL();
            NhanVien nhanvien = staffInfoBLL.GetNhanVienInfo(MaNhanVien);
            TaiKhoan taikhoan = staffInfoBLL.GetTaiKhoanInfo(MaNhanVien);

            metroTextBox_ma.Text = nhanvien.MaNV;
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
            if (true/*la nhan vien*/)
            {
                metroPanel_pass.Visible = true;
                metroPanel_taikhoan.Enabled = true;
                metroButton_doimk.Visible = false;
            }
        }

        private void SetUIAfterChangePassword()
        {
            metroTextBox_mkcu.Text = "";
            metroTextBox_matkhau.Text = "";
            metroTextBox_nhaplaimk.Text = "";
            metroPanel_pass.Visible = false;
            metroButton_doimk.Visible = true;
        }

        private bool ValidateNewPassword(string newPassword)
        {
            // 1 Chu hoa, 1 so
            string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$";
            return Regex.IsMatch(newPassword, pattern);
        }

        private void metroButton_pass_huy_Click(object sender, EventArgs e)
        {
            SetUIAfterChangePassword();
        }

        private void metroButton_pass_xacnhan_Click(object sender, EventArgs e)
        {
            if (!ValidateNewPassword(metroTextBox_matkhau.Text)) return;
            if (metroTextBox_matkhau.Text != metroTextBox_nhaplaimk.Text) return;
            TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
            if (taiKhoanBLL.CheckPassword(metroTextBox_taikhoan.Text, metroTextBox_mkcu.Text) != null)
            {
                MetroMessageBox.Show(this, "Đổi mật khẩu thành công", "Thông báo");
                taiKhoanBLL.UpdatePassword(metroTextBox_taikhoan.Text, metroTextBox_matkhau.Text);
                SetUIAfterChangePassword();
            }
            else
            {
                MetroMessageBox.Show(this, "Sai mật khẩu", "Thông báo");
            }
        }

        private void metroTextBox_matkhau_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateNewPassword(metroTextBox_matkhau.Text))
            {
                metroLabel_noti1.Text = "Mật khẩu phải có 1 chữ thường, 1 chữ hoa, 1 số và tối thiểu 8 kí tự";
            }
            else
            {
                metroLabel_noti1.Text = "";
            }
        }

        private void metroTextBox_nhaplaimk_TextChanged(object sender, EventArgs e)
        {
            if (metroTextBox_matkhau.Text != metroTextBox_nhaplaimk.Text)
            {
                metroLabel_noti2.Text = "Mật khẩu nhập lại không khớp";
            }
            else
            {
                metroLabel_noti2.Text = "";
            }
        }
    }
}
