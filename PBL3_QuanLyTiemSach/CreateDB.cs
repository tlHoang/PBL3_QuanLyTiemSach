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
        :DropCreateDatabaseAlways<DBQuanLyTiemSach>
    {
        protected override void Seed(DBQuanLyTiemSach context)
        {
            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan { MaNV = 0, Username = "admin", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = 1, Username = "nv3", Password = "f4039dd867feb007a8a1f0ef934a720fbcbab0bbb30ced0e7290fba592fee9c0", Salt = "cAPfg5Qa0e6h" },
                new TaiKhoan { MaNV = 2, Username = "nv1", Password = "87089c1da28a685648a603452fecaaa6bca8ef651861b9b5c512e81ff576a456", Salt = "WMAbPKk73KUh" },
                new TaiKhoan { MaNV = 3, Username = "nv2", Password = "87089c1da28a685648a603452fecaaa6bca8ef651861b9b5c512e81ff576a456", Salt = "WMAbPKk73KUh" }
            });
            context.NhanViens.AddRange(new NhanVien[]
            {
                new NhanVien { MaNV = 0, TenNV = "Nguyễn Văn A", GioiTinh = true, NgaySinh = Convert.ToDateTime("2003-03-02"), DiaChi = "Đà Nẵng, Việt Nam", Luong = 100000.0, SDT = "0123456789"},
                new NhanVien { MaNV = 1, TenNV = "Nguyễn Thị B", GioiTinh = false, NgaySinh = Convert.ToDateTime("2004-12-30"), DiaChi = "Đà Nẵng, Việt Nam", Luong = 150000.0, SDT = "0912345678"},
                new NhanVien { MaNV = 2, TenNV = "Trần Thị B", GioiTinh = false, NgaySinh = Convert.ToDateTime("2004-01-01"), DiaChi = "Huế, Việt Nam", Luong = 150000.0, SDT = "0914569978"},
            });
            /*
            context.Sachs.AddRange(new Sach[]
            {
                new Sach {MaSach ="1", MaKho ="1", TenSach = "Duy Tân", TacGia = "Huy Cận", MaTheLoai ="1", GiaBan =50000},
                new Sach {MaSach ="2", MaKho ="2", TenSach = "Đạt Ma Thích Ca", TacGia = "Tú Mỡ", MaTheLoai ="2", GiaBan =60000},
                new Sach {MaSach ="3", MaKho ="3", TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai ="3", GiaBan =65000},
                new Sach {MaSach ="6", MaKho ="3", TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai ="3", GiaBan =65000},
                new Sach {MaSach ="7", MaKho ="3", TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai ="3", GiaBan =65000},
                new Sach {MaSach ="8", MaKho ="6", TenSach = "Ngủ Trong Nhà", TacGia = "Pep Quardiorla", MaTheLoai ="1", GiaBan =50000},
                new Sach {MaSach ="4", MaKho ="4", TenSach = "Tây Du Kí", TacGia = "Ngô Thừa Ân", MaTheLoai ="4", GiaBan =620000},
                new Sach {MaSach ="5", MaKho ="5", TenSach = "Cô Gái Quàng Khăn Đỏ", TacGia = "Erik ten Hag", MaTheLoai ="5", GiaBan =100000},
                //new Sach {MaSach ="", MaKho ="", TenSach = "", TacGia = "", MaTheLoai ="", GiaBan =},
            });
            context.Khos.AddRange(new Kho[] 
            {
                new Kho{ MaKho = "1", TenSach = "Duy Tân", SoLuongSachConLai = 100},
                new Kho{ MaKho = "2", TenSach = "Đạt Ma Thích Ca", SoLuongSachConLai = 100},
                new Kho{ MaKho = "3", TenSach = "John Wick", SoLuongSachConLai = 100},
                new Kho{ MaKho = "4", TenSach = "Tây Du Kí", SoLuongSachConLai = 100},
                new Kho{ MaKho = "5", TenSach = "Cô gái quàng khăn đỏ", SoLuongSachConLai = 100},
                new Kho{ MaKho = "6", TenSach = "Ngủ Trong Nhà", SoLuongSachConLai = 9000},
                //new Kho{ MaKho = "", TenSach = "", SoLuongSachConLai = },

            });
            context.SachTheLoais.AddRange(new SachTheLoai[] 
            {
                new SachTheLoai{ MaTheLoai = "1", TenTheLoai ="Trinh Thám" },
                new SachTheLoai{ MaTheLoai = "2", TenTheLoai ="Tiểu Thuyết" },
                new SachTheLoai{ MaTheLoai = "3", TenTheLoai ="Cấp 3 " },
                new SachTheLoai{ MaTheLoai = "4", TenTheLoai ="Ngôn Tình" },
                new SachTheLoai{ MaTheLoai = "5", TenTheLoai ="Ngụ Ngôn" },
                //new SachTheLoai{ MaTheLoai = "", TenTheLoai ="" },
            });
            */
        }
    }
}
