using PBL3_QuanLyTiemSach.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.View.BillUI
{
    public partial class Bill_Info : MetroFramework.Forms.MetroForm
    {
        public Bill_Info(List<string> li)
        {
            InitializeComponent();

            checkLoaiHD(li[0], li[4]);
            label_MaHD.Text = li[1];
            label_Date.Text = li[2];
            label_NV.Text = li[3];
            label_KH_DVCC_Detail.Text = li[4];

            loadDGV(label_Type.Text, Convert.ToInt32(li[1]));
            label_Total.Text = Convert.ToDouble(li[5]).ToString("N0", CultureInfo.GetCultureInfo("vi-VN")) + " đ";
        }
        private void checkLoaiHD(string LoaiHD, string TenKH)
        {
            if(LoaiHD == "True")
            {
                label_Type.Text = "Hóa đơn nhập";
                label_KH_DVCC.Text = "Tên ĐVCC:";
                label_SDT.Visible = false;
                label_SDT_Detail.Visible = false;
            }
            else
            {
                label_Type.Text = "Hóa đơn bán hàng";
                label_KH_DVCC.Text = "Tên KH:";
                label_SDT.Visible = true;
                label_SDT_Detail.Visible = true;
                BillBLL bll = new BillBLL();
                label_SDT_Detail.Text = bll.getSDTfromTenKH(TenKH);
            }
        }
        public void loadDGV(string LoaiHD, int MaHD)
        {
            if (LoaiHD == "Hóa đơn nhập")
            {
                BillBLL bll = new BillBLL();
                dgvSach.DataSource = bll.getHDNSfromMaHDN(MaHD)
                    .Select(p => new
                    {
                        TenSach = bll.getTenSachfromMaSach(p.MaSach),
                        GiaNhap = p.DonGiaNhap,
                        SL = p.SoLuongNhap
                    }).ToList();
                dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
                dgvSach.Columns["GiaNhap"].HeaderText = "Giá nhập";
                dgvSach.Columns["SL"].HeaderText = "Số lượng";
                dgvSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            else
            {
                BillBLL bll = new BillBLL();
                dgvSach.DataSource = bll.getHDBSfromMaHDB(MaHD)
                    .Select(p => new
                    {
                        TenSach = bll.getTenSachfromMaSach(p.MaSach),
                        GiaBan = p.DonGiaBan,
                        SL = p.SoLuongBan
                    }).ToList();
                dgvSach.Columns["TenSach"].HeaderText = "Tên sách";
                dgvSach.Columns["GiaBan"].HeaderText = "Giá bán";
                dgvSach.Columns["Sl"].HeaderText = "Số lượng";
                dgvSach.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
        }
    }
}
