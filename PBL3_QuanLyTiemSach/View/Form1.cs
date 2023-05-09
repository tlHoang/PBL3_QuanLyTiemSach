using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.View;

namespace PBL3_QuanLyTiemSach
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public Form1()
        {
            InitializeComponent();
            panel_Side.Hide();
        }
        public int MaNV { get; set; }
        private System.Windows.Forms.Form currentForm; 
        private void OpenForm(System.Windows.Forms.Form f)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = f;
            f.TopLevel = false;
            panel_Body.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            TaiKhoanBLL bll = new TaiKhoanBLL();
            string[] fullName = bll.getNameFromMaNV(this.MaNV).Split(' ');
            labelName.Text = fullName[fullName.Length - 2] + " " + fullName[fullName.Length - 1];
        }
        public void setRole(string role)
        {
            if (role != "admin")
            {
                labelRole.Text = "Nhân viên";
            }
            else
            {
                labelRole.Text = "Admin";
            }
        }
        private void button_Home_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_Home.Top;
            panel_Side.Height = button_Home.Height;
            panel_Side.Show();
            OpenForm(new Form2());
        }

        private void button_BanHang_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_BanHang.Top;
            panel_Side.Height = button_BanHang.Height;
            panel_Side.Show();
            OpenForm(new Sell(this));
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_NhapHang.Top;
            panel_Side.Height = button_NhapHang.Height;
            panel_Side.Show();
            OpenForm(new Import(this));
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_ThongKe.Top;
            panel_Side.Height = button_ThongKe.Height;
            panel_Side.Show();
            OpenForm(new Form5());
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
