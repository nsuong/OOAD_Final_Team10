using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;
using static System.Collections.Specialized.BitVector32;

namespace QuanLyThuVien.Controllers
{
    public class DocGiaController : Controller
    {
        private MyDBContext context;
        public DocGiaController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            var docGia = context.DocGias.ToList();
            return View(docGia);
        }
        public IActionResult Edit(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var docGia = context.DocGias.SingleOrDefault(m=>m.IDDocGia==id);
            if (docGia == null) return NotFound();
            return View(docGia);
        }
        [HttpPost]
        public IActionResult Edit(DocGia Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.DocGias.Update(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var docGia = context.DocGias.SingleOrDefault(m => m.IDDocGia == id);
            if (docGia == null) return NotFound();
            context.DocGias.Remove(docGia);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Details(int id)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            var docGia = context.DocGias.SingleOrDefault(m => m.IDDocGia == id);
            if (docGia == null) return NotFound();
            return View(docGia);
        }
        public IActionResult Create() 
        {
            return View();
        }
        public IActionResult CheckTaiKhoan(string TaiKhoan)
        {
            var timTaiKhoan = context.DocGias.SingleOrDefault(c => c.TaiKhoan == TaiKhoan);
            if (timTaiKhoan != null)
                return Json(data: "*Loại sách này đã tồn tại");
            return Json(data:true);
            
        }
        [HttpPost]
        public IActionResult Create(DocGia Model)
        {
            var a = HttpContext.Session.GetString("TaiKhoan");
            if (!ModelState.IsValid) return BadRequest(ModelState);
            context.DocGias.Add(Model);
            context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Login(DocGiaLogin Model)
        {
            if (!ModelState.IsValid) return BadRequest(ModelState);
            DocGiaLogin docGia = (from dg in context.DocGias
                         where dg.TaiKhoan == Model.TaiKhoan && dg.MatKhau == Model.MatKhau
                         select new DocGiaLogin
                         {
                             IDDocGia=dg.IDDocGia,
                             TaiKhoan=dg.TaiKhoan,
                             MatKhau=dg.MatKhau,
                             LoaiDocGia=dg.LoaiDocGia
                         }).SingleOrDefault();
            if(docGia==null)
            {
                ModelState.AddModelError("", "Sai tài khoản hoặc mật khẩu");
                return View();
            }
            else
            {
                HttpContext.Session.SetInt32("IDDocGia", docGia.IDDocGia);
                HttpContext.Session.SetString("TaiKhoan", docGia.TaiKhoan);
                HttpContext.Session.SetString("MatKhau", docGia.MatKhau);
                HttpContext.Session.SetInt32("LoaiTaiKhoan", docGia.LoaiDocGia);
            }
            return RedirectToAction("Details", "DocGia", new { id= docGia.IDDocGia });
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Remove("IDDocGia");
            HttpContext.Session.Remove("TaiKhoan");
            HttpContext.Session.Remove("MatKhau");
            HttpContext.Session.Remove("LoaiTaiKhoan");
            return RedirectToAction("Index");
        }
    }
}