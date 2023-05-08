using PBL3_QuanLyTiemSach.BLL;
using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View.ShifManageUI
{
    public partial class FormSMDangKiCa : MetroFramework.Forms.MetroForm
    {
        int MaNV = 0;
        public delegate void updateForm();
        public updateForm updateLichLam;
        public FormSMDangKiCa(int maNV)
        {
            InitializeComponent();
            setCBB_ChonGio();
            MaNV = maNV;
        }
        public void setCBB_ChonGio()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbGioBatDau.Items.AddRange(bll.setSMDangKiCaCBB_GioBatDau().ToArray());
            cbbGioKetThuc.Items.AddRange(bll.setSMDangKiCaCBB_GioKetThuc().ToArray());

            cbbGioBatDau.ValueMember = "Value";
            cbbGioBatDau.DisplayMember = "Text";

            cbbGioKetThuc.ValueMember = "Value";
            cbbGioKetThuc.DisplayMember = "Text";

            cbbGioBatDau.SelectedIndexChanged += cbbGioBatDau_SelectedIndexChanged;
            cbbGioKetThuc.SelectedIndexChanged += cbbGioKetThuc_SelectedIndexChanged;
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void cbbGioBatDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan gioBatDau = ((SMCBBItems_Start_End_Time)cbbGioBatDau.SelectedItem).Text;

            cbbGioKetThuc.SelectedIndex = cbbGioKetThuc.Items.IndexOf
                (cbbGioKetThuc.Items.Cast<SMCBBItems_Start_End_Time>().FirstOrDefault(item => item.Text > gioBatDau));
        }

        private void cbbGioKetThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan gioKetThuc = ((SMCBBItems_Start_End_Time)cbbGioKetThuc.SelectedItem).Text;
            cbbGioBatDau.SelectedIndex = cbbGioBatDau.Items.IndexOf
                (cbbGioBatDau.Items.Cast<SMCBBItems_Start_End_Time>().LastOrDefault(item => item.Text < gioKetThuc));
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime newDT = (DateTime)dtChonNgayLam.Value;
                SMCBBItems_Start_End_Time selectedGioBatDau = (SMCBBItems_Start_End_Time)cbbGioBatDau.SelectedItem;
                SMCBBItems_Start_End_Time selectedGioKetThuc = (SMCBBItems_Start_End_Time)cbbGioKetThuc.SelectedItem;

                TimeSpan newGioBatDau = selectedGioBatDau.Text;
                TimeSpan newGioKetThuc = selectedGioKetThuc.Text;
                DBQuanLyTiemSach db = new DBQuanLyTiemSach();
                
                    Ca newCa = new Ca();

                    newCa.Ngay = newDT;
                    newCa.GioBatDau = newGioBatDau;
                    newCa.GioKetThuc = newGioKetThuc;

                    QLTS_SM_BLL bll = new QLTS_SM_BLL();
                    bll.AddCa(newCa, MaNV);
                
                MessageBox.Show("Đăng Kí thành công");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                updateLichLam?.Invoke();
                this.Dispose();
            }
        }
    }
}
