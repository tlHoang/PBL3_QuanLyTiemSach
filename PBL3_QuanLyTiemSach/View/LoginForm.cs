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
            txt_password.UseSystemPasswordChar = true;
        }

        public bool InvalidInput(string input)
        {
            //string pattern = @"(\s|^$)";
            string pattern = @"^\s*$";
            return Regex.IsMatch(input, pattern);
        }

        private void metroButton1_Click(object sender, EventArgs e)
<<<<<<< HEAD
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
=======
        {/*
            string username = metroTextBox_username.Text;
            string password = metroTextBox_password.Text;
>>>>>>> f8dbdf17b1a80f3d1a33580fd97fa0514f1ac40d
            if (InvalidInput(username) || InvalidInput(password))
            {
                MetroMessageBox.Show(this, "Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }
            TaiKhoanBLL bll = new TaiKhoanBLL();
            int MaNV = bll.CheckPassword(username, password);
            if (MaNV == -1)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            else
            {
<<<<<<< HEAD
                //MessageBox.Show("thanh cong");
                // call form and pass MaNV
                this.Hide();
                Form1 f = new Form1();
                f.MaNV = MaNV;
                f.setRole(txt_username.Text);
                f.ShowDialog();
                this.Close();
            }
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnDangNhap.PerformClick();
            }
        }

        Image show = Login_Resource.show;
        Image hide = Login_Resource.hide;

        private void button1_Click(object sender, EventArgs e)
        {
            txt_password.Select();
            if (button1.Image == show)
            {
                button1.Image = hide;
                //txt_password.PasswordChar = '*';
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                button1.Image = show;
                txt_password.PasswordChar = '\0';
            }
=======
                MessageBox.Show("thang cong");
                // call form and pass MaNV*/
            //}
>>>>>>> f8dbdf17b1a80f3d1a33580fd97fa0514f1ac40d
        }
    }
}
