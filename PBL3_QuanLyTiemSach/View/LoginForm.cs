using ComponentFactory.Krypton.Toolkit;
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
    public partial class LoginForm : KryptonForm
    {
        public LoginForm()
        {
            InitializeComponent();
            SetUI();
        }
        public int MaNV { get; set; }

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
        {
            string username = txt_username.Text;
            string password = txt_password.Text;
            if (InvalidInput(username) || InvalidInput(password))
            {
                KryptonMessageBox.Show(this, "Tài khoản hoặc mật khẩu không hợp lệ");
                return;
            }
            TaiKhoanBLL bll = new TaiKhoanBLL();
            MaNV = bll.CheckPassword(username, password);
            if (MaNV == -1)
            {
                MessageBox.Show("Sai tài khoản hoặc mật khẩu");
            }
            else if (MaNV == 1)
            {
                //this.Hide();
                //Form5 f = new Form5(1);
                //f.ShowDialog();
                this.Close();
                DialogResult = DialogResult.OK;
            }
            else
            {
                this.Hide();
                Form5 f = new Form5(this.MaNV);
                f.ShowDialog();
                f.setAvatar(bll.getGioiTinh(MaNV));
                this.Close();
                DialogResult = DialogResult.OK;
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
        private void button1_Click(object sender, EventArgs e)
        {
            txt_password.Select();
            if (button1.Image == Login_Resource.show)
            {
                button1.Image = Login_Resource.hide;
                txt_password.UseSystemPasswordChar = true;
            }
            else
            {
                button1.Image = Login_Resource.show;
                txt_password.PasswordChar = '\0';
                txt_password.UseSystemPasswordChar = false;
            }
        }
    }
}
