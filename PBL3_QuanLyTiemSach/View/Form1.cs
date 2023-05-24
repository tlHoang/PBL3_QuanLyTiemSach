﻿using System;
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
using PBL3_QuanLyTiemSach.View.StaffManager;

namespace PBL3_QuanLyTiemSach
{
    public partial class Form1 : System.Windows.Forms.Form
    {
        public int MaNV { get; set; }
        public Form1(int MaNV)
        {
            this.MaNV = MaNV;
            InitializeComponent();
            SetUI();
        }
        private System.Windows.Forms.Form currentForm;
        private void SetUI()
        {
            panel_Side.Hide();
            setRole();
            if (MaNV == 1)
            {
                button_BanHang.Text = "Xem Đơn Hàng";
                button_NhapHang.Text = "Button B";
                button_Home.Text = "Nhân viên";
            }
        }
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
            if (MaNV == 1)
            {
                labelName.Text = "ADMIN";
            }
            else
            {
                TaiKhoanBLL bll = new TaiKhoanBLL();
                string[] fullName = bll.getNameFromMaNV(this.MaNV).Split(' ');
                labelName.Text = fullName[fullName.Length - 2] + " " + fullName[fullName.Length - 1];
            }
        }
        public void setRole()
        {
            //if (role != "admin")
            if (MaNV != 1)
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
            if (MaNV == 1)
            {
                OpenForm(new StaffManager());
            }
            else
            {
                OpenForm(new Form2());
            }
        }

        private void button_BanHang_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_BanHang.Top;
            panel_Side.Height = button_BanHang.Height;
            panel_Side.Show();
            if (MaNV != 1)
            {
                //OpenForm(new Sell(this));
            }
            else
            {
                //OpenForm(new Form5());
            }
        }

        private void button_NhapHang_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_NhapHang.Top;
            panel_Side.Height = button_NhapHang.Height;
            panel_Side.Show();
            if (MaNV != 1)
            {
                //OpenForm(new Import(this));
            }
            else
            {
                
            }
        }

        private void button_ThongKe_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_ThongKe.Top;
            panel_Side.Height = button_ThongKe.Height;
            panel_Side.Show();
            
        }

        private void pictureBox_Click(object sender, EventArgs e)
        {
            if (MaNV != 1)
            {
                panel_Side.Hide();
                OpenForm(new StaffInfo(MaNV, false, this));
            }
        }

        private void button_Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_Hide_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnThongTinSach_Click(object sender, EventArgs e)
        {
            panel_Side.Top = btnThongTinSach.Top;
            panel_Side.Height = btnThongTinSach.Height;
            panel_Side.Show();
            //OpenForm(new BookInfo(this));

        }

        private void btnCaLam_Click(object sender, EventArgs e)
        {
            panel_Side.Top = btnCaLam.Top;
            panel_Side.Height = btnCaLam.Height;
            panel_Side.Show();
            //OpenForm(new ShiftManage(this,MaNV));
        }

        private void button_HoaDon_Click(object sender, EventArgs e)
        {
            panel_Side.Top = button_HoaDon.Top;
            panel_Side.Height = button_HoaDon.Height;
            panel_Side.Show();
            //OpenForm(new Bill(this));
        }
        private Point _mouseLocation;

        private bool _isDragging = false;
        private Point _lastLocation;

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            _isDragging = true;
            _lastLocation = e.Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (_isDragging)
            {
                int dx = e.Location.X - _lastLocation.X;
                int dy = e.Location.Y - _lastLocation.Y;
                Location = new Point(Location.X + dx, Location.Y + dy);
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            _isDragging = false;
        }
    }
}