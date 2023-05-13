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
            cbbgbd.Items.AddRange(bll.setSMDangKiCaCBB_GioBatDau().ToArray());
            cbbgkt.Items.AddRange(bll.setSMDangKiCaCBB_GioKetThuc().ToArray());

            cbbgbd.ValueMember = "Value";
            cbbgbd.DisplayMember= "Text";

            cbbgkt.ValueMember= "Value";   
            cbbgkt.DisplayMember= "Text";

            cbbgbd.SelectedIndexChanged += cbbgbd_SelectedIndexChanged;
            cbbgkt.SelectedIndexChanged += cbbgkt_SelectedIndexChanged;
        }
        private void GUI()
        {
            setCBB();
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                dtChonNgayLam.Value = db.Cas.FirstOrDefault(c => c.MaCa == maCa).Ngay;
                cbbgbd.Text = db.Cas.FirstOrDefault(c => c.MaCa == maCa).GioBatDau.ToString();
                cbbgkt.Text = db.Cas.FirstOrDefault(c => c.MaCa ==maCa).GioKetThuc.ToString();
            }
        }
        private void cbbgbd_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan gioBatDau = ((SMCBBItems_Start_End_Time)cbbgbd.SelectedItem).Text;

            cbbgkt.SelectedIndex = cbbgkt.Items.IndexOf
                (cbbgkt.Items.Cast<SMCBBItems_Start_End_Time>().FirstOrDefault(item => item.Text > gioBatDau));

        }

        private void cbbgkt_SelectedIndexChanged(object sender, EventArgs e)
        {
            TimeSpan gioKetThuc = ((SMCBBItems_Start_End_Time)cbbgkt.SelectedItem).Text;
            cbbgbd.SelectedIndex = cbbgbd.Items.IndexOf
                (cbbgbd.Items.Cast<SMCBBItems_Start_End_Time>().LastOrDefault(item => item.Text < gioKetThuc));

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
            SMCBBItems_Start_End_Time selectedGioBatDau = (SMCBBItems_Start_End_Time)cbbgbd.SelectedItem;
            SMCBBItems_Start_End_Time selectedGioKetThuc = (SMCBBItems_Start_End_Time)cbbgkt.SelectedItem;

            TimeSpan newGioBatDau = selectedGioBatDau.Text;
            TimeSpan newGioKetThuc = selectedGioKetThuc.Text;
            UpdateCaLam(newDT,newGioBatDau,newGioKetThuc);
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
