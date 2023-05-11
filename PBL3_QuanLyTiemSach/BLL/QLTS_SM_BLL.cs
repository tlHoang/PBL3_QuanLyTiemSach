using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.BLL
{
    internal class QLTS_SM_BLL
    {
        private const string UserRole = "admin";
        public bool IsAdmin(int maNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                string role = db.TaiKhoans
                       .Where(p => p.MaNV == maNV)
                       .Select(p => p.Username)
                       .SingleOrDefault();
                       
                return role == UserRole;
            }        
        }
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
        public bool IsDuplicateCa(Ca CaValided, int maNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var dataNV = db.CaNVs
                                .Join(db.Cas, cnv => cnv.MaCa, c => c.MaCa, (cnv, c) => new { cnv, c })
                                .Join(db.NhanViens, canv => canv.cnv.MaNV, nv => nv.MaNV, (canv, nv) => new
                                {
                                    IDNV = nv.MaNV,
                                    IDCa = canv.c.MaCa,
                                    Ten = nv.TenNV,
                                    NgayLam = canv.c.Ngay,
                                    GioBatDau = canv.c.GioBatDau,
                                    GioKetThuc = canv.c.GioKetThuc
                                }).ToList();
                return dataNV.Any(nv => nv.NgayLam.Date == CaValided.Ngay.Date
                                    && nv.IDNV == maNV
                                    && nv.GioBatDau == CaValided.GioBatDau) ? true : false;
            }
        }
        public bool isFull(Ca CurrentCa)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                int stoneCount = 2;
                if(isHasExist(CurrentCa))
                {
                    Ca oldCa = getCa(CurrentCa);
                    int CaDuration = db.CaNVs.Count(cnv => cnv.MaCa == oldCa.MaCa);
                    return (CaDuration >= stoneCount)? true: false;
                }
                else
                {
                    return false;
                }
                
            }
        }
        public bool isHasExist(Ca currentCa)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Cas.Any(c =>
                    c.GioBatDau == currentCa.GioBatDau &&
                    c.GioKetThuc == currentCa.GioKetThuc &&
                    DbFunctions.TruncateTime(c.Ngay) == DbFunctions.TruncateTime(currentCa.Ngay)
                );
            }
        }

        public Ca getCa(Ca currentCa)
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Cas.FirstOrDefault(c => c.GioBatDau == currentCa.GioBatDau
                                    && c.GioKetThuc == currentCa.GioKetThuc
                                    && DbFunctions.TruncateTime(c.Ngay) == DbFunctions.TruncateTime(currentCa.Ngay));
            }
        }
        public void AddCa(Ca newCa, int maNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                CaNV newCaNV = new CaNV();
                
                if (isHasExist(newCa))
                {
                    newCaNV.MaCa = getCa(newCa).MaCa;
                    newCaNV.MaNV = maNV;
                    db.CaNVs.Add(newCaNV);
                }
                else
                {
                    newCaNV.MaCa = newCa.MaCa;
                    newCaNV.MaNV = maNV;
                    db.Cas.Add(newCa);
                    db.CaNVs.Add(newCaNV);
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
        }
        public DataTable getCaLamTrongNgay(DateTime ngayLam)
        {
            DataTable dt = new DataTable();
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var dataNV = db.CaNVs
                                .Join(db.Cas, cnv => cnv.MaCa, c => c.MaCa, (cnv, c) => new { cnv, c })
                                .Join(db.NhanViens, canv => canv.cnv.MaNV, nv => nv.MaNV, (canv, nv) => new
                                {
                                    IDNV = nv.MaNV,
                                    IDCa = canv.c.MaCa,
                                    Ten = nv.TenNV,
                                    NgayLam = canv.c.Ngay,
                                    GioBatDau = canv.c.GioBatDau,
                                    GioKetThuc = canv.c.GioKetThuc
                                }).ToList()
                                .Where(nv => nv.NgayLam.Date == ngayLam.Date)
                                .Select(nv => new
                                {
                                    MaNV = nv.IDNV,
                                    TenNhanVien = nv.Ten,
                                    GioBatDau = nv.GioBatDau,
                                    GioKetThuc = nv.GioKetThuc,
                                });
               
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
                                }).ToList();
                if (IsAdmin(maNV))
                {
                    dataView = dataView.ToList();
                }
                else
                {
                    dataView = dataView.Where(nv => nv.ID == maNV).ToList();
                }
                var finalData = dataView
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

                foreach (var item in finalData)
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
                
                DateTime datenow = DateTime.Now.Date;
                DateTime delTime = Convert.ToDateTime(db.Cas.Where(c => c.MaCa == maCa).Select(c => DbFunctions.TruncateTime(c.Ngay)));
                
                if((datenow - delTime) >= 2)
                {

                }
                delCa = db.Cas.Where(c => c.MaCa == maCa).FirstOrDefault();
                delCaNV = db.CaNVs.Where(cnv => cnv.MaCa == maCa && cnv.MaNV == maNV).FirstOrDefault();

                //db.Cas.Remove(delCa);
                db.CaNVs.Remove(delCaNV);
                db.SaveChanges();
                MessageBox.Show("Xóa Thành công");
            }
        }
    }
}
