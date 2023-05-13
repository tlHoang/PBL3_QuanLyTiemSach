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
            setDateTimePicker();
            MaNV = maNV;
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
            ComboBox[,] comboBoxes = new ComboBox[7, 2]
            {
                { cbbGioBatDauCa1, cbbGioKetThucCa1 },
                { cbbGioBatDauCa2, cbbGioKetThucCa2 },
                { cbbGioBatDauCa3, cbbGioKetThucCa3 },
                { cbbGioBatDauCa4, cbbGioKetThucCa4 },
                { cbbGioBatDauCa5, cbbGioKetThucCa5 },
                { cbbGioBatDauCa6, cbbGioKetThucCa6 },
                { cbbGioBatDauCa7, cbbGioKetThucCa7 }
            };

            for (int i = 0; i < 7; i++)
            {
                comboBoxes[i, 0].Items.AddRange(bll.setSMDangKiCaCBB_GioBatDau().ToArray());
                comboBoxes[i, 1].Items.AddRange(bll.setSMDangKiCaCBB_GioKetThuc().ToArray());

                comboBoxes[i, 0].ValueMember = "Value";
                comboBoxes[i, 0].DisplayMember = "Text";
                comboBoxes[i, 0].SelectedIndex = 0;

                comboBoxes[i, 1].ValueMember = "Value";
                comboBoxes[i, 1].DisplayMember = "Text";
                comboBoxes[i, 1].SelectedIndex = 0;

                comboBoxes[i, 0].SelectedIndexChanged += cbbGioBatDau_SelectedIndexChanged;
                comboBoxes[i, 1].SelectedIndexChanged += cbbGioKetThuc_SelectedIndexChanged;
            }
        }
            private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        private void cbbGioBatDau_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            TimeSpan gioBatDau = ((SMCBBItems_Start_End_Time)cbo.SelectedItem).Text;

            string name = cbo.Name;
            string number = name.Substring(name.Length - 1, 1);
            ComboBox otherCbo = (ComboBox)this.Controls.Find("cbbGioKetThucCa" + number, true)[0];

            otherCbo.SelectedIndex = otherCbo.Items.IndexOf
                (otherCbo.Items.Cast<SMCBBItems_Start_End_Time>().FirstOrDefault(item => item.Text > gioBatDau));
        }

        private void cbbGioKetThuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cbo = (ComboBox)sender;
            TimeSpan gioKetThuc = ((SMCBBItems_Start_End_Time)cbo.SelectedItem).Text;

            string name = cbo.Name;
            string number = name.Substring(name.Length - 1, 1);
            ComboBox otherCbo = (ComboBox)this.Controls.Find("cbbGioBatDauCa" + number, true)[0];

            otherCbo.SelectedIndex = otherCbo.Items.IndexOf
                (otherCbo.Items.Cast<SMCBBItems_Start_End_Time>().LastOrDefault(item => item.Text < gioKetThuc));
        }
        private void dangKiCa(DateTimePicker dtpk, ComboBox cbbgbd, ComboBox cbbgkt)
        {
            try
            {
                DateTime newDT = (DateTime)dtpk.Value;
                SMCBBItems_Start_End_Time selectedGioBatDau = (SMCBBItems_Start_End_Time)cbbgbd.SelectedItem;
                SMCBBItems_Start_End_Time selectedGioKetThuc = (SMCBBItems_Start_End_Time)cbbgkt.SelectedItem;

                TimeSpan newGioBatDau = selectedGioBatDau.Text;
                TimeSpan newGioKetThuc = selectedGioKetThuc.Text;
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
        private void btnDangKi_Click(object sender, EventArgs e)
        {  
           dangKiCa(dtChonNgayLamCa1,cbbGioBatDauCa1,cbbGioKetThucCa1);
            
        }

        private void btnDangKiCa2_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa2, cbbGioBatDauCa2, cbbGioKetThucCa2);
        }

        private void btnDangKiCa3_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa3, cbbGioBatDauCa3, cbbGioKetThucCa3);
        }

        private void btnDangKiCa4_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa4, cbbGioBatDauCa4, cbbGioKetThucCa4);
        }

        private void btnDangKiCa5_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa5, cbbGioBatDauCa5, cbbGioKetThucCa5);
        }

        private void btnDangKiCa6_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa6, cbbGioBatDauCa6, cbbGioKetThucCa6);
        }

        private void btnDangKiCa7_Click(object sender, EventArgs e)
        {
            dangKiCa(dtChonNgayLamCa7, cbbGioBatDauCa7, cbbGioKetThucCa7);
        }
    }
}
