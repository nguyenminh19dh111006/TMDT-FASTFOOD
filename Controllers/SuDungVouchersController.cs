using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using PagedList;
using QuanLyFastFood.Models;

namespace QuanLyFastFood.Controllers
{
    public class SuDungVouchersController : Controller
    {
        private QuanLyFastFoodEntities db = new QuanLyFastFoodEntities();

        // GET: SuDungVouchers
        public ActionResult Index()
        {
            return View(db.Vouchers.ToList());
        }

        public ActionResult showVoucher(string ma, int? page)
        {

            if (page == null)
            {
                page = 1;
            }
            int pageSize = 6;
            int pageNumber = (page ?? 1);
            var voucher = db.Vouchers.Where(x => x.MaVoucher == ma).OrderByDescending(s => s.NgayKichHoat).ToPagedList(pageNumber, pageSize);

            if (voucher.Count() > 0)
            {
                ViewBag.Ma = ma;
                voucher = db.Vouchers.Where(x => x.MaVoucher == ma).OrderByDescending(s => s.NgayKichHoat).ToPagedList(pageNumber, pageSize);

            }
            else
            {
                voucher = db.Vouchers.OrderByDescending(s => s.NgayKichHoat).ToPagedList(pageNumber, pageSize);
            }
            return View(voucher);
        }

        // GET: SuDungVouchers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Voucher voucher = db.Vouchers.Find(id);
            if (voucher == null)
            {
                return HttpNotFound();
            }
            return View(voucher);
        }
    }
}
