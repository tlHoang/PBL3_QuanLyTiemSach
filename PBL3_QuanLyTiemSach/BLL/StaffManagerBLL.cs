using PBL3_QuanLyTiemSach.DTO;
using PBL3_QuanLyTiemSach.DTO.CodeFirst;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class StaffManagerBLL
    {
        public List<NhanVien> GetAllStaffList()
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens
                    .Include(p => p.TaiKhoan)
                    .ToList();
            }
        }

        public List<NhanVien> GetSearchStaffList(string searchTxt)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens
                    .Include(p => p.TaiKhoan)
                    .Where(p => p.TenNV.Contains(searchTxt))
                    .ToList();
            }
        }

        public List<NhanVien> GetStaffsByIDs(List<int> IDs)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                var sw = new Stopwatch();
                List<NhanVien> nhanViens = db.NhanViens
                    .Join(IDs, nv => nv.MaNV, li => li, (nv, li) => nv)
                    .Include(p => p.TaiKhoan)
                    .ToList();
                //List<NhanVien> nhanViens = db.NhanViens
                //    .Where(p => IDs.Contains(p.MaNV))
                //    .ToList();
                return nhanViens;
            }
        }

        public List<NhanVien> SortStaff(List<int> IDs, int sortby)
        {
            List<NhanVien> result = new List<NhanVien>();
            result = GetStaffsByIDs(IDs);
            switch (sortby)
            {
                case 0:
                    result = result.OrderBy(p => p.MaNV).ToList(); break;
                case 1:
                    result = result.OrderBy(p => p.TaiKhoan.Username).ToList(); break;
                case 2:
                    result = result.OrderBy(p => p.TenNV).ToList(); break;
            }
            return result;
        }

        public void DeleteStaffs(List<int> IDs)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                db.NhanViens
                    .RemoveRange(db.NhanViens.Where(p => IDs.Contains(p.MaNV)));
                db.TaiKhoans
                    .RemoveRange(db.TaiKhoans.Where(p => IDs.Contains(p.MaNV)));
                db.SaveChanges();
            }
        }

        public bool IsUsernameDuplicate(string Username)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.TaiKhoans
                    .Any(p => p.Username == Username);
            }
        }

        public void AddNewStaff(TaiKhoan account, NhanVien staff)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                db.TaiKhoans
                    .Add(account);
                db.NhanViens
                    .Add(staff);
                db.SaveChanges();
            }
        }

        public void UpdateStaff(NhanVien staff)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                NhanVien UpdateStaff = db.NhanViens
                    .Where(p => p.MaNV == staff.MaNV)
                    .First();

                UpdateStaff.TenNV = staff.TenNV;
                UpdateStaff.GioiTinh = staff.GioiTinh;
                UpdateStaff.NgaySinh = staff.NgaySinh;
                UpdateStaff.DiaChi = staff.DiaChi;
                UpdateStaff.Luong = staff.Luong;
                UpdateStaff.SDT = staff.SDT;

                db.SaveChanges();
            }
        }
    }
}
