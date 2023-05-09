using PBL3_QuanLyTiemSach.DTO.CodeFirst;
using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBL3_QuanLyTiemSach
{
    public class CreateDB
        //: CreateDatabaseIfNotExists<DBQuanLyTiemSach>
        : DropCreateDatabaseAlways<DBQuanLyTiemSach>
    {
        protected override void Seed(DBQuanLyTiemSach context)
        {
            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan { MaNV = -2, Username = "admin", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = 2, Username = "nhanvien1", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = 3, Username = "nhanvien2", Password = "87089c1da28a685648a603452fecaaa6bca8ef651861b9b5c512e81ff576a456", Salt = "WMAbPKk73KUh" },
            });
            context.NhanViens.AddRange(new NhanVien[]
            {
                new NhanVien { MaNV = 2, TenNV = "Lê Ngọc Hạnh", GioiTinh = true, NgaySinh = new DateTime(2003,4,6), DiaChi = "Đà Nẵng", Luong = 20000000, SDT = "0123654789"},
                new NhanVien { MaNV = 3, TenNV = "Trần Lê Huy Hoàng", GioiTinh = true, NgaySinh = new DateTime(2003,3,2), DiaChi = "Đà Nẵng", Luong = 30000000, SDT = "0147852369"}
            });
            context.SachTheLoais.AddRange(new SachTheLoai[]
            {
                new SachTheLoai { TenTheLoai ="Trinh Thám" },
                new SachTheLoai { TenTheLoai ="Tiểu Thuyết" },
                new SachTheLoai { TenTheLoai ="Cấp 3 " },
                new SachTheLoai { TenTheLoai ="Ngôn Tình" },
                new SachTheLoai { TenTheLoai ="Ngụ Ngôn" },
                //new SachTheLoai{ MaTheLoai = "", TenTheLoai ="" },
            });
            context.DonViCungCaps.AddRange(new DonViCungCap[]
            {
                new DonViCungCap { TenDV = "Don Vi A" },
                new DonViCungCap { TenDV = "Don Vi B" },
                new DonViCungCap { TenDV = "Don Vi C" },
                new DonViCungCap { TenDV = "Don Vi D" }
            });
            //context.Sachs.AddRange(new Sach[]
            //{
            //    new Sach { TenSach = "Duy Tân", TacGia = "Huy Cận", MaTheLoai = 1, GiaBan =50000},
            //    new Sach { TenSach = "Đạt Ma Thích Ca", TacGia = "Tú Mỡ", MaTheLoai = 2, GiaBan = 60000},
            //    new Sach { TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai = 3, GiaBan = 65000},
            //    new Sach { TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai = 3, GiaBan = 65000},
            //    new Sach { TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai = 3, GiaBan = 65000},
            //    new Sach { TenSach = "Ngủ Trong Nhà", TacGia = "Pep Quardiorla", MaTheLoai = 1, GiaBan = 50000},
            //    new Sach { TenSach = "Tây Du Kí", TacGia = "Ngô Thừa Ân", MaTheLoai = 4, GiaBan = 620000},
            //    new Sach { TenSach = "Cô Gái Quàng Khăn Đỏ", TacGia = "Erik ten Hag", MaTheLoai = 5, GiaBan = 100000},
            //    //new Sach {MaSach ="", MaKho ="", TenSach = "", TacGia = "", MaTheLoai ="", GiaBan =},
            //});
        }
    }
}