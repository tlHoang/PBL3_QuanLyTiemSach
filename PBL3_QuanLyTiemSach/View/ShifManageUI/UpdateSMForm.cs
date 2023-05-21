using ComponentFactory.Krypton.Toolkit;
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
    public partial class UpdateSMForm : KryptonForm
    {
        public delegate void updateForm();
        public updateForm updateLichLam;
        int maCa;
        int maNV;
        public UpdateSMForm(int maCa, int maNV)
        {
            InitializeComponent();
            this.maCa = maCa;
            this.maNV = maNV;
            GUI();
        }
        private void setCBB()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCL.Items.AddRange(bll.getValueCBBCa().ToArray());
            cbbCL.ValueMember = "TenCa";
        }
        private void GUI()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            setCBB();
            DBQuanLyTiemSach db = new DBQuanLyTiemSach();
            dtChonNgayLam.Value = db.Cas.FirstOrDefault(c => c.MaCa == maCa).Ngay;
            cbbCL.Text = bll.getCaByGioBatDau(db.Cas.FirstOrDefault(c => c.MaCa == maCa).GioBatDau).TenCa;
            bll.setLabelSLNV(lbSL, dtChonNgayLam.Value, cbbCL);
            bll.setCheckBox(cB1, dtChonNgayLam.Value, cbbCL, maNV);
        }    
        private void UpdateCaLam(DateTime newDay, TimeSpan newGbd, TimeSpan newGkt)
        {
            try
            {
                DBQuanLyTiemSach db = new DBQuanLyTiemSach();

                Ca newCa = new Ca();
                newCa.MaCa = maCa;
                newCa.Ngay = newDay;
                newCa.GioBatDau = newGbd;
                newCa.GioKetThuc = newGkt;

                QLTS_SM_BLL bll = new QLTS_SM_BLL();
                if (bll.isValidDay(newCa.Ngay))
                {
                    if (bll.IsDuplicateCa(newCa, maNV) == true)
                    {
                        KryptonMessageBox.Show("Ca này bạn đã đăng kí rồi !");
                    }
                    else
                    {
                        if (bll.isFull(newCa))
                        {
                            KryptonMessageBox.Show("Ca này đã đủ người làm !");
                        }
                        else
                        {
                            bll.UpdateCa(newCa,maNV);
                            KryptonMessageBox.Show("Chỉnh sửa thành công");
                        }
                    }
                }
                else
                {
                    KryptonMessageBox.Show("Hãy chọn ngày cách ngày hiện tại 2 ngày làm");
                }

            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.ToString());
            }
            finally
            {
                updateLichLam?.Invoke();
            }
        }
        private void btnLuu_Click_1(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            DateTime newDT = (DateTime)dtChonNgayLam.Value;
            SMCBBItems_Start_End_Time selectedGioBatDau = (SMCBBItems_Start_End_Time)cbbCL.SelectedItem;
            TimeSpan newGioBatDau = selectedGioBatDau.GioBatDau;
            TimeSpan newGioKetThuc = selectedGioBatDau.GioKetThuc;
            UpdateCaLam(newDT,newGioBatDau,newGioKetThuc);
            bll.setCheckBox(cB1, dtChonNgayLam.Value, cbbCL,maNV);
            bll.setLabelSLNV(lbSL, dtChonNgayLam.Value, cbbCL);
        }

        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cbbCL_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(cB1, dtChonNgayLam.Value, cbbCL, maNV);
            bll.setLabelSLNV(lbSL, dtChonNgayLam.Value, cbbCL);
        }

        private void dtChonNgayLam_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCL.SelectedIndex = 0;
            bll.setCheckBox(cB1, dtChonNgayLam.Value, cbbCL, maNV);
            bll.setLabelSLNV(lbSL, dtChonNgayLam.Value, cbbCL);
        }
    }
}
