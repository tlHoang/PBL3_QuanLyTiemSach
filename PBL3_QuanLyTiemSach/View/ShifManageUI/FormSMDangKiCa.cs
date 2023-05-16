using MetroFramework.Controls;
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
            MaNV = maNV;
            GUI();         
        }
        private void GUI()
        {
            setCBB_ChonGio();
            setDateTimePicker();
            setAllLabelSLNV();
            setAllCheckBox();
        }
        private void setAllLabelSLNV()
        {
            setLabelSLNV(lbCa1,dtChonNgayLamCa1.Value,cbbCaLam1);
            setLabelSLNV(lbCa2, dtChonNgayLamCa2.Value, cbbCaLam2);
            setLabelSLNV(lbCa3, dtChonNgayLamCa3.Value, cbbCaLam3);
            setLabelSLNV(lbCa4, dtChonNgayLamCa4.Value, cbbCaLam4);
            setLabelSLNV(lbCa5, dtChonNgayLamCa5.Value, cbbCaLam5);
            setLabelSLNV(lbCa6, dtChonNgayLamCa6.Value, cbbCaLam6);
            setLabelSLNV(lbCa7, dtChonNgayLamCa7.Value, cbbCaLam7);
        }
        private void setAllCheckBox()
        {
            setCheckBox(cB1, dtChonNgayLamCa1.Value, cbbCaLam1);
            setCheckBox(cB2, dtChonNgayLamCa2.Value, cbbCaLam2);
            setCheckBox(cB3, dtChonNgayLamCa3.Value, cbbCaLam3);
            setCheckBox(cB4, dtChonNgayLamCa4.Value, cbbCaLam4);
            setCheckBox(cB5, dtChonNgayLamCa5.Value, cbbCaLam5);
            setCheckBox(cB6, dtChonNgayLamCa6.Value, cbbCaLam6);
            setCheckBox(cB7, dtChonNgayLamCa7.Value, cbbCaLam7);
        }
        private void setCheckBox(CheckBox cB,DateTime day, ComboBox cbb)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            SMCBBItems_Start_End_Time selecteCa = (SMCBBItems_Start_End_Time)cbb.SelectedItem;
            TimeSpan gbd = selecteCa.GioBatDau;
            bool Oke = bll.IsDuplicateCa(day, gbd, MaNV);
            if (Oke)
            {
                cB.Checked = true;
            }
            else
            {
                cB.Checked = false;
            }

        }
        private void setLabelSLNV(Label lb,DateTime day,ComboBox cbb)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            SMCBBItems_Start_End_Time selecteCa = (SMCBBItems_Start_End_Time)cbb.SelectedItem;
            TimeSpan gbd = selecteCa.GioBatDau;
            TimeSpan gkt = selecteCa.GioKetThuc;
            if(bll.getCa(day, gbd, gkt) != null)
            {
                int maCa =bll.getCa(day, gbd, gkt).MaCa;
                int SL = bll.getSoLuongNhanVienTrongCa(maCa);
                lb.Text = $"{SL}" + "/2"; 
            }
            else
            {
                lb.Text = "0/2";
            }
            
                     
        }
        private void setDateTimePicker()
        {
            DateTime currentDate = DateTime.Today.AddDays(2);
            for (int i = 1; i <= 7; i++)
            {
                DateTimePicker dtp = (DateTimePicker)this.Controls.Find("dtChonNgayLamCa" + i.ToString(), true)[0];
                dtp.Value = currentDate;
                currentDate = currentDate.AddDays(1);
            }
        }
        private void setCBB_ChonGio()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            ComboBox[] comboBoxes = new ComboBox[7]
            {
                cbbCaLam1,
                cbbCaLam2,
                cbbCaLam3,
                cbbCaLam4,
                cbbCaLam5,
                cbbCaLam6,
                cbbCaLam7,
            };

            for (int i = 0; i < 7; i++)
            {
                comboBoxes[i].Items.AddRange(bll.getValueCBBCa().ToArray());

                comboBoxes[i].ValueMember = "TenCa";
                comboBoxes[i].SelectedIndex = 0;
            }
        }
            private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void dangKiCa(DateTimePicker dtpk, ComboBox cbb)
        {
            try
            {
                DateTime newDT = (DateTime)dtpk.Value;
                SMCBBItems_Start_End_Time selecteCa = (SMCBBItems_Start_End_Time)cbb.SelectedItem;
                TimeSpan newGioBatDau = selecteCa.GioBatDau;
                TimeSpan newGioKetThuc = selecteCa.GioKetThuc;
                DBQuanLyTiemSach db = new DBQuanLyTiemSach();

                Ca newCa = new Ca();

                newCa.Ngay = newDT;
                newCa.GioBatDau = newGioBatDau;
                newCa.GioKetThuc = newGioKetThuc;

                QLTS_SM_BLL bll = new QLTS_SM_BLL();
                if (bll.isValidDay(newDT))
                {
                    if (bll.IsDuplicateCa(newCa, MaNV) == true)
                    {
                        MessageBox.Show("Bạn đã đăng kí ca này rồi !");
                    }
                    else
                    {
                        if (bll.isFull(newCa))
                        {
                            MessageBox.Show("Ca này đã đủ người làm !");
                        }
                        else
                        {
                            bll.AddCa(newCa, MaNV);
                            MessageBox.Show("Đăng Kí thành công");                        
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Ngày Chọn không hợp lệ, Vui Lòng Chọn Ngày trước 2 ngày");
                }
                
            }
            catch(Exception ex) 
            {
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                updateLichLam?.Invoke();
            }
        }
        private void XoaCa(DateTime day, ComboBox cbb)
        {
            try
            {
                QLTS_SM_BLL bll = new QLTS_SM_BLL();
                SMCBBItems_Start_End_Time selecteCa = (SMCBBItems_Start_End_Time)cbb.SelectedItem;
                TimeSpan gbd = selecteCa.GioBatDau;
                TimeSpan gkt = selecteCa.GioKetThuc;
                if (bll.isHasExist(day, gbd, gkt))
                {
                    int maCa = bll.getCa(day, gbd, gkt).MaCa;
                    bll.DeleteCa(maCa, MaNV);
                }
                else
                {
                    MessageBox.Show("Chưa đăng kí ca này ");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void btnDangKi_Click(object sender, EventArgs e)
        {  
            dangKiCa(dtChonNgayLamCa1,cbbCaLam1);
            setLabelSLNV(lbCa1, dtChonNgayLamCa1.Value, cbbCaLam1);
            setCheckBox(cB1, dtChonNgayLamCa1.Value, cbbCaLam1);
        }

        private void btnDangKiCa2_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa2,cbbCaLam2);
            setLabelSLNV(lbCa2, dtChonNgayLamCa2.Value, cbbCaLam2);
            setCheckBox(cB2, dtChonNgayLamCa2.Value, cbbCaLam2);
        }

        private void btnDangKiCa3_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa3,cbbCaLam3);
            setLabelSLNV(lbCa3, dtChonNgayLamCa3.Value, cbbCaLam3);
            setCheckBox(cB3, dtChonNgayLamCa3.Value, cbbCaLam3);
        }

        private void btnDangKiCa4_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa4,cbbCaLam4);
            setLabelSLNV(lbCa4, dtChonNgayLamCa4.Value, cbbCaLam4);
            setCheckBox(cB4, dtChonNgayLamCa4.Value, cbbCaLam4);
        }

        private void btnDangKiCa5_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa5, cbbCaLam5);
            setLabelSLNV(lbCa5, dtChonNgayLamCa5.Value, cbbCaLam5);
            setCheckBox(cB5, dtChonNgayLamCa5.Value, cbbCaLam5);
        }

        private void btnDangKiCa6_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa6, cbbCaLam6);
            setLabelSLNV(lbCa6, dtChonNgayLamCa6.Value, cbbCaLam6);
            setCheckBox(cB6, dtChonNgayLamCa6.Value, cbbCaLam6);

        }

        private void btnDangKiCa7_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa7, cbbCaLam7);
            setLabelSLNV(lbCa7, dtChonNgayLamCa7.Value, cbbCaLam7);
            setCheckBox(cB7, dtChonNgayLamCa7.Value, cbbCaLam7);
        }

        private void cbbCaLam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelSLNV(lbCa1, dtChonNgayLamCa1.Value, cbbCaLam1);
            setCheckBox(cB1, dtChonNgayLamCa1.Value, cbbCaLam1);
        }

        private void cbbCaLam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelSLNV(lbCa2, dtChonNgayLamCa2.Value, cbbCaLam2);
            setCheckBox(cB2, dtChonNgayLamCa2.Value, cbbCaLam2);
        }

        private void cbbCaLam3_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelSLNV(lbCa3, dtChonNgayLamCa3.Value, cbbCaLam3);
            setCheckBox(cB3, dtChonNgayLamCa3.Value, cbbCaLam3);
        }

        private void cbbCaLam4_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelSLNV(lbCa4, dtChonNgayLamCa4.Value, cbbCaLam4);
            setCheckBox(cB4, dtChonNgayLamCa4.Value, cbbCaLam4);
        }

        private void cbbCaLam5_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelSLNV(lbCa5, dtChonNgayLamCa5.Value, cbbCaLam5);
            setCheckBox(cB5, dtChonNgayLamCa5.Value, cbbCaLam5);
        }

        private void cbbCaLam6_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelSLNV(lbCa6, dtChonNgayLamCa6.Value, cbbCaLam6);
            setCheckBox(cB6, dtChonNgayLamCa6.Value, cbbCaLam6);
        }

        private void cbbCaLam7_SelectedIndexChanged(object sender, EventArgs e)
        {
            setLabelSLNV(lbCa7, dtChonNgayLamCa7.Value, cbbCaLam7);
            setCheckBox(cB1, dtChonNgayLamCa1.Value, cbbCaLam1);
            setCheckBox(cB7, dtChonNgayLamCa7.Value, cbbCaLam7);
        }

        private void btnXoaCa1_Click(object sender, EventArgs e)
        {
            XoaCa(dtChonNgayLamCa1.Value, cbbCaLam1);
            setLabelSLNV(lbCa1, dtChonNgayLamCa1.Value, cbbCaLam1);
            setCheckBox(cB1, dtChonNgayLamCa1.Value, cbbCaLam1);
        }

        private void btnXoaCa2_Click(object sender, EventArgs e)
        {
            XoaCa(dtChonNgayLamCa2.Value, cbbCaLam2);
            setLabelSLNV(lbCa2, dtChonNgayLamCa2.Value, cbbCaLam2);
            setCheckBox(cB2, dtChonNgayLamCa2.Value, cbbCaLam2);
        }

        private void btnXoaCa3_Click(object sender, EventArgs e)
        {
            XoaCa(dtChonNgayLamCa3.Value, cbbCaLam3);
            setLabelSLNV(lbCa3, dtChonNgayLamCa3.Value, cbbCaLam3);
            setCheckBox(cB3, dtChonNgayLamCa3.Value, cbbCaLam3);
        }

        private void btnXoaCa4_Click(object sender, EventArgs e)
        {
            XoaCa(dtChonNgayLamCa4.Value, cbbCaLam4);
            setLabelSLNV(lbCa4, dtChonNgayLamCa4.Value, cbbCaLam4);
            setCheckBox(cB4, dtChonNgayLamCa4.Value, cbbCaLam4);
        }

        private void btnXoaCa5_Click(object sender, EventArgs e)
        {
            XoaCa(dtChonNgayLamCa5.Value, cbbCaLam5);
            setLabelSLNV(lbCa5, dtChonNgayLamCa5.Value, cbbCaLam5);
            setCheckBox(cB5, dtChonNgayLamCa5.Value, cbbCaLam5);
        }

        private void btnXoaCa6_Click(object sender, EventArgs e)
        {
            XoaCa(dtChonNgayLamCa6.Value, cbbCaLam6);
            setLabelSLNV(lbCa6, dtChonNgayLamCa6.Value, cbbCaLam6);
            setCheckBox(cB6, dtChonNgayLamCa6.Value, cbbCaLam6);
        }

        private void btnXoaCa7_Click(object sender, EventArgs e)
        {
            XoaCa(dtChonNgayLamCa7.Value, cbbCaLam7);
            setLabelSLNV(lbCa7, dtChonNgayLamCa7.Value, cbbCaLam7);
            setCheckBox(cB7, dtChonNgayLamCa7.Value, cbbCaLam7);
        }
    }
}
