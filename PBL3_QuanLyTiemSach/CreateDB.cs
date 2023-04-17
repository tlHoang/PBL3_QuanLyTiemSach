using PBL3_QuanLyTiemSach.DTO.CodeFirst;
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
        }
    }
}
