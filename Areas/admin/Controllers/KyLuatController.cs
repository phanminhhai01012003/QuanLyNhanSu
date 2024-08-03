using QuanLyNhanSu.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLyNhanSu.Areas.admin.Controllers
{
    public class KyLuatController : Controller
    {
        QuanLyNhanSuEntities db = new QuanLyNhanSuEntities();
        // GET: admin/KyLuat
        public ActionResult Index()
        {
            var t = db.KyLuats.ToList();
            return View(t);
        }
        [HttpGet]
        public ActionResult kyluat()
        {
            var nv = db.NhanViens.ToList();

            return View(new KyLuat());
        }
        [HttpPost]
        public ActionResult kyluat(KyLuat kl)
        {
            KyLuat ad = new KyLuat();
            ad.MaNhanVien = kl.MaNhanVien;
            ad.ThangKiLuat = kl.ThangKiLuat;
            ad.TienKyLuat = kl.TienKyLuat;
            ad.LyDo = kl.LyDo;

            db.KyLuats.Add(ad);
            db.SaveChanges();
            return Redirect("/admin/KyLuat");
        }
    }
}