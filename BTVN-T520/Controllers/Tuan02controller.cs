using Microsoft.AspNetCore.Mvc;

namespace BTVN_TH20.Controllers
{
    public class Tuan02controller : Controller
    {
        public IActionResult Index()
        {


            
            {
                ViewBag.HoTen = "Vu Trung Duc";
                ViewBag.MSSV = "1822041161";
                ViewData["Nam"] = "Năm 2077";
                return View();
            }


        }
    }
}
