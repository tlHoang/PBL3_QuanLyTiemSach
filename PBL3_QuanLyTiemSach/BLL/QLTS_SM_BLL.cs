using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.BLL
{
    internal class QLTS_SM_BLL
    {
        public string getTenNhanVien(int maNV)
        {
            string tenNV = "";
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                string ten = db.NhanViens.Where(nv => nv.MaNV== maNV).Select(nv => nv.TenNV).FirstOrDefault().ToString();
                tenNV = ten;
            }
            return tenNV;
        }
        public void AddCa(Ca newCa, int maNV)
        {
            DBQuanLyTiemSach db = new DBQuanLyTiemSach();
            CaNV newCaNV = new CaNV();

            newCaNV.MaCa = newCa.MaCa;
            newCaNV.MaNV = maNV;

            db.Cas.Add(newCa);
            db.CaNVs.Add(newCaNV);
            try
            {
                db.SaveChanges();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public DataTable getCaLamTrongNgay()
        {
            DataTable dt = new DataTable();
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Ca> ca = db.Cas.ToList();
                List<NhanVien> nhanVien = db.NhanViens.ToList();
                List<CaNV> caNV = db.CaNVs.ToList();
                //
                // next version Trong này có ca của ai thì hiển thị lên 
                var dataNV = nhanVien.Select(nv => new
                {
                    MaNV = nv.MaNV.ToString(),
                    TenNhanVien = nv.TenNV.ToString(),
                    GioBatDau = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == nv.MaNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                .Select(c => c.GioBatDau).FirstOrDefault(),
                    GioKetThuc = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == nv.MaNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                .Select(c => c.GioKetThuc).FirstOrDefault()

                }).ToList();
                dt.Columns.Add("MaNV");
                dt.Columns.Add("TenNhanVien");
                dt.Columns.Add("GioBatDau");
                dt.Columns.Add("GioKetThuc");
                foreach(var item in dataNV)
                {
                    dt.Rows.Add(item.MaNV,item.TenNhanVien,item.GioBatDau,item.GioKetThuc);
                }
            }
            return dt;
        }

        public List<SMCBBItems_Start_End_Time> setSMDangKiCaCBB_GioBatDau()
        {
            List<SMCBBItems_Start_End_Time> db = new List<SMCBBItems_Start_End_Time>();
            db.AddRange(new SMCBBItems_Start_End_Time[]
            {
                new SMCBBItems_Start_End_Time {Value = 1, Text = new TimeSpan(6,0,0)},
                new SMCBBItems_Start_End_Time {Value = 2, Text = new TimeSpan(14,0,0)},
            });
            return db;
        }
        public List<SMCBBItems_Start_End_Time> setSMDangKiCaCBB_GioKetThuc()
        {
            List<SMCBBItems_Start_End_Time> db = new List<SMCBBItems_Start_End_Time>();
            db.AddRange(new SMCBBItems_Start_End_Time[]
            {
                new SMCBBItems_Start_End_Time {Value = 1, Text = new TimeSpan(14,0,0)},
                new SMCBBItems_Start_End_Time {Value = 2, Text = new TimeSpan(22,0,0)},
            });
            return db;
        }
        public DataTable getCaNhanVien(int maNV)
        {
            DataTable dt = new DataTable();
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var dataView = db.CaNVs
                     .Join(db.Cas, cnv => cnv.MaCa, c => c.MaCa, (cnv, c) => new { cnv, c })
                     .Join(db.NhanViens, canv => canv.cnv.MaNV, nv => nv.MaNV, (canv, nv) => new
                     {
                         ID = nv.MaNV,
                         IDCa = canv.c.MaCa,
                         Ten = nv.TenNV,
                         NgayLam = canv.c.Ngay,
                         GioBatDau = canv.c.GioBatDau,
                         GioKetThuc = canv.c.GioKetThuc
                     })
                     .Where(nv => nv.ID == maNV)
                     .ToList()
                     .Select(llnv => new
                     {
                         IDCa = llnv.IDCa,
                         Ten = llnv.Ten,
                         NgayLam = llnv.NgayLam.ToString("dd/MM/yyyy"),
                         GioBatDau = llnv.GioBatDau,
                         GioKetThuc = llnv.GioKetThuc
                     })
                     .ToList();

                dt.Columns.Add("Mã Ca");
                dt.Columns.Add("Tên");
                dt.Columns.Add("Ngày Làm");
                dt.Columns.Add("Giờ Bắt Đầu");
                dt.Columns.Add("Giờ Kết Thúc");

                foreach (var item in dataView)
                {
                    dt.Rows.Add(item.IDCa, item.Ten, item.NgayLam, item.GioBatDau, item.GioKetThuc);
                }
            }
            return dt;
        }
        public void DeleteCa(int maCa, int maNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                Ca delCa = new Ca();
                CaNV delCaNV = new CaNV();
                delCa = db.Cas.Where(c => c.MaCa == maCa).FirstOrDefault();
                delCaNV = db.CaNVs.Where(cnv => cnv.MaCa == maCa && cnv.MaNV == maNV).FirstOrDefault();

                db.Cas.Remove(delCa);
                db.CaNVs.Remove(delCaNV);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành công");
            }



        }
    }
}
