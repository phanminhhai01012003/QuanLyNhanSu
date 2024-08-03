using QuanLyNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyNhanSu.Areas.admin.Controllers
{
    public class ChangePasswordController : Controller
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        // GET: admin/ChangePassword
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ChangePassword(ChangePasswordModel ChPass)
        {
            if (ModelState.IsValid)
            {
                string UserName = (string)Session["MaNhanVien"];
                var tk = db.NhanViens.FirstOrDefault(m => m.MaNhanVien == UserName);
                if (tk.MatKhau == ChPass.CurrentPassword)
                {
                    ViewBag.err = "";
                    if (ChPass.NewPassword == ChPass.ConfirmPassword)
                    {
                        tk.MatKhau = ChPass.NewPassword;
                    }
                    else
                    {
                        ViewBag.err = "Mật khẩu xác nhận không khớp";
                        return View();
                    }
                    db.SaveChanges();
                    return RedirectToAction("DangXuat", "login");
                }
                else
                {
                    return View();
                }
            }
            else
            {
                return View();
            }
        }
    }
}