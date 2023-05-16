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
    public partial class UpdateSMForm : MetroFramework.Forms.MetroForm
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
            cbbCaLam.Items.AddRange(bll.getValueCBBCa().ToArray());
            cbbCaLam.ValueMember = "Value";
  
        }
        private void GUI()
        {
            setCBB();
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                dtChonNgayLam.Value = db.Cas.FirstOrDefault(c => c.MaCa == maCa).Ngay;
                cbbCaLam.Text = db.Cas.FirstOrDefault(c => c.MaCa == maCa).GioBatDau.ToString();
            }
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
                        MessageBox.Show("Ca này bạn đã đăng kí rồi !");
                    }
                    else
                    {
                        if (bll.isFull(newCa))
                        {
                            MessageBox.Show("Ca này đã đủ người làm !");
                        }
                        else
                        {
                            bll.UpdateCa(newCa,maNV);
                            MessageBox.Show("Chỉnh sửa thành công");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Hãy chọn ngày cách ngày hiện tại 2 ngày làm");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                updateLichLam?.Invoke();
            }
        }
        private void btnLuu_Click(object sender, EventArgs e)
        {
            DateTime newDT = (DateTime)dtChonNgayLam.Value;
            SMCBBItems_Start_End_Time selectedGioBatDau = (SMCBBItems_Start_End_Time)cbbCaLam.SelectedItem;
            TimeSpan newGioBatDau = selectedGioBatDau.GioBatDau;
            TimeSpan newGioKetThuc = selectedGioBatDau.GioKetThuc;
            UpdateCaLam(newDT,newGioBatDau,newGioKetThuc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
