using ComponentFactory.Krypton.Toolkit;
using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Data.Entity.Spatial;
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
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var role = db.TaiKhoans.FirstOrDefault(tk => tk.MaNV == maNV).Username;
                string ten;
                if (role == UserRole)
                {
                    ten = "Admin";
                }
                else
                {
                    ten = db.NhanViens.Where(nv => nv.MaNV == maNV).Select(nv => nv.TenNV).FirstOrDefault().ToString();
                }
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
        public bool IsDuplicateCa(DateTime day, TimeSpan gbd, int maNV)
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
                return dataNV.Any(nv => nv.NgayLam.Date == day
                                    && nv.IDNV == maNV
                                    && nv.GioBatDau == gbd) ? true : false;
            }
        }
        public bool isFull(Ca CurrentCa)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                int stoneCount = 2;
                if (isHasExist(CurrentCa))
                {
                    Ca oldCa = getCa(CurrentCa);
                    int CaDuration = db.CaNVs.Count(cnv => cnv.MaCa == oldCa.MaCa);
                    return (CaDuration >= stoneCount) ? true : false;
                }
                else
                {
                    return false;
                }

            }
        }
        public int getSoLuongNhanVienTrongCa(int MaCa)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                if (isHasExist(MaCa))
                {
                    int CaDuration = db.CaNVs.Count(cnv => cnv.MaCa == MaCa);
                    return CaDuration;
                }
                else
                {
                    return 0;
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
        public bool isHasExist(DateTime day, TimeSpan gbd, TimeSpan gkt)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Cas.Any(c =>
                    c.GioBatDau == gbd &&
                    c.GioKetThuc == gkt &&
                    DbFunctions.TruncateTime(c.Ngay) == day
                );
            }
        }
        public bool isHasExist(int maCa)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Cas.Any(c => c.MaCa == maCa);                
                
            }
        }
        public bool isValidDay(DateTime dayValid)
        {
            int stone = 2;
            DateTime dateNow = DateTime.Now.Date;
            int daysDiff = (int)(dayValid - dateNow).TotalDays;
            return ( daysDiff >= stone) ? true : false;
        }
        public bool isValidDay(int maCa)
        {
            int stone = 2;
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                DateTime dateNow = DateTime.Now.Date;
                DateTime? dayValid = db.Cas.Where(c => c.MaCa == maCa).FirstOrDefault().Ngay;
                int daysDiff = (int)(dayValid.Value - dateNow).TotalDays;
                return (daysDiff >= stone) ? true : false;
            }
        }
        public Ca getCa(Ca currentCa)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Cas.FirstOrDefault(c => c.GioBatDau == currentCa.GioBatDau
                                    && c.GioKetThuc == currentCa.GioKetThuc
                                    && DbFunctions.TruncateTime(c.Ngay) == DbFunctions.TruncateTime(currentCa.Ngay));
            }
        }
        public Ca getCa(DateTime day, TimeSpan gbd, TimeSpan gkt)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                if (isHasExist(day,gbd,gkt))
                {
                    return db.Cas.FirstOrDefault(c => c.GioBatDau == gbd
                                                        && c.GioKetThuc == gkt
                                                        && DbFunctions.TruncateTime(c.Ngay) == day);
                }
                else
                {
                    return null;
                }
            }
        }
        public bool checkDayExist(DateTime? day)
        {
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.Cas.FirstOrDefault(c => DbFunctions.TruncateTime(c.Ngay) == day) != null;
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
        public DataTable getDataCaLamTrongNgay(DateTime ngayLam)
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
                foreach (var item in dataNV)
                {
                    dt.Rows.Add(item.MaNV, item.TenNhanVien, item.GioBatDau, item.GioKetThuc);
                }
            }
            return dt;
        }

        public List<SMCBBItems_Start_End_Time> getValueCBBCa()
        {
            List<SMCBBItems_Start_End_Time> list = new List<SMCBBItems_Start_End_Time>();
            list.AddRange(new SMCBBItems_Start_End_Time[]
            {
                new SMCBBItems_Start_End_Time { TenCa = "Ca 1", GioBatDau = new TimeSpan(6,0,0), GioKetThuc = new TimeSpan(14,0,0),},
                new SMCBBItems_Start_End_Time { TenCa = "Ca 2", GioBatDau = new TimeSpan(14,0,0), GioKetThuc = new TimeSpan(22,0,0),}
            });
            return list;
        }
        public SMCBBItems_Start_End_Time getCaByGioBatDau(TimeSpan time)
        {
            List<SMCBBItems_Start_End_Time> list = getValueCBBCa();
            SMCBBItems_Start_End_Time res = new SMCBBItems_Start_End_Time();
            foreach(var item in list)
            {
                if(item.GioBatDau == time)
                {
                    res = item;
                    break;
                }
            }
            return res;
        }
        public DataTable getDataCaLamNhanVien(int maNV, string mode)
        {
            DataTable dt = new DataTable();
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                DateTime dateNow = DateTime.Now.Date;
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
                                .Where(nv => nv.ID == maNV);
                
                if (mode == "Future")
                {
                    dataView = dataView.Where(p => p.NgayLam >= dateNow);
                }
                else if( mode == "Past")
                {
                    dataView = dataView.Where(p => p.NgayLam < dateNow);
                }
                var FinalData = dataView.Select(llnv => new
                                    {
                                     IDCa = llnv.IDCa,
                                     Ten = llnv.Ten,
                                     NgayLam = llnv.NgayLam,
                                     GioBatDau = llnv.GioBatDau,
                                     GioKetThuc = llnv.GioKetThuc
                                 }).ToList();
                dt.Columns.Add("MaCa");
                dt.Columns.Add("Tên");
                dt.Columns.Add("Ngày Làm");
                dt.Columns.Add("Giờ Bắt Đầu");
                dt.Columns.Add("Giờ Kết Thúc");

                foreach (var item in FinalData)
                {
                    dt.Rows.Add(item.IDCa, item.Ten, item.NgayLam.ToString("dd/MM/yyyy"), item.GioBatDau, item.GioKetThuc);
                }
            }
            return dt;
        }
        public DataTable getDataStaffByIDShift(int maCa)
        {
            DataTable dt = new DataTable();
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
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
                                .Where(ca => ca.IDCa == maCa)
                                .Select(nv => new
                                {
                                    ID = nv.ID,
                                    Ten = nv.Ten
                                });
                dt.Columns.Add("Mã Nhân Viên");
                dt.Columns.Add("Tên Nhân Viên");
                foreach(var nv in dataView)
                {
                    dt.Rows.Add(nv.ID, nv.Ten);
                }
            }
            return dt;
        }
        public DataTable getAdminDataCaLam(string mode)
        {
            DataTable dt = new DataTable();
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                DateTime dateNow = DateTime.Now.Date;
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
                                });
                if(mode == "Future")
                {
                    dataView = dataView.Where(p => p.NgayLam >= dateNow);
                }
                else if(mode == "Past")
                {
                    dataView = dataView.Where(p => p.NgayLam < dateNow);
                }
                var FinalData = dataView.Select(ca => new
                                {
                                    MaCa = ca.IDCa,
                                    NgayLam = ca.NgayLam,
                                    GioBatDau = ca.GioBatDau,
                                    GioKetThuc = ca.GioKetThuc
                                });
                dt.Columns.Add("MaCa");
                dt.Columns.Add("SLNV");
                dt.Columns.Add("NgayLam");
                dt.Columns.Add("GBD");
                dt.Columns.Add("GKT");
                foreach (var item in FinalData)
                {
                    dt.Rows.Add(item.MaCa,getSoLuongNhanVienTrongCa(item.MaCa),item.NgayLam.ToString("dd/MM/yyyy"),item.GioBatDau, item.GioKetThuc);
                }
            }
            return dt;
        }
        public void setCheckBox(KryptonCheckBox cB, DateTime day, KryptonComboBox cbb,int MaNV)
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
        public void setLabelSLNV(KryptonLabel lb, DateTime day, KryptonComboBox cbb)
        {
            try
            {
                QLTS_SM_BLL bll = new QLTS_SM_BLL();
                SMCBBItems_Start_End_Time selectedCa = (SMCBBItems_Start_End_Time)cbb.SelectedItem;
                TimeSpan gbd = selectedCa.GioBatDau;
                TimeSpan gkt = selectedCa.GioKetThuc;

                Ca ca = bll.getCa(day, gbd, gkt);
                if (ca != null)
                {
                    int maCa = ca.MaCa;
                    int SL = bll.getSoLuongNhanVienTrongCa(maCa);
                    lb.Text = $"{SL}/2";
                }
                else
                {
                    lb.Text = "0/2";
                }
            }
            catch (Exception ex)
            {
                KryptonMessageBox.Show(ex.Message);
            }
        }
        public void DeleteCa(int maCa,int adminID , int maNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                if (IsAdmin(adminID))
                {
                    Ca delCa = new Ca();
                    CaNV delCaNV = new CaNV();
                    delCa = db.Cas.Where(c => c.MaCa == maCa).FirstOrDefault();
                    delCaNV = db.CaNVs.Where(cnv => cnv.MaCa == maCa && cnv.MaNV == maNV).FirstOrDefault();

                    db.CaNVs.Remove(delCaNV);
                    db.SaveChanges();
                    KryptonMessageBox.Show("Xóa Thành công");
                }
                else
                {
                    Ca delCa = new Ca();
                    CaNV delCaNV = new CaNV();
                    if (maCa != 0)
                    {
                        if (isValidDay(maCa))
                        {
                            delCa = db.Cas.Where(c => c.MaCa == maCa).FirstOrDefault();
                            delCaNV = db.CaNVs.Where(cnv => cnv.MaCa == maCa && cnv.MaNV == maNV).FirstOrDefault();

                            db.CaNVs.Remove(delCaNV);
                            db.SaveChanges();
                            KryptonMessageBox.Show("Xóa Thành công");
                        }
                        else
                        {
                            KryptonMessageBox.Show("Không thể Xóa Ca Làm Này khi 2 ngày nữa là đến Ca làm \n" +
                                            "hoặc Ca đã làm");
                        }
                    }
                    else
                    {
                        KryptonMessageBox.Show("Không tìm thấy Ca làm có mã" + maCa);
                    }
                }
                
            }
        }
        public void UpdateCa(Ca newCa, int maNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                CaNV newCaNV = new CaNV();
                CaNV oldCaNV = db.CaNVs.FirstOrDefault(cnv => cnv.MaCa == newCa.MaCa && cnv.MaNV == maNV);
                db.CaNVs.Remove(oldCaNV);
                if (isHasExist(newCa))
                {

                    newCaNV.MaCa = getCa(newCa).MaCa;
                    newCaNV.MaNV = maNV;
                    db.CaNVs.AddOrUpdate(newCaNV);
                }
                else
                {
                    newCaNV.MaCa = newCa.MaCa;
                    newCaNV.MaNV = maNV;
                    db.CaNVs.AddOrUpdate(newCaNV);
                    db.Cas.AddOrUpdate(newCa);
                }
                try
                {
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    KryptonMessageBox.Show(ex.ToString());
                }
            }
        }
        
    }
}
