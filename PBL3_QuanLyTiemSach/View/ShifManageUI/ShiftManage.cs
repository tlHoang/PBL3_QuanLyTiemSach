using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.View.ShifManageUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View
{

    public partial class ShiftManage : MetroFramework.Forms.MetroForm
    {
        int IDStaff = 2;
        public delegate void updateForm();
        public ShiftManage()
        {
            InitializeComponent();
            setCBBMain();
        }
        private void setGUIButton()
        {
            btnSMDangKiCa.Enabled= false;
            btnXoaCa.Enabled= false;
        }
        private void setCBBLichLam()
        {
            QLTS_BLL bll = new QLTS_BLL();
            dgvShift.DataSource = bll.getCaNhanVien(IDStaff);
            dgvShift.Columns["Tên"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvShift.Columns["Tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void setCBBMain()
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Ca> ca = db.Cas.ToList();
                List<NhanVien> nhanVien = db.NhanViens.ToList();
                List<CaNV> caNV = db.CaNVs.ToList();
                //
                DateTime txtTime = dtSMChonNgay.Value;
                // next version Trong này có ca của ai thì hiển thị lên 
                var dataNV = nhanVien.Select(nv => new 
                {
                    MaNV = nv.MaNV.ToString(),
                    TenNhanVien = nv.TenNV.ToString(),
                    GioBatDau = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == nv.MaNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                .Select(c => c.GioBatDau).FirstOrDefault(),
                    GioKetThuc = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == nv.MaNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                .Select(c => c.GioKetThuc).FirstOrDefault()

                }).ToList();
                dgvShift.DataSource = dataNV;
            }
            dgvShift.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
            dgvShift.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
            dgvShift.Columns["TenNhanVien"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;           
            dgvShift.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            dgvShift.Columns["GioBatDau"].HeaderText = " Giờ bắt đầu";
            dgvShift.Columns["GioKetThuc"].HeaderText = "Giờ kết thúc";
        }
        private void btnSMThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSMDangKiCa_Click(object sender, EventArgs e)
        {
            FormSMDangKiCa DKC = new FormSMDangKiCa(IDStaff);
            if( DKC == null || DKC.IsDisposed)
            {
                DKC = new FormSMDangKiCa(IDStaff);
            }
            DKC.Show();
            DKC.updateLichLam += setCBBLichLam;
        }

        private void btnSMLichLam_Click(object sender, EventArgs e)
        {
            setCBBLichLam();
        }
    }
}
