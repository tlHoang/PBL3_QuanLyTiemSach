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
        string flagDGV = "";
        string flagButton = "";
        public delegate void updateForm();
        public ShiftManage()
        {
            InitializeComponent();
            setCBBMain();
            offGUIButton();
            setTenNhanVien(IDStaff);
        }
        private void setTenNhanVien(int maNV)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            txtbxTenNhanVien.Text = bll.getTenNhanVien(maNV);
            txtbxTenNhanVien.ReadOnly = true;
            txtbxTenNhanVien.Enabled = false;
        }
        private void offGUIButton()
        {        
            btnSMDangKiCa.Enabled= false;
            btnXoaCa.Enabled= false;
            flagButton = "off";
        }
        private void onGUIButton()
        {
            btnSMDangKiCa.Enabled= true;
            btnXoaCa.Enabled= true;
            flagButton = "on";
        }
        private void setCBBLichLam()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dgvShift.DataSource = bll.getCaNhanVien(IDStaff);
            dgvShift.Columns["Tên"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvShift.Columns["Tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void setCBBMain()
        {
            DateTime txtTime = dtSMChonNgay.Value;// next version Trong này có ca của ai thì hiển thị lên
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dgvShift.DataSource = bll.getCaLamTrongNgay();    
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
            flagDGV = "LichLam";
            onGUIButton();
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if(dgvShift.SelectedRows.Count == 1) 
            {
                DataGridViewRow selectedRow = dgvShift.CurrentRow;
                int maCa = Convert.ToInt32(selectedRow.Cells["Mã Ca"].Value.ToString());
                QLTS_SM_BLL bll = new QLTS_SM_BLL();
                bll.DeleteCa(maCa,IDStaff);
                setCBBLichLam();
             }
            else
            {
                MessageBox.Show("Chọn ca cần xóa");
            }
            
        }

        private void btnSMQuayLai_Click(object sender, EventArgs e)
        {
            offGUIButton();
            setCBBMain();
        }
    }
}
