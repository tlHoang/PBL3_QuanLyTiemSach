using MetroFramework;
using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.View.StaffInfoUI;
using PBL3_QuanLyTiemSach.View.StaffManager;
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
    public partial class LoginForm : MetroFramework.Forms.MetroForm
    {
        public LoginForm()
        {
            InitializeComponent();
            SetUI();
        }

        private void SetUI()
        {
            metroTextBox_password.UseSystemPasswordChar = true;
        }

        public bool InvalidInput(string input)
        {
            //string pattern = @"(\s|^$)";
            string pattern = @"(^\s*$)";
            return Regex.IsMatch(input, pattern);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string username = metroTextBox_username.Text;
            string password = metroTextBox_password.Text;
            if (InvalidInput(username) || InvalidInput(password))
            {
                MetroMessageBox.Show(this, "Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }
            TaiKhoanBLL bll = new TaiKhoanBLL();
            int MaNV = bll.CheckPassword(username, password);
            if (MaNV == -1)
            {
                MetroMessageBox.Show(this, "Sai tài khoản hoặc mật khẩu");
            }
            else if (MaNV == 1)
            {
                StaffManager.StaffManager staffMangerForm = new StaffManager.StaffManager();
                staffMangerForm.ShowDialog();
            }
            else
            {
                StaffInfo staffInfoForm = new StaffInfo(MaNV);
                staffInfoForm.Show();
            }
        }

        private void metroLabel_showpass_Click(object sender, EventArgs e)
        {
            if (metroLabel_showpass.Text == "Hiện")
            {
                metroLabel_showpass.Text = "Ẩn";
                metroTextBox_password.UseSystemPasswordChar = false;
            }
            else
            {
                metroLabel_showpass.Text = "Hiện";
                metroTextBox_password.UseSystemPasswordChar = true;
            }
        }
    }
}
