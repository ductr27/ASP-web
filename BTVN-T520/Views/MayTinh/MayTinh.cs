using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BTVN_TH20.Views.MayTinh
{
    public class MayTinh : Controller
    {
        // GET: MayTinh
        public ActionResult Index()
        {
            return View();
        }

        // GET: MayTinh/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: MayTinh/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MayTinh/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MayTinh/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MayTinh/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: MayTinh/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MayTinh/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
