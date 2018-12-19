using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;

namespace QuanLyThuVien.Controllers
{
    public class HomeController : Controller
    {
        private MyDBContext context;
        public HomeController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var sach = from s in context.Saches
                       join l in context.LoaiSaches
                       on s.IDLoai equals l.IDLoai
                       select new viewSach
                       {
                           IDSach = s.IDSach,
                           TenSach = s.TenSach,
                           TenLoai = l.TenLoai,
                           TacGia = s.TacGia,
                           MoTa = s.MoTa,
                           NamXuatBan = s.NamXuatBan,
                           NgayNhap = s.NgayNhap,
                           NhaXuatBan = s.NhaXuatBan,
                           SoTrang = s.SoTrang,
                           SoDanhGia = s.SoDanhGia,
                           XepHangTb = s.XepHangTb,
                       };
            return View(sach);
        }
        [HttpPost]
        public IActionResult timSach()
        {
            string key = Request.Form["keysearch"];
            var sach = from s in context.Saches
                       join l in context.LoaiSaches
                       on s.IDLoai equals l.IDLoai
                       where s.TacGia.Contains(key) || s.TenSach.Contains(key)
                        select new ttSach
                        {
                            TenSach = s.TenSach,
                            TenLoai = l.TenLoai,
                            TacGia = s.TacGia,
                            MoTa = s.MoTa,
                            NamXuatBan = s.NamXuatBan,
                            NhaXuatBan = s.NhaXuatBan,
                            SoDanhGia = s.SoDanhGia,
                            XepHangTb = s.XepHangTb,
                        }; 
            return View(sach);
        }
        [HttpPost]
        /*public IActionResult yeuCauThemSach()
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            
        }*/
        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";
            
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
