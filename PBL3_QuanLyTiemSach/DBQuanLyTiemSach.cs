using PBL3_QuanLyTiemSach.DTO;
using System;
using System.Data.Entity;
using System.Linq;

namespace PBL3_QuanLyTiemSach
{
    public class DBQuanLyTiemSach : DbContext
    {
        // Your context has been configured to use a 'DBQuanLyTiemSach' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'PBL3_QuanLyTiemSach.DBQuanLyTiemSach' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'DBQuanLyTiemSach' 
        // connection string in the application configuration file.
        public DBQuanLyTiemSach()
            : base("name=DBQuanLyTiemSach")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.

        // public virtual DbSet<MyEntity> MyEntities { get; set; }
        public virtual DbSet<Ca> Cas { get; set; }
        public virtual DbSet<CaNV> CaNVs { get; set; }
        public virtual DbSet<DonViCungCap> DonViCungCaps { get; set; }
        public virtual DbSet<HoaDonBan> HoaDonBans { get; set; }
        public virtual DbSet<HoaDonBanSach> HoaDonBanSachs { get; set; }
        public virtual DbSet<HoaDonNhap> HoaDonNhaps { get; set; }
        public virtual DbSet<HoaDonNhapSach> HoaDonNhapSachs { get; set; }
        public virtual DbSet<KhachHang> KhachHangs { get; set; }
        public virtual DbSet<Kho> Khos { get; set; }
        public virtual DbSet<NhanVien> NhanViens { get; set; }
        public virtual DbSet<Sach> Sachs { get; set; }
        public virtual DbSet<SachTheLoai> SachTheLoais { get; set; }
    }

    //public class MyEntity
    //{
    //    public int Id { get; set; }
    //    public string Name { get; set; }
    //}
}