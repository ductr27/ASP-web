using Microsoft.AspNetCore.Mvc;

namespace BTVN_TH20.Controllers
{
    public class MayTinhController : Controller
    {
        public IActionResult MayTinh(double a, double b, string pheptinh)
        {
            double ketqua = 0;
            string thongbao = "";
            if (string.IsNullOrWhiteSpace(pheptinh))
            {
                ViewBag.KetQua = "Phép tính không hợp lệ!";
                return View();
            }
            switch (pheptinh.ToLower())
            {
                case "cong":
                    ketqua = a + b;
                    break;
                case "tru":
                    ketqua = a - b;
                    break;
                case "nhan":
                    ketqua = a * b;
                    break;
                case "chia":
                    if (b != 0)
                    {
                        ketqua = a / b;
                    }
                    else
                    {
                        thongbao = "Không thể chia cho 0";
                    }
                    break;
                default:
                    thongbao = "phép tính không hợp lệ!";
                    break;
            }
            if (string.IsNullOrEmpty(thongbao))
            {
                ViewBag.KetQua = $"Kết qua của phép {pheptinh} giữa {a} và {b} la: {ketqua}";
            }
            else
            {
                ViewBag.KetQua = thongbao;
            }

            return View();
        }
    }
}