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

namespace PBL3_QuanLyTiemSach.View
{
    public partial class LoginForm : System.Windows.Forms.Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        public bool InvalidInput(string input)
        {
            string pattern = @"(\s|^$)";
            return Regex.IsMatch(input, pattern);
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            string username = metroTextBox_username.Text;
            string password = metroTextBox_password.Text;
            if (InvalidInput(username) || InvalidInput(password))
            {
                MessageBox.Show("Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }
            TaiKhoanBLL bll = new TaiKhoanBLL();
            string MaNV = bll.CheckPassword(username, password);
            if (MaNV == null)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            else
            {
                MessageBox.Show("thang cong");
                // call form and pass MaNV
            }
        }
    }
}
