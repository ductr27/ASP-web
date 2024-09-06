using BiaTap05.Models;
using Microsoft.AspNetCore.Mvc;

namespace BT5.Controllers
{
    public class TheLoaiController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.Ngay = "Ngày 9";
            ViewBag.Thang = "Tháng 11";
            ViewData["Nam"] = "Năm 2001";
            return View();
        }

        public IActionResult Index2()
        {
            var theloai = new TheLoaiViewModel
            {
                Id = 1,
                Name = "Kiếm hiệp"
            };

            return View(theloai);
        }
    }
}
