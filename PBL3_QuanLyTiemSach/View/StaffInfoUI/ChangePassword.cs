using ComponentFactory.Krypton.Toolkit;
using MetroFramework;
using PBL3_QuanLyTiemSach.BLL;
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

namespace PBL3_QuanLyTiemSach.View.StaffInfoUI
{
    public partial class ChangePassword : KryptonForm
    {
        public string Username { get; set; }

        public ChangePassword(string username)
        {
            Username = username;
            InitializeComponent();
            SetUI();
        }

        private void SetUI()
        {
            metroLabel_noti1.Text = "";
            metroLabel_noti2.Text = "";
            metroTextBox_mkcu.UseSystemPasswordChar = true;
            metroTextBox_matkhau.UseSystemPasswordChar = true;
            metroTextBox_nhaplaimk.UseSystemPasswordChar = true;
        }

        private bool ValidateNewPassword(string newPassword)
        {
            string pattern = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z]).*$";
            return Regex.IsMatch(newPassword, pattern);
        }

        private void metroButton_pass_xacnhan_Click(object sender, EventArgs e)
        {
            if (!ValidateNewPassword(metroTextBox_matkhau.Text))
            {
                MetroMessageBox.Show(this, "Mật khẩu không đúng chuẩn", "Thông báo");
                return;
            }
            if (metroTextBox_matkhau.Text != metroTextBox_nhaplaimk.Text)
            {
                MetroMessageBox.Show(this, "Mật khẩu nhập lại không khớp", "Thông báo");
                return;
            }
            TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();
            if (taiKhoanBLL.CheckUsernameAndPassword(Username, metroTextBox_mkcu.Text) != -1 || true)
            {
                MetroMessageBox.Show(this, "Đổi mật khẩu thành công", "Thông báo");
                taiKhoanBLL.UpdatePassword(Username, metroTextBox_matkhau.Text);
                this.Dispose();
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

        private void metroButton_pass_huy_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
