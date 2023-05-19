﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;

namespace PBL3_QuanLyTiemSach.View
{
    public partial class Form5 : KryptonForm
    {
        public Form5()
        {
            InitializeComponent();
        }

        private MetroFramework.Forms.MetroForm currentForm;

        private void OpenForm(MetroFramework.Forms.MetroForm f)
        {
            if (currentForm != null)
            {
                currentForm.Close();
            }
            currentForm = f;
            f.TopLevel = false;
            Panel2.Controls.Add(f);
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            f.BringToFront();
            f.Show();
        }

        private void ThongTinSach_Click(object sender, EventArgs e)
        {
            label_ThongTinSach.ForeColor = Color.FromArgb(255, 70, 80);
            BookImg.Image = MainForm_Resource.book_click;

            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
        }
        private void ThongTinSach_Leave()
        {
            label_ThongTinSach.ForeColor = Color.Black;
            BookImg.Image = MainForm_Resource.book;
        }

        private void BanHang_Click(object sender, EventArgs e)
        {
            label_BanHang.ForeColor = Color.FromArgb(255, 70, 80);
            banhangImg.Image = MainForm_Resource.sell_click;

            ThongTinSach_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
        }
        private void BanHang_Leave()
        {
            label_BanHang.ForeColor = Color.Black;
            banhangImg.Image = MainForm_Resource.sell;
        }

        private void NhapHang_Click(object sender, EventArgs e)
        {
            label_NhapHang.ForeColor = Color.FromArgb(255, 70, 80);
            nhaphangImg.Image = MainForm_Resource.import_click;

            ThongTinSach_Leave();
            BanHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
        }
        private void NhapHang_Leave()
        {
            label_NhapHang.ForeColor = Color.Black;
            nhaphangImg.Image = MainForm_Resource.import;
        }

        private void HoaDon_Click(object sender, EventArgs e)
        {
            label_HoaDon.ForeColor = Color.FromArgb(255, 70, 80);
            hoadonImg.Image = MainForm_Resource.bill_click;
            OpenForm(new Bill());

            ThongTinSach_Leave();
            BanHang_Leave();
            NhapHang_Leave();
            CaLam_Leave();
            ThongKe_Leave();
        }
        private void HoaDon_Leave()
        {
            label_HoaDon.ForeColor = Color.Black;
            hoadonImg.Image = MainForm_Resource.bill;
        }

        private void CaLam_Click(object sender, EventArgs e)
        {
            label_CaLam.ForeColor = Color.FromArgb(255, 70, 80);
            calamImg.Image = MainForm_Resource.calam_click;

            ThongTinSach_Leave();
            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            ThongKe_Leave();
        }
        private void CaLam_Leave()
        {
            label_CaLam.ForeColor = Color.Black;
            calamImg.Image = MainForm_Resource.calam;
        }

        private void ThongKe_Click(object sender, EventArgs e)
        {
            label_ThongKe.ForeColor = Color.FromArgb(255, 70, 80);
            thongkeImg.Image = MainForm_Resource.thongke_click;

            ThongTinSach_Leave();
            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
        }
        private void ThongKe_Leave()
        {
            label_ThongKe.ForeColor = Color.Black;
            thongkeImg.Image = MainForm_Resource.thongke;
        }
    }
}
