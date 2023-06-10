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
         : CreateDatabaseIfNotExists<DBQuanLyTiemSach>
         //: DropCreateDatabaseAlways<DBQuanLyTiemSach>
         //:DropCreateDatabaseIfModelChanges<DBQuanLyTiemSach>
    {
        protected override void Seed(DBQuanLyTiemSach context)
        {
            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan { MaNV = -2, Username = "admin", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = 1, Username = "nhanvien0", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = 2, Username = "nhanvien1", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = 3, Username = "nhanvien2", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = 4, Username = "nhanvien3", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
            });
            context.NhanViens.AddRange(new NhanVien[]
            {
                new NhanVien { MaNV = 1, TenNV = "Nguyễn Thị Mốt", GioiTinh = false, NgaySinh = Convert.ToDateTime("2003-03-02"), DiaChi = "40 Trần Cao Vân, Thanh Khê, Đà Nẵng", Luong = 14000.0, SDT = "0123456789"},
                new NhanVien { MaNV = 2, TenNV = "Lê Ngọc Hạnh", GioiTinh = true, NgaySinh = new DateTime(2003,4,6), DiaChi = "48 Ngô Sĩ Liên, Liên Chiểu, Đà Nẵng", Luong = 15000, SDT = "0123654789"},
                new NhanVien { MaNV = 3, TenNV = "Trần Lê Huy Hoàng", GioiTinh = true, NgaySinh = new DateTime(2003,3,9), DiaChi = "70 Bạch Đằng, Hải Châu, Đà Nẵng", Luong = 14500, SDT = "0147852369"},
                new NhanVien { MaNV = 4, TenNV = "Lê Trung Tấn Phát", GioiTinh = true, NgaySinh = new DateTime(2003,6,5), DiaChi = "800 Tôn Đức Thắng, Liên Chiểu, Đà Nẵng", Luong = 16000, SDT = "0147852369"}
            });
            //context.Cas.AddRange(new Ca[]
            //{
            //    new Ca {MaCa = 1, Ngay = new DateTime(2023, 5, 5), GioBatDau = new TimeSpan (8,0,0), GioKetThuc = new TimeSpan(17,0,0) },
            //    new Ca {MaCa = 2, Ngay = new DateTime(2023, 5, 6), GioBatDau = new TimeSpan(8,0,0), GioKetThuc = new TimeSpan(17,0,0) },
            //    new Ca {MaCa = 3, Ngay = new DateTime(2023, 5, 7), GioBatDau = new TimeSpan(8,0,0), GioKetThuc = new TimeSpan(17,0,0) }
               // new Ca {MaCa = "", Ngay = new DateTime(, , ), GioBatDau = new TimeSpan(,,), GioKetThuc = new TimeSpan(,,) },
            //});
            //context.CaNVs.AddRange(new CaNV[]
            //{
            //    new CaNV {MaCaNV = 1, MaCa = 1, MaNV= 2},
            //    new CaNV {MaCaNV = 2, MaCa = 2, MaNV= 3}
            //});
            context.SachTheLoais.AddRange(new SachTheLoai[]
            {
                new SachTheLoai { MaTheLoai = 1, TenTheLoai ="Trinh Thám" },
                new SachTheLoai { MaTheLoai = 2, TenTheLoai ="Tiểu Thuyết" },
                new SachTheLoai { MaTheLoai = 3, TenTheLoai ="Cấp 3" },
                new SachTheLoai { MaTheLoai = 4, TenTheLoai ="Ngôn Tình" },
                new SachTheLoai { MaTheLoai = 5, TenTheLoai ="Ngụ Ngôn" },
                new SachTheLoai { MaTheLoai = 6, TenTheLoai ="Kinh dị" },
                new SachTheLoai { MaTheLoai = 7, TenTheLoai ="Kinh tế" },
                new SachTheLoai { MaTheLoai = 8, TenTheLoai ="Giáo khoa" },
                new SachTheLoai { MaTheLoai = 9, TenTheLoai ="Cổ tích" },
                //new SachTheLoai{ MaTheLoai = "", TenTheLoai ="" },
            });
            //context.KhachHangs.AddRange(new KhachHang[]
            //{
            //    new KhachHang { TenKH = "Khach Hang 1", SDT = "0123456789" },
            //    new KhachHang { TenKH = "Khach Hang 2", SDT = "0223456789" },
            //    new KhachHang { TenKH = "Khach Hang 3", SDT = "0323456789" },
            //    new KhachHang { TenKH = "Khach Hang 4", SDT = "0423456789" },
            //});
            context.DonViCungCaps.AddRange(new DonViCungCap[]
            {
                new DonViCungCap { TenDV = "CTY TNHH Đăng Nguyên" },
                new DonViCungCap { TenDV = "CTY TNHH Văn Hóa Việt Long" },
                new DonViCungCap { TenDV = "CTY Cổ Phần Sách Mcbooks" },
                new DonViCungCap { TenDV = "Nhà Sách Nguyễn Du" }
            });
            //context.Sachs.AddRange(new Sach[]
            //{
            //    new Sach { MaSach = 1, TenSach = "Sach A", TacGia = "Tac gia A", SoLuongConLai = 100, GiaBan = 22000, MaTheLoai = 1 },
            //    new Sach { MaSach = 2, TenSach = "Sach B", TacGia = "Tac gia B", SoLuongConLai = 140, GiaBan = 26000, MaTheLoai = 2 },
            //});
            // context.Sachs.AddRange(new Sach[]
            //{
            //    new Sach {MaSach =1, TenSach = "Duy Tân", TacGia = "Huy Cận", MaTheLoai =1, GiaBan =50000, SoLuongConLai = 600},
            //    new Sach {MaSach =2, TenSach = "Đạt Ma Thích Ca", TacGia = "Tú Mỡ", MaTheLoai =2, GiaBan =60000, SoLuongConLai = 700},
            //    new Sach {MaSach =3, TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai =3, GiaBan =65000, SoLuongConLai = 900},
            //    new Sach {MaSach =6, TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai =3, GiaBan =65000, SoLuongConLai = 600},
            //    new Sach {MaSach =7, TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai =3, GiaBan =65000, SoLuongConLai = 543},
            //    new Sach {MaSach =8, TenSach = "Ngủ Trong Nhà", TacGia = "Pep Quardiorla", MaTheLoai =1, GiaBan =50000, SoLuongConLai = 633},
            //    new Sach {MaSach =4, TenSach = "Tây Du Kí", TacGia = "Ngô Thừa Ân", MaTheLoai =4, GiaBan =620000, SoLuongConLai = 234},
            //    new Sach {MaSach =5, TenSach = "Cô Gái Quàng Khăn Đỏ", TacGia = "Erik ten Hag", MaTheLoai =5, GiaBan =100000, SoLuongConLai =1234}
            //    //new Sach {MaSach ="", MaKho ="", TenSach = "", TacGia = "", MaTheLoai ="", GiaBan =},
            //});
        }
    }
}