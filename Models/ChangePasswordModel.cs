using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace QuanLyNhanSu.Models
{
    public class ChangePasswordModel
    {
        [DataType(DataType.Password)]
        /*[Required(ErrorMessage = "Nhập mật khẩu")]*/
        [MaxLength(50, ErrorMessage = "Vượt quá số kí tự 50")]
        public string CurrentPassword { get; set; }

        [DataType(DataType.Password)]
        /*[Required(ErrorMessage = "Nhập mật khẩu mới")]*/
        [MaxLength(50, ErrorMessage = "Vượt quá số kí tự 50")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        /*[Required(ErrorMessage = "Nhập xác nhận mật khẩu")]*/
        [MaxLength(50, ErrorMessage = "Vượt quá số kí tự 50")]
        [Compare("ConfirmPassword", ErrorMessage = "Xác nhận không khớp")]
        public string ConfirmPassword { get; set; }
    }
}