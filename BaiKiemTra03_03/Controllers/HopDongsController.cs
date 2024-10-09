using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BaiKiemTra03_03_x_.Data;
using BaiKiemTra03_03_x_.Models;

namespace BaiKiemTra03_03_x_.Controllers
{
    public class HopDongsController : Controller
    {
        private readonly BaiKiemTra0303Context _context;

        public HopDongsController(BaiKiemTra0303Context context)
        {
            _context = context;
        }

        // GET: HopDongs
        public async Task<IActionResult> Index()
        {
            var baiKiemTra0303Context = _context.HopDongs.Include(h => h.CustomerNavigation);
            return View(await baiKiemTra0303Context.ToListAsync());
        }

        // GET: HopDongs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hopDong = await _context.HopDongs
                .Include(h => h.CustomerNavigation)
                .FirstOrDefaultAsync(m => m.ContracId == id);
            if (hopDong == null)
            {
                return NotFound();
            }

            return View(hopDong);
        }

        // GET: HopDongs/Create
        public IActionResult Create()
        {
            ViewData["Customer"] = new SelectList(_context.KhachHangs, "CustomerId", "CustomerId");
            return View();
        }

        // POST: HopDongs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ContracId,ContracName,SigningDate,Customer,ContractValue")] HopDong hopDong)
        {
            if (ModelState.IsValid)
            {
                _context.Add(hopDong);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customer"] = new SelectList(_context.KhachHangs, "CustomerId", "CustomerId", hopDong.Customer);
            return View(hopDong);
        }

        // GET: HopDongs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hopDong = await _context.HopDongs.FindAsync(id);
            if (hopDong == null)
            {
                return NotFound();
            }
            ViewData["Customer"] = new SelectList(_context.KhachHangs, "CustomerId", "CustomerId", hopDong.Customer);
            return View(hopDong);
        }

        // POST: HopDongs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ContracId,ContracName,SigningDate,Customer,ContractValue")] HopDong hopDong)
        {
            if (id != hopDong.ContracId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(hopDong);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!HopDongExists(hopDong.ContracId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            ViewData["Customer"] = new SelectList(_context.KhachHangs, "CustomerId", "CustomerId", hopDong.Customer);
            return View(hopDong);
        }

        // GET: HopDongs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var hopDong = await _context.HopDongs
                .Include(h => h.CustomerNavigation)
                .FirstOrDefaultAsync(m => m.ContracId == id);
            if (hopDong == null)
            {
                return NotFound();
            }

            return View(hopDong);
        }

        // POST: HopDongs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var hopDong = await _context.HopDongs.FindAsync(id);
            if (hopDong != null)
            {
                _context.HopDongs.Remove(hopDong);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool HopDongExists(int id)
        {
            return _context.HopDongs.Any(e => e.ContracId == id);
        }
    }
}
