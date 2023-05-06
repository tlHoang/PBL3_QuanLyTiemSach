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
    internal class QLTS_BLL
    {
       /* public List<> SetBookInfoDgvData
        {

        }*/
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
            catch(Exception ex)
            {
                    MessageBox.Show(ex.Message);
            }
  
            
       }
       public List<SMCBBItems_Start_End_Time>  setSMDangKiCaCBB_GioBatDau()
       {
            List<SMCBBItems_Start_End_Time> db = new List<SMCBBItems_Start_End_Time>();
            db.AddRange(new SMCBBItems_Start_End_Time[]
            {
                new SMCBBItems_Start_End_Time {Value = 1, Text = new TimeSpan(6,0,0)},
                new SMCBBItems_Start_End_Time {Value = 2, Text = new TimeSpan(14,0,0)},
            }) ;
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
            using(DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                List<Ca> ca = db.Cas.ToList();
                List<CaNV> caNV = db.CaNVs.ToList();
                List<NhanVien> nhanVien = db.NhanViens.ToList();
                var dataView = nhanVien.Where(nv => nv.MaNV == maNV).
                    Select(nv => new 
                    {
                        ID = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == maNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                    .Select(c => c.MaCa).FirstOrDefault(),
                        Ten = nv.TenNV,
                        NgayLam = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == maNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                    .Select(c => c.Ngay.ToString("dd/MM/yyyy")).FirstOrDefault(),
                        GioBatDau = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == maNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                    .Select(c => c.GioBatDau).FirstOrDefault(),
                        GioKetThuc = ca.Where(c => c.MaCa == caNV.Where(cnv => cnv.MaNV == maNV).Select(cnv => cnv.MaCa).FirstOrDefault())
                                    .Select(c => c.GioKetThuc).FirstOrDefault(),
                    }) ;
                dt.Columns.Add("ID");
                dt.Columns.Add("Tên");
                dt.Columns.Add("Ngày Làm");
                dt.Columns.Add("Giờ Bắt Đầu");
                dt.Columns.Add("Giờ Kết Thúc");

                foreach(var item in dataView)
                {
                    dt.Rows.Add(item.ID,item.Ten,item.NgayLam, item.GioBatDau, item.GioKetThuc);
                }
            }
            return dt;
        }
        public void DeleteCa(int id)
        {

        }
    }      
}
