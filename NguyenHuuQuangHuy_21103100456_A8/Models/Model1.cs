using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NguyenHuuQuangHuy_21103100456_A8.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=QLynhanvien")
        {
        }
        public DbSet<NhanVien> NhanViens { get; set; }
        public DbSet<Chamcong> ChamCongs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
