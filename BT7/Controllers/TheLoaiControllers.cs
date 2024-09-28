using BaiTap07.Data;
using BaiTap07.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BaiTap07.Controllers
{
	public class TheLoaiController : Controller
	{
		private readonly ApplicationDbContext _db;
		public TheLoaiController(ApplicationDbContext db)
		{
			_db = db;
		}
		public IActionResult Index()
		{
			var theloai = _db.TheLoai.ToList();
			ViewBag.TheLoai = theloai;
			return View();
		}
		[HttpGet]
		public IActionResult Create()
		{

			return View();
		}

		[HttpPost]
		public IActionResult Create(TheLoai theloai)
		{
			if (ModelState.IsValid)
			{
				// thêm thông tin vào bảng theloai
				_db.TheLoai.Add(theloai);
				//Luu lại
				_db.SaveChanges();
			}
			return View();
		}
		[HttpGet]

		public IActionResult Edit(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var theloai = _db.TheLoai.Find(id);
			return View(theloai);
		}
		[HttpPost]
		public IActionResult Edit(TheLoai theloai)
		{
			if (ModelState.IsValid)
			{
				// thêm thông tin vào bảng theloai
				_db.TheLoai.Update(theloai);
				//Luu lại
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
		[HttpGet]
		public IActionResult Delete(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var theloai = _db.TheLoai.Find(id);
			return View(theloai);
		}
		[HttpPost]
		public IActionResult DeleteConfirm(int id)
		{
			var theloai = _db.TheLoai.Find(id);
			if (theloai == null)
			{
				return NotFound();
			}
			_db.TheLoai.Remove(theloai);
			_db.SaveChanges();

			return RedirectToAction("Index");
		}
		[HttpGet]

		public IActionResult Details(int id)
		{
			if (id == 0)
			{
				return NotFound();
			}
			var theloai = _db.TheLoai.Find(id);
			return View(theloai);
		}
		[HttpPost]
		public IActionResult Details(TheLoai theloai)
		{
			if (ModelState.IsValid)
			{
				// thêm thông tin vào bảng theloai
				_db.TheLoai.Update(theloai);
				//Luu lại
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View();
		}
	}
}