using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.View.ShifManageUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View
{

    public partial class ShiftManage : MetroFramework.Forms.MetroForm
    {
        int IDStaff;
        //Form1 f;
        public delegate void updateForm();
         public ShiftManage()
       // public ShiftManage(Form1 f1,int MaNV)
        {
            InitializeComponent();
            //this.f = f1;
            //this.IDStaff = MaNV;
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
            btnSMDangKiCa.Hide();
            btnXoaCa.Hide();
            btnChinhSua.Hide();
            
        }
        private void onGUIButton()
        {
            btnSMDangKiCa.Show();
            btnXoaCa.Show();
            btnChinhSua.Show();
            
        }
        private void setCBBLichLam()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dgvShift.DataSource = bll.getDataCaNhanVien(IDStaff);
            dgvShift.Columns["Tên"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvShift.Columns["Tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void setCBBMain()
        {
            DateTime txtTime = DateTime.Now.Date;
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dgvShift.DataSource = bll.getDataCaLamTrongNgay(txtTime);    
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
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            setCBBLichLam();
            btnSMXem.Hide();
            dtSMChonNgay.Hide();
            if (bll.IsAdmin(IDStaff))
            {                
                offGUIButton();
            }
            else
            {
                onGUIButton();
            }
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
            btnSMXem.Show();
            dtSMChonNgay.Show();
            setCBBMain();
        }

        private void btnSMXem_Click(object sender, EventArgs e)
        {
                DateTime pickTime = dtSMChonNgay.Value;                
                QLTS_SM_BLL bll = new QLTS_SM_BLL();
                dgvShift.DataSource = bll.getDataCaLamTrongNgay(pickTime);
                dgvShift.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
                dgvShift.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
                dgvShift.Columns["TenNhanVien"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvShift.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvShift.Columns["GioBatDau"].HeaderText = " Giờ bắt đầu";
                dgvShift.Columns["GioKetThuc"].HeaderText = "Giờ kết thúc";
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if(dgvShift.SelectedRows.Count == 1)
            {
                using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
                {
                    QLTS_SM_BLL bll = new QLTS_SM_BLL();
                    DataGridViewRow currentRow = dgvShift.CurrentRow;
                    int maCa = Convert.ToInt32(currentRow.Cells["Mã Ca"].Value.ToString());
                    if (bll.isValidDay(maCa))
                    {
                        UpdateSMForm UF = new UpdateSMForm(maCa, IDStaff);
                        if(UF == null || UF.IsDisposed)
                        {
                            UF = new UpdateSMForm(maCa, IDStaff);
                        }
                        UF.Show();
                    }
                    else
                    {
                        MessageBox.Show("Chỉ được Chỉnh sửa Ca làm khi cách ngày hiện tại 2 ngày !!");
                    }
                }
            }
            
        }
    }
}
