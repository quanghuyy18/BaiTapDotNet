using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NguyenHuuQuangHuy_21103100456_A8.Models
{
    public class Chamcong
    {
        [Key]
        [Column(Order = 1)]
        [Required(ErrorMessage = "Mã nhân viên là bắt buộc.")]
        [DisplayName("Mã Nhân Viên")]
        public int MaNV { get; set; }

        [Key]
        [Column(Order = 2)]
        [Required(ErrorMessage = "Tháng là bắt buộc.")]
        [Range(1, 12, ErrorMessage = "Tháng phải từ 1 đến 12!")]
        [DisplayName("Tháng")]
        public int Thang { get; set; }

        [Required(ErrorMessage = "Số ngày công là bắt buộc.")]
        [Range(1, 30, ErrorMessage = "Số ngày công phải từ 1 đến 12!")]
        [DisplayName("Số Ngày Công")]
        public int SoNgayCong { get; set; }

        public virtual NhanVien NhanViens { get; set; }
    }
}