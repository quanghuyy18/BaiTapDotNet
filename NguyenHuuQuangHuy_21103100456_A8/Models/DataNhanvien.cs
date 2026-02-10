using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NguyenHuuQuangHuy_21103100456_A8.Models
{
    public class DataNhanvien : DropCreateDatabaseAlways<Model1>
    {
        protected override void Seed(Model1 context)
        {
            context.NhanViens.Add(new NhanVien { MaNV = 1, HoDem = "Lê Thảo", Ten = "Nguyên", GioiTinh = false, TenPhong = "Kế toán", Email = "ltnguyen@gmail.com", LuongNgay = 500000 });
            context.NhanViens.Add(new NhanVien { MaNV = 2, HoDem = "Nguyễn Hải", Ten = "Long", GioiTinh = true, TenPhong = "Hành chính", Email = "nhlong@gmail.com", LuongNgay = 300000 });
            context.SaveChanges();

            context.ChamCongs.Add(new Chamcong { MaNV = 1, Thang = 1, SoNgayCong = 22 });
            context.ChamCongs.Add(new Chamcong { MaNV = 2, Thang = 2, SoNgayCong = 26 });
            context.ChamCongs.Add(new Chamcong { MaNV = 1, Thang = 2, SoNgayCong = 18 });
            context.ChamCongs.Add(new Chamcong { MaNV = 2, Thang = 1, SoNgayCong = 28 });
            context.SaveChanges();

            base.Seed(context);
        }
    }
}