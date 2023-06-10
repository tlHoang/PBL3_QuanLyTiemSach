using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComponentFactory.Krypton.Toolkit;
using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.View.StatisticUI;

namespace PBL3_QuanLyTiemSach.View
{
    public partial class Form5 : KryptonForm
    {
        public Form5(int MaNV)
        {
            InitializeComponent();
            this.MaNV = MaNV;
            setName(this.MaNV);
            setUI(this.MaNV);
        }
        public int MaNV { get; set; }
        private void setUI(int MaNV)
        {
            if (MaNV != 1)
            {
                Panel9.Hide();
                Panel11.Hide();
            }
            else
            {
                Panel5.Hide();
                Panel6.Hide();
                Panel7.Location = new Point(Panel7.Location.X, Panel7.Location.Y - 100);
                Panel8.Location = new Point(Panel8.Location.X, Panel8.Location.Y - 100);
                Panel9.Location = new Point(Panel9.Location.X, Panel9.Location.Y - 100);
                Panel11.Location = new Point(Panel11.Location.X, Panel11.Location.Y - 100);
            }
        }

        private Form currentForm;
        private void OpenForm(Form f)
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
        public void setAvatar(bool GioiTinh)
        {
            if (GioiTinh == false)
            {
                avatarImg.Image = MainForm_Resource.female;
            }
        }
        public void setName(int MaNV)
        {
            if (MaNV != 1)
            {
                TaiKhoanBLL bll = new TaiKhoanBLL();
                string[] fullName = bll.getNameFromMaNV(this.MaNV).Split(' ');
                labelName.Text = fullName[fullName.Length - 2] + " " + fullName[fullName.Length - 1];
            }
            else
            {
                labelName.Text = " ADMIN";
            }
        }

        private void ThongTinSach_Click(object sender, EventArgs e)
        {
            label_ThongTinSach.ForeColor = Color.FromArgb(255, 70, 80);
            BookImg.Image = MainForm_Resource.book_click;

            OpenForm(new BookInfo());

            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
            NhanVien_Leave();
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

            OpenForm(new Sell(this));

            ThongTinSach_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
            NhanVien_Leave();
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

            OpenForm(new Import(this));

            ThongTinSach_Leave();
            BanHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
            NhanVien_Leave();
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
            NhanVien_Leave();
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

            OpenForm(new ShiftManage(this, MaNV));

            ThongTinSach_Leave();
            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            ThongKe_Leave();
            NhanVien_Leave();
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

            OpenForm(new Statistic());

            ThongTinSach_Leave();
            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            NhanVien_Leave();
        }
        private void ThongKe_Leave()
        {
            label_ThongKe.ForeColor = Color.Black;
            thongkeImg.Image = MainForm_Resource.thongke;
        }

        private void NhanVien_Click(object sender, EventArgs e)
        {
            label_NV.ForeColor = Color.FromArgb(255, 70, 80);
            nhanvienImg.Image = MainForm_Resource.nhanvien_click;

            OpenForm(new StaffManager.StaffManager());

            ThongTinSach_Leave();
            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
        }
        private void NhanVien_Leave()
        {
            label_NV.ForeColor = Color.Black;
            nhanvienImg.Image = MainForm_Resource.nhanvien;
        }

        private void DangXuat_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm f = new LoginForm();
            f.ShowDialog();
            this.Dispose();
        }

        private void avatarImg_Click(object sender, EventArgs e)
        {
            OpenForm(new StaffInfo(MaNV));

            ThongTinSach_Leave();
            BanHang_Leave();
            NhapHang_Leave();
            HoaDon_Leave();
            CaLam_Leave();
            ThongKe_Leave();
            NhanVien_Leave();
        }
    }
}
