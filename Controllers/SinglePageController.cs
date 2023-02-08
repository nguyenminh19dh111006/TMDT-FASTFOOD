using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuanLyFastFood.Models;



namespace QuanLyFastFood.Controllers
{
    public class SinglePageController : Controller
    {
        QuanLyFastFoodEntities db = new QuanLyFastFoodEntities();
        // GET: SinglePage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SingleProduct(int ? ma)
        {
            SanPham sp = db.SanPhams.Find(ma);
            if (sp != null)
            {
                ViewBag.sanpham = db.SanPhams.Where(x => x.Ma == ma).FirstOrDefault();
                ViewBag.LoaiSP = db.LoaiSPs.ToList();
                var mal = db.SanPhams.Where(x => x.Ma == ma).FirstOrDefault().MaLoai;
                ViewBag.SPCL = db.SanPhams.Where(x => x.MaLoai == mal).ToList();
                ViewBag.BESTSELL = db.SanPhams.OrderByDescending(x => x.Ma).Take(5).ToList();
            }
            return View();
        }
    }
}