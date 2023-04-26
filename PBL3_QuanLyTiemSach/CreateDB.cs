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
    {
        protected override void Seed(DBQuanLyTiemSach context)
        {
            context.TaiKhoans.AddRange(new TaiKhoan[]
            {
                new TaiKhoan { MaNV = "100", Username = "admin", Password = "3d18e7c3f354879667c3964c6fd1ed01348b02eed41a321391dcfb01f07150ab", Salt = "cV6kF5idUxGu" },
                new TaiKhoan { MaNV = "101", Username = "nhanvien1", Password = "f4039dd867feb007a8a1f0ef934a720fbcbab0bbb30ced0e7290fba592fee9c0", Salt = "cAPfg5Qa0e6h" },
                new TaiKhoan { MaNV = "102", Username = "nhanvien2", Password = "87089c1da28a685648a603452fecaaa6bca8ef651861b9b5c512e81ff576a456", Salt = "WMAbPKk73KUh" },
            });
            context.Sachs.AddRange(new Sach[]
            {
                new Sach {MaSach ="1", TenSach = "Duy Tân", TacGia = "Huy Cận", MaTheLoai ="1", GiaBan =50000},
                new Sach {MaSach ="2", TenSach = "Đạt Ma Thích Ca", TacGia = "Tú Mỡ", MaTheLoai ="2", GiaBan =60000},
                new Sach {MaSach ="3", TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai ="3", GiaBan =65000},
                new Sach {MaSach ="6", TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai ="3", GiaBan =65000},
                new Sach {MaSach ="7", TenSach = "John Wick", TacGia = "Antony SanTos", MaTheLoai ="3", GiaBan =65000},
                new Sach {MaSach ="8", TenSach = "Ngủ Trong Nhà", TacGia = "Pep Quardiorla", MaTheLoai ="1", GiaBan =50000},
                new Sach {MaSach ="4", TenSach = "Tây Du Kí", TacGia = "Ngô Thừa Ân", MaTheLoai ="4", GiaBan =620000},
                new Sach {MaSach ="5", TenSach = "Cô Gái Quàng Khăn Đỏ", TacGia = "Erik ten Hag", MaTheLoai ="5", GiaBan =100000},
                //new Sach {MaSach ="", MaKho ="", TenSach = "", TacGia = "", MaTheLoai ="", GiaBan =},
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
            context.HoaDonNhapSachs.AddRange(new HoaDonNhapSach[]
            {
                new HoaDonNhapSach{MaHDNhapSach = "111", MaHDNhap = "11", MaSach= "1", DonGiaNhap =40000 , SoLuongNhap =6000},
                new HoaDonNhapSach{MaHDNhapSach = "112", MaHDNhap = "12", MaSach= "2", DonGiaNhap =35000 , SoLuongNhap =4000},
                new HoaDonNhapSach{MaHDNhapSach = "113", MaHDNhap = "13", MaSach= "3", DonGiaNhap =30000 , SoLuongNhap =3500},
                new HoaDonNhapSach{MaHDNhapSach = "114", MaHDNhap = "14", MaSach= "4", DonGiaNhap =41000 , SoLuongNhap =5000},
                new HoaDonNhapSach{MaHDNhapSach = "115", MaHDNhap = "15", MaSach= "5", DonGiaNhap =90000 , SoLuongNhap =2000},
                new HoaDonNhapSach{MaHDNhapSach = "116", MaHDNhap = "16", MaSach= "6", DonGiaNhap =35000 , SoLuongNhap =1500},
                new HoaDonNhapSach{MaHDNhapSach = "117", MaHDNhap = "17", MaSach= "7", DonGiaNhap =37000 , SoLuongNhap =1560},
                new HoaDonNhapSach{MaHDNhapSach = "118", MaHDNhap = "18", MaSach= "8", DonGiaNhap =36000 , SoLuongNhap =2130}

                // new HoaDonNhapSach{MaHDNhapSach = "", MaHDNhap = "", MaSach= "", DonGiaNhap = , SoLuongNhap =},
            });
            context.HoaDonBanSachs.AddRange(new HoaDonBanSach[]
            {
                new HoaDonBanSach{MaHDBanSach = "211", MaHDBan = "21",MaSach = "1", DonGiaBan = 50000 ,SoLuongBan = 500},
                new HoaDonBanSach{MaHDBanSach = "212", MaHDBan = "22",MaSach = "3", DonGiaBan = 65000,SoLuongBan = 500},
                new HoaDonBanSach{MaHDBanSach = "213", MaHDBan = "23",MaSach = "6", DonGiaBan = 65000,SoLuongBan = 500},
                new HoaDonBanSach{MaHDBanSach = "214", MaHDBan = "24",MaSach = "7", DonGiaBan = 65000,SoLuongBan = 500}
              //  new HoaDonBanSach{MaHDBanSach = "", MaHDBan = "",MaSach = "", DonGiaBan = ,SoLuongBan = },
            });
        }
    }
}
