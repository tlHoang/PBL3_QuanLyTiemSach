using ComponentFactory.Krypton.Toolkit;
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
    public partial class FormSMDangKiCa : KryptonForm
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
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setLabelSLNV(lbCas1, dtChonNgayLamCa1.Value, cbbCaLam1);
            bll.setLabelSLNV(lbCas2, dtChonNgayLamCa2.Value, cbbCaLam2);
            bll.setLabelSLNV(lbCas3, dtChonNgayLamCa3.Value, cbbCaLam3);
            bll.setLabelSLNV(lbCas4, dtChonNgayLamCa4.Value, cbbCaLam4);
            bll.setLabelSLNV(lbCas5, dtChonNgayLamCa5.Value, cbbCaLam5);
            bll.setLabelSLNV(lbCas6, dtChonNgayLamCa6.Value, cbbCaLam6);
            bll.setLabelSLNV(lbCas7, dtChonNgayLamCa7.Value, cbbCaLam7);
        }
        private void setAllCheckBox()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa1, dtChonNgayLamCa1.Value, cbbCaLam1,MaNV);
            bll.setCheckBox(checkboxCa2, dtChonNgayLamCa2.Value, cbbCaLam2, MaNV);
            bll.setCheckBox(checkboxCa3, dtChonNgayLamCa3.Value, cbbCaLam3, MaNV);
            bll.setCheckBox(checkboxCa4, dtChonNgayLamCa4.Value, cbbCaLam4, MaNV);
            bll.setCheckBox(checkboxCa5, dtChonNgayLamCa5.Value, cbbCaLam5, MaNV);
            bll.setCheckBox(checkboxCa6, dtChonNgayLamCa6.Value, cbbCaLam6, MaNV);
            bll.setCheckBox(checkboxCa7, dtChonNgayLamCa7.Value, cbbCaLam7, MaNV);
        }

        private void setDateTimePicker()
        {
            DateTime currentDate = DateTime.Today.AddDays(2);
            for (int i = 1; i <= 7; i++)
            {
                KryptonDateTimePicker dtp = (KryptonDateTimePicker)this.Controls.Find("dtChonNgayLamCa" + i.ToString(), true)[0];
                dtp.Value = currentDate;
                currentDate = currentDate.AddDays(1);
            }
        }
        private void setCBB_ChonGio()
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            KryptonComboBox[] comboBoxes = new KryptonComboBox[7]
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
        private void dangKiCa(KryptonDateTimePicker dtpk, KryptonComboBox cbb)
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
                        KryptonMessageBox.Show("Bạn đã đăng kí ca này rồi !");
                    }
                    else
                    {
                        if (bll.isFull(newCa))
                        {
                            KryptonMessageBox.Show("Ca này đã đủ người làm !");
                        }
                        else
                        {
                            bll.AddCa(newCa, MaNV);
                            KryptonMessageBox.Show("Đăng Kí thành công");                        
                        }
                    }
                }
                else
                {
                    KryptonMessageBox.Show("Ngày Chọn không hợp lệ, Vui Lòng Chọn Ngày trước 2 ngày");
                }
                
            }
            catch(Exception ex) 
            {
                KryptonMessageBox.Show(ex.ToString());
            }
            finally
            {
                updateLichLam?.Invoke();
            }
        }
        private void XoaCa(DateTime day, KryptonComboBox cbb, KryptonCheckBox cb)
        {
            try
            {
                if (cb.Checked == true )
                {
                    QLTS_SM_BLL bll = new QLTS_SM_BLL();
                    SMCBBItems_Start_End_Time selecteCa = (SMCBBItems_Start_End_Time)cbb.SelectedItem;
                    TimeSpan gbd = selecteCa.GioBatDau;
                    TimeSpan gkt = selecteCa.GioKetThuc;
                    if (bll.isHasExist(day, gbd, gkt))
                    {
                        int maCa = bll.getCa(day, gbd, gkt).MaCa;
                        bll.DeleteCa(maCa, MaNV,MaNV);
                    }
                    else
                    {
                        KryptonMessageBox.Show("Chưa đăng kí ca này ");
                    }
                }
                else
                {
                    KryptonMessageBox.Show("Bạn Chưa Đăng Kí Ca này");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        //
        //Event Dang ki Click
        //
        private void btnDangKi_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dangKiCa(dtChonNgayLamCa1,cbbCaLam1);
            bll.setLabelSLNV(lbCas1, dtChonNgayLamCa1.Value, cbbCaLam1);
            bll.setCheckBox(checkboxCa1, dtChonNgayLamCa1.Value, cbbCaLam1, MaNV);
        }

        private void btnDangKiCa2_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dangKiCa(dtChonNgayLamCa2,cbbCaLam2);
            bll.setLabelSLNV(lbCas2, dtChonNgayLamCa2.Value, cbbCaLam2);
            bll.setCheckBox(checkboxCa2, dtChonNgayLamCa2.Value, cbbCaLam2, MaNV);
        }

        private void btnDangKiCa3_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dangKiCa(dtChonNgayLamCa3,cbbCaLam3);
            bll.setLabelSLNV(lbCas3, dtChonNgayLamCa3.Value, cbbCaLam3);
            bll.setCheckBox(checkboxCa3, dtChonNgayLamCa3.Value, cbbCaLam3, MaNV);
        }

        private void btnDangKiCa4_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dangKiCa(dtChonNgayLamCa4,cbbCaLam4);
            bll.setLabelSLNV(lbCas4, dtChonNgayLamCa4.Value, cbbCaLam4);
            bll.setCheckBox(checkboxCa4, dtChonNgayLamCa4.Value, cbbCaLam4, MaNV);
        }

        private void btnDangKiCa5_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dangKiCa(dtChonNgayLamCa5, cbbCaLam5);
            bll.setLabelSLNV(lbCas5, dtChonNgayLamCa5.Value, cbbCaLam5);
            bll.setCheckBox(checkboxCa5, dtChonNgayLamCa5.Value, cbbCaLam5, MaNV);
        }

        private void btnDangKiCa6_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dangKiCa(dtChonNgayLamCa6, cbbCaLam6);
            bll.setLabelSLNV(lbCas6, dtChonNgayLamCa6.Value, cbbCaLam6);
            bll.setCheckBox(checkboxCa6, dtChonNgayLamCa6.Value, cbbCaLam6, MaNV);

        }

        private void btnDangKiCa7_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            dangKiCa(dtChonNgayLamCa7, cbbCaLam7);
            bll.setLabelSLNV(lbCas7, dtChonNgayLamCa7.Value, cbbCaLam7);
            bll.setCheckBox(checkboxCa7, dtChonNgayLamCa7.Value, cbbCaLam7, MaNV);
        } 
        //
        // Event CBB selected index changed
        //
        private void cbbCaLam1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa1, dtChonNgayLamCa1.Value, cbbCaLam1, MaNV);
            bll.setLabelSLNV(lbCas1, dtChonNgayLamCa1.Value, cbbCaLam1);            
        }
        private void cbbCaLam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa2, dtChonNgayLamCa2.Value, cbbCaLam2, MaNV);
            bll.setLabelSLNV(lbCas2, dtChonNgayLamCa2.Value, cbbCaLam2);
        }

        private void cbbCaLam3_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa3, dtChonNgayLamCa3.Value, cbbCaLam3, MaNV);
            bll.setLabelSLNV(lbCas3, dtChonNgayLamCa3.Value, cbbCaLam3);         
        }

        private void cbbCaLam4_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa4, dtChonNgayLamCa4.Value, cbbCaLam4, MaNV);
            bll.setLabelSLNV(lbCas4, dtChonNgayLamCa4.Value, cbbCaLam4);
        }

        private void cbbCaLam5_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa5, dtChonNgayLamCa5.Value, cbbCaLam5, MaNV);
            bll.setLabelSLNV(lbCas5, dtChonNgayLamCa5.Value, cbbCaLam5);

        }

        private void cbbCaLam6_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa6, dtChonNgayLamCa6.Value, cbbCaLam6, MaNV);
            bll.setLabelSLNV(lbCas6, dtChonNgayLamCa6.Value, cbbCaLam6);

        }

        private void cbbCaLam7_SelectedIndexChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            bll.setCheckBox(checkboxCa7, dtChonNgayLamCa7.Value, cbbCaLam7, MaNV);
            bll.setLabelSLNV(lbCas7, dtChonNgayLamCa7.Value, cbbCaLam7);

        }
        //
        //Event Xoa Click
        //
        private void btnXoaCa1_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            XoaCa(dtChonNgayLamCa1.Value, cbbCaLam1, checkboxCa1);
            bll.setLabelSLNV(lbCas1, dtChonNgayLamCa1.Value, cbbCaLam1);
            bll.setCheckBox(checkboxCa1, dtChonNgayLamCa1.Value, cbbCaLam1, MaNV);
        }

        private void btnXoaCa2_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            XoaCa(dtChonNgayLamCa2.Value, cbbCaLam2, checkboxCa2);
            bll.setLabelSLNV(lbCas2, dtChonNgayLamCa2.Value, cbbCaLam2);
            bll.setCheckBox(checkboxCa2, dtChonNgayLamCa2.Value, cbbCaLam2, MaNV);
        }

        private void btnXoaCa3_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            XoaCa(dtChonNgayLamCa3.Value, cbbCaLam3, checkboxCa3);
            bll.setLabelSLNV(lbCas3, dtChonNgayLamCa3.Value, cbbCaLam3);
            bll.setCheckBox(checkboxCa3, dtChonNgayLamCa3.Value, cbbCaLam3, MaNV);
        }

        private void btnXoaCa4_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            XoaCa(dtChonNgayLamCa4.Value, cbbCaLam4, checkboxCa4);
            bll.setLabelSLNV(lbCas4, dtChonNgayLamCa4.Value, cbbCaLam4);
            bll.setCheckBox(checkboxCa4, dtChonNgayLamCa4.Value, cbbCaLam4, MaNV);
        }

        private void btnXoaCa5_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            XoaCa(dtChonNgayLamCa5.Value, cbbCaLam5, checkboxCa5);
            bll.setLabelSLNV(lbCas5, dtChonNgayLamCa5.Value, cbbCaLam5);
            bll.setCheckBox(checkboxCa5, dtChonNgayLamCa5.Value, cbbCaLam5, MaNV);
        }

        private void btnXoaCa6_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            XoaCa(dtChonNgayLamCa6.Value, cbbCaLam6, checkboxCa6);
            bll.setLabelSLNV(lbCas6, dtChonNgayLamCa6.Value, cbbCaLam6);
            bll.setCheckBox(checkboxCa6, dtChonNgayLamCa6.Value, cbbCaLam6, MaNV);
        }

        private void btnXoaCa7_Click(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            XoaCa(dtChonNgayLamCa7.Value, cbbCaLam7, checkboxCa7);
            bll.setLabelSLNV(lbCas7, dtChonNgayLamCa7.Value, cbbCaLam7);
            bll.setCheckBox(checkboxCa7, dtChonNgayLamCa7.Value, cbbCaLam7, MaNV);
        }
        //
        // event DateTimepicker value changed
        //
        private void dtChonNgayLamCa1_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCaLam1.SelectedIndex = 0;
            bll.setCheckBox(checkboxCa1, dtChonNgayLamCa1.Value, cbbCaLam1, MaNV);
            bll.setLabelSLNV(lbCas1, dtChonNgayLamCa1.Value, cbbCaLam1);            
        }

        private void dtChonNgayLamCa2_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCaLam2.SelectedIndex = 0;
            bll.setCheckBox(checkboxCa2, dtChonNgayLamCa2.Value, cbbCaLam2, MaNV);
            bll.setLabelSLNV(lbCas2, dtChonNgayLamCa2.Value, cbbCaLam2);
        }

        private void dtChonNgayLamCa3_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCaLam3.SelectedIndex = 0;
            bll.setCheckBox(checkboxCa3, dtChonNgayLamCa3.Value, cbbCaLam3, MaNV);
            bll.setLabelSLNV(lbCas3, dtChonNgayLamCa3.Value, cbbCaLam3);
        }

        private void dtChonNgayLamCa4_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCaLam4.SelectedIndex = 0;
            bll.setCheckBox(checkboxCa4, dtChonNgayLamCa4.Value, cbbCaLam4, MaNV);
            bll.setLabelSLNV(lbCas4, dtChonNgayLamCa4.Value, cbbCaLam4);
        }

        private void dtChonNgayLamCa5_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCaLam5.SelectedIndex = 0;
            bll.setCheckBox(checkboxCa5, dtChonNgayLamCa5.Value, cbbCaLam5, MaNV);
            bll.setLabelSLNV(lbCas5, dtChonNgayLamCa5.Value, cbbCaLam5);
        }

        private void dtChonNgayLamCa6_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCaLam6.SelectedIndex = 0;
            bll.setCheckBox(checkboxCa6, dtChonNgayLamCa6.Value, cbbCaLam6, MaNV);
            bll.setLabelSLNV(lbCas6, dtChonNgayLamCa6.Value, cbbCaLam6);
        }

        private void dtChonNgayLamCa7_ValueChanged(object sender, EventArgs e)
        {
            QLTS_SM_BLL bll = new QLTS_SM_BLL();
            cbbCaLam7.SelectedIndex = 0;
            bll.setCheckBox(checkboxCa7, dtChonNgayLamCa7.Value, cbbCaLam7, MaNV);
            bll.setLabelSLNV(lbCas7, dtChonNgayLamCa7.Value, cbbCaLam7);
        }
    }
}
