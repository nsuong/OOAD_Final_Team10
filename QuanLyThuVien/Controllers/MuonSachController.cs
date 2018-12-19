using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QuanLyThuVien.Models;
using QuanLyThuVien.ViewModels;

namespace QuanLyThuVien.Controllers
{
    public class MuonSachController : Controller
    {
        MyDBContext context = new MyDBContext();
        public MuonSachController()
        {
            context = new MyDBContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult DatSach(int id, int idchinhanh)
        {
            if (HttpContext.Session.GetString("TaiKhoan") == null) return RedirectToAction("Login", "DocGia");
            var sach = context.Saches.SingleOrDefault(m => m.IDSach == id);
            var nhanVien = (from cn in context.ChiNhanhs
                            join nv in context.NhanViens
                            on cn.IDChiNhanh equals nv.IDChiNhanh
                            where nv.LoaiNhanVien == 0&&cn.IDChiNhanh==idchinhanh
                            select new MuonSach
                            {
                                IDNhanVien=nv.IDNhanVien,
                                TenChiNhanh=cn.TenChiNhanh
                            }).SingleOrDefault();
            var muonSach = new MuonSach()
            {
                IDSach = id,
                IDDocGia = (int)HttpContext.Session.GetInt32("IDDocGia"),
                IDNhanVien = nhanVien.IDNhanVien,
                TenChiNhanh=nhanVien.TenChiNhanh,
                PhiMuon=sach.TienMuon,
                TienCoc=sach.TienMua,
                NgayMuon=DateTime.Now,
                TrangThai=0,
                TinhTrangSach=""
            };
            context.MuonSaches.Add(muonSach);
            context.SaveChanges();
            //var a = Request.Form["DatSach"].;
            return RedirectToAction("Index","Home");
        }
    }
}