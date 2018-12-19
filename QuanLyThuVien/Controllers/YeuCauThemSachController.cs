using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;

namespace QuanLyThuVien.Controllers
{
    public class YeuCauThemSachController : Controller
    {
        private MyDBContext context;
        public YeuCauThemSachController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            var yeuCau=context.yeuCauThemSaches.ToList();
            return View(yeuCau);
        }
        public IActionResult Create()
        {
            yeuCauThemSach yeuCau = new yeuCauThemSach()
            {
                TenSach = Request.Form["TenSach"],
                TacGia = Request.Form["TenTacGia"]
            };
            context.yeuCauThemSaches.Add(yeuCau);
            context.SaveChanges();
            return RedirectToAction("Index", "Home");
        }
        public IActionResult addSach(int id)
        {
            var yeuCau = context.yeuCauThemSaches.SingleOrDefault(m=>m.IDYeuCau==id);
            if (yeuCau == null) return NotFound();

            var sach1 = context.Saches.SingleOrDefault(m => m.TenSach == yeuCau.TenSach);
            if (sach1 != null)
            {
                context.yeuCauThemSaches.Remove(yeuCau);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            else {
                var sach2 = context.Saches.SingleOrDefault(m => m.TacGia == yeuCau.TacGia);
                if (sach2 != null)
                {
                    context.yeuCauThemSaches.Remove(yeuCau);
                    context.SaveChanges();
                    return RedirectToAction("Index");
                }
            }
            return RedirectToAction("Create", "Sach");
        }
    }
}