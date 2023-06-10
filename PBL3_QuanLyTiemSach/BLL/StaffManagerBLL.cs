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
        public List<StaffView> GetAllStaffs()
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens
                    .Where(p => p.Luong >= 0)
                    .Select(p => new StaffView { ID = p.MaNV, Username = p.TaiKhoan.Username, Name = p.TenNV, Salary = p.Luong, PhoneNumber = p.SDT })
                    .ToList();
            }
        }

        public List<StaffView> GetSearchStaffs(string searchTxt)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens
                    .Where(p => p.Luong >= 0 && p.TenNV.Contains(searchTxt))
                    .Select(p => new StaffView { ID = p.MaNV, Username = p.TaiKhoan.Username, Name = p.TenNV, Salary = p.Luong, PhoneNumber = p.SDT })
                    .ToList();
            }
        }

        public List<StaffView> GetStaffsByIDs(List<int> IDs, bool isActive = true)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                if (isActive)
                {
                    return db.NhanViens
                        .Where(p => p.Luong >= 0 && IDs.Contains(p.MaNV))
                        .Select(p => new StaffView { ID = p.MaNV, Username = p.TaiKhoan.Username, Name = p.TenNV, Salary = p.Luong, PhoneNumber = p.SDT })
                        .ToList();
                }
                else
                {
                    return db.NhanViens
                        .Where(p => p.Luong < 0 && IDs.Contains(p.MaNV))
                        .Select(p => new StaffView { ID = p.MaNV, Username = p.TaiKhoan.Username, Name = p.TenNV, Salary = p.Luong * -1, PhoneNumber = p.SDT })
                        .ToList();
                }
            }
        }

        public List<StaffView> SortStaff(List<int> IDs, int sortby, bool isActive = true)
        {
            List<StaffView> result = new List<StaffView>();
            result = GetStaffsByIDs(IDs, isActive);
            switch (sortby)
            {
                case 0:
                    result = result.OrderBy(p => p.Username).ToList(); break;
                case 1:
                    result = result.OrderBy(p => p.Name).ToList(); break;
                case 2:
                    result = result.OrderBy(p => p.Salary).ToList(); break;
            }
            return result;
        }

        public List<string> CheckIfHaveShift(List<int> IDs)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                DateTime today = DateTime.Now.Date;
                return db.CaNVs
                    .Where(p => IDs.Contains(p.MaNV) && p.Ca.Ngay >= today)
                    .Select(p => p.NhanVien.TenNV)
                    .Distinct()
                    .ToList();
            }
        }

        public void InactiveStaffs(List<int> IDs)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                db.NhanViens
                    .Where(p => IDs.Contains(p.MaNV))
                    .ToList()
                    .ForEach(p => p.Luong = p.Luong * -1);
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

        public List<StaffView> GetAllInactiveStaff()
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens
                    .Where(p => p.Luong < 0)
                    .Select(p => new StaffView { ID = p.MaNV, Username = p.TaiKhoan.Username, Name = p.TenNV, Salary = p.Luong * -1, PhoneNumber = p.SDT })
                    .ToList();
            }
        }

        public List<StaffView> GetSearchInactiveStaff(string txt)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens
                    .Where(p => p.Luong < 0 && p.TenNV.Contains(txt))
                    .Select(p => new StaffView { ID = p.MaNV, Username = p.TaiKhoan.Username, Name = p.TenNV, Salary = p.Luong * -1, PhoneNumber = p.SDT })
                    .ToList();
            }
        }
    }
}
