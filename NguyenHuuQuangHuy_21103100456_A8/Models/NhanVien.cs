using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace NguyenHuuQuangHuy_21103100456_A8.Models
{
    public class NhanVien
    {
        [Key]
        [Required(ErrorMessage = "Mã nhân viên là bắt buộc.")]
        [DisplayName("Mã Nhân Viên")]
        public int MaNV { get; set; }

        [Required(ErrorMessage = "Họ đệm là bắt buộc.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Họ đệm phải từ 4 đến 50 ký tự.")]
        [DisplayName("Họ Đệm")]
        public string HoDem { get; set; }

        [Required(ErrorMessage = "Tên là bắt buộc.")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "Tên phải từ 4 đến 50 ký tự.")]
        [DisplayName("Tên")]
        public string Ten { get; set; }

        [Required(ErrorMessage = "Giới tính là bắt buộc.")]
        [DisplayName("Giới tính")]
        public Boolean GioiTinh { get; set; }

        [Required(ErrorMessage = "Tên phòng là bắt buộc.")]
        [DisplayName("Tên Phòng")]
        public string TenPhong { get; set; }

        [Required(ErrorMessage = "Email là bắt buộc.")]
        [DataType(DataType.EmailAddress)]
        [DisplayName("Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Lương ngày là bắt buộc.")]
        [Range(100000, 500000, ErrorMessage = "Lương ngày phải từ 100000 đến 500000")]
        [DisplayName("Lương ngày")]
        public double LuongNgay { get; set; }

        public virtual ICollection<Chamcong> ChamCongs { get; set; }
    }
}