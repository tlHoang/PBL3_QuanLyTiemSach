using PBL3_QuanLyTiemSach.DTO.CodeFirst;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL3_QuanLyTiemSach.BLL
{
    public class TaiKhoanBLL
    {
        public string HashPassword(string pass, string salt)
        {
            using (SHA256 hash = SHA256.Create())
            {
                byte[] hashedBytes = hash.ComputeHash(Encoding.UTF8.GetBytes(pass + salt));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in hashedBytes) sb.Append(b.ToString("x2")); // x2 de chuyen thanh thap luc phan 2 ky tu
                return sb.ToString();
                // return Convert.ToHexString(hashedBytes).ToLower();
            }
        }

        public string RandomString(int size)
        {
            string givenChars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            char[] result = new char[size];
            Random random = new Random();
            for (int i = 0; i < size; i++)
            {
                result[i] = givenChars[random.Next(givenChars.Length)]; // random.Next(int a) -> 0..a-1
            }
            return new string(result);
        }

        public int CheckPassword(string username, string password)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                TaiKhoan acc = db.TaiKhoans
                    .Where(p => p.Username == username)
                    .FirstOrDefault();
                if (acc == default)
                    return -1;
                else if (acc.Password == HashPassword(password, acc.Salt))
                    return acc.MaNV;
                return -1;
            }
        }

        public void UpdatePassword(string username, string password)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                string newSalt = RandomString(12);
                TaiKhoan taiKhoan = db.TaiKhoans
                    .Where(p => p.Username == username)
                    .FirstOrDefault();
                taiKhoan.Salt = newSalt;
                taiKhoan.Password = HashPassword(password, newSalt);
                db.SaveChanges();
            }
        }

        public string getNameFromMaNV(int MaNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens.Where(p => p.MaNV == MaNV).FirstOrDefault().TenNV;
            }
        }

        public bool getGioiTinh(int MaNV)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                return db.NhanViens.Where(p => p.MaNV == MaNV).FirstOrDefault().GioiTinh;
            }
        }
    }
}
