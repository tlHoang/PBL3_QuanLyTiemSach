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
    public class AccountBLL
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
                result[i] = givenChars[random.Next(size)]; // random.Next(int a) -> 0..a-1
            }
            return new string(result);
        }

        public string CheckPassword(string username, string password)
        {
            using (DBQuanLyTiemSach db = new DBQuanLyTiemSach())
            {
                Account acc = db.Accounts
                    .Where(p => p.Username == username)
                    .FirstOrDefault();
                if (acc == null)
                    return null;
                if (acc.Password == HashPassword(password, acc.Salt))
                    return acc.MaNV;
                return null;
            }
        }
    }
}
