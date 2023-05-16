﻿using MetroFramework.Components;
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
        int IDStaff = 2;
        Form1 f;
        string flagButton = "";
        bool turnOnDoubleCLick = false;
        public delegate void updateForm();
         public ShiftManage()
        //public ShiftManage(Form1 f1,int MaNV)
        {
            InitializeComponent();
            //this.f = f1;
            //this.IDStaff = MaNV;
            GUI();
        }        
        private void GUI()
        {
            setCBBMain();
            offGUIButton();
            setTenNhanVien(IDStaff);
            setToolTip();
            setCBBTimeShowCa();
            cbbTimeShowCa.Hide();
            flagButton = "Main";
            dgvShift.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        public void setCBBTimeShowCa()
        {
            cbbTimeShowCa.Items.Add("Tất Cả");
            cbbTimeShowCa.Items.Add("Chưa Làm");
            cbbTimeShowCa.Items.Add("Đã Làm");
            cbbTimeShowCa.SelectedIndex = 1;
        }
        private void setToolTip()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            if (bll.IsAdmin(IDStaff))
            {
                this.ToolTip.SetToolTip(this.btnSMLichLam, "Xem Lịch làm của nhân viên");
            }
            else
            {
                 this.ToolTip.SetToolTip(this.btnSMLichLam, "Đăng kí, Xóa, Chỉnh Sửa Ca làm");
            }
            //this.ToolTip.SetToolTip(ShiftMa, "Xem, chọn lịch làm tại đây !");           
            this.ToolTip.SetToolTip(this.btnSMXem, "Xem ca làm trong ngày");
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
            btnSMQuayLai.Hide();
            
        }
        private void onGUIButton()
        {
            btnSMDangKiCa.Show();
            btnXoaCa.Show();
            btnChinhSua.Show(); 
            btnSMQuayLai.Show();
        }
        private void setCBBLichLamNV()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dgvShift.DataSource = bll.getDataCaLamNhanVien(IDStaff,"Future");
            dgvShift.Columns["MaCa"].HeaderText = "Mã Ca";
            dgvShift.Columns["Tên"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dgvShift.Columns["Tên"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }
        private void setCBBLichLamAdmin(string mode)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dgvShift.DataSource = bll.getAdminDataCaLam(mode);
            dgvShift.Columns["MaCa"].HeaderText = "Mã Ca";
            dgvShift.Columns["SLNV"].HeaderText = "Số Lượng Nhân Viên";
            dgvShift.Columns["NgayLam"].HeaderText = "Ngày Làm";
            dgvShift.Columns["GBD"].HeaderText = "Giờ Bắt Đầu";
            dgvShift.Columns["GKT"].HeaderText = "Giờ Kết Thúc";
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
            DKC.updateLichLam += setCBBLichLamNV;
        }

        private void GUI_LichLam()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dtSMChonNgay.Hide();
            cbbTimeShowCa.Location = dtSMChonNgay.Location;
            cbbTimeShowCa.Show();
            
            if (bll.IsAdmin(IDStaff))
            {
                offGUIButton();
                setCBBLichLamAdmin(null);
                turnOnDoubleCLick = true;
                btnSMQuayLai.Show();
            }
            else
            {
                onGUIButton();
                btnSMQuayLai.Show();
                setCBBLichLamNV();
            }
        }
        private void btnSMLichLam_Click(object sender, EventArgs e)
        {
            GUI_LichLam();
            flagButton = "LL";           
        }

        private void btnXoaCa_Click(object sender, EventArgs e)
        {
            if(dgvShift.SelectedRows.Count == 1) 
            {
                DataGridViewRow selectedRow = dgvShift.CurrentRow;
                if(selectedRow != null)
                { 
                    int maCa = Convert.ToInt32(selectedRow.Cells["MaCa"].Value.ToString());
                    QLTS_SM_BLL bll = new QLTS_SM_BLL();
                    bll.DeleteCa(maCa,IDStaff);
                    setCBBLichLamNV();                
                }
                else
                {
                    MessageBox.Show("Dữ Liệu Rỗng");
                }
             }
            else
            {
                MessageBox.Show("Chọn ca cần xóa");
            }
            
        }

        private void btnSMQuayLai_Click(object sender, EventArgs e)
        {
            if (flagButton == "LL")
            {
                GUI_LichLam();
            }
            else if (flagButton == "Main") ;
            {
                offGUIButton();
                flagButton = "Main";
                cbbTimeShowCa.Hide();
                dtSMChonNgay.Show();
                setCBBMain();
            }
            
        }

        private void btnSMXem_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();

            if (flagButton == "Main")
            {
                DateTime pickTime = dtSMChonNgay.Value;
                dgvShift.DataSource = bll.getDataCaLamTrongNgay(pickTime);
                dgvShift.Columns["MaNV"].HeaderText = "Mã Nhân Viên";
                dgvShift.Columns["TenNhanVien"].HeaderText = "Tên Nhân Viên";
                dgvShift.Columns["TenNhanVien"].DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dgvShift.Columns["TenNhanVien"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                dgvShift.Columns["GioBatDau"].HeaderText = " Giờ bắt đầu";
                dgvShift.Columns["GioKetThuc"].HeaderText = "Giờ kết thúc";
            }
            else if (flagButton == "LL")
            {
                string selected = cbbTimeShowCa.Text;
                //admin
                if (bll.IsAdmin(IDStaff))
                {
                    turnOnDoubleCLick = true;
                    if (selected == "Tất Cả")
                    {
                        setCBBLichLamAdmin(null);
                    }
                    else if (selected == "Chưa Làm")
                    {
                        setCBBLichLamAdmin("Future");
                    }
                    else if (selected == "Đã Làm")
                    {
                        setCBBLichLamAdmin("Past");
                    } 
                }
                //nv
                else
                {
                    if (selected == "Tất Cả")
                    {
                        dgvShift.DataSource = bll.getDataCaLamNhanVien(IDStaff, null);
                    }
                    else if (selected == "Chưa Làm")
                    {
                        dgvShift.DataSource = bll.getDataCaLamNhanVien(IDStaff, "Future");
                    }
                    else if (selected == "Đã Làm")
                    {
                        dgvShift.DataSource = bll.getDataCaLamNhanVien(IDStaff, "Past");
                    }
                }                                   
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if(dgvShift.SelectedRows.Count == 1)
            {
                using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
                {
                    QLTS_SM_BLL bll = new QLTS_SM_BLL();
                    DataGridViewRow currentRow = dgvShift.CurrentRow;
                    int maCa = Convert.ToInt32(currentRow.Cells["MaCa"].Value.ToString());
                    if (bll.isValidDay(maCa))
                    {
                        UpdateSMForm UF = new UpdateSMForm(maCa, IDStaff);
                        if(UF == null || UF.IsDisposed)
                        {
                            UF = new UpdateSMForm(maCa, IDStaff);
                        }
                        UF.Show();
                        UF.updateLichLam += setCBBLichLamNV;
                    }
                    else
                    {
                        MetroFramework.MetroMessageBox.Show(this, "Chỉ được Chỉnh sửa Ca làm khi cách ngày hiện tại 2 ngày !!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information, 140);
                    }
                }
            }
            
        }

        private void dgvShift_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            btnSMQuayLai.Hide();
            if (bll.IsAdmin(IDStaff) && turnOnDoubleCLick == true)
            {
                DataGridViewRow currentRow = dgvShift.CurrentRow;
                int maCa = Convert.ToInt32(currentRow.Cells["MaCa"].Value.ToString());
                dgvShift.DataSource = bll.getDataStaffByIDShift(maCa);      
                turnOnDoubleCLick = false;
            }
        }
    }
}
