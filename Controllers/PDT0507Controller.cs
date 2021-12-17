using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MVCMovie.Models;

namespace PhamDucThuan507.Controllers
{
    public class PDT0507Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public PDT0507Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: PDT0507
        public async Task<IActionResult> Index()
        {
            return View(await _context.PDT0507.ToListAsync());
        }

        // GET: PDT0507/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDT0507 = await _context.PDT0507
                .FirstOrDefaultAsync(m => m.PDTID == id);
            if (pDT0507 == null)
            {
                return NotFound();
            }

            return View(pDT0507);
        }

        // GET: PDT0507/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PDT0507/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PDTID,PDTName")] PDT0507 pDT0507)
        {
            if (ModelState.IsValid)
            {
                _context.Add(pDT0507);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(pDT0507);
        }

        // GET: PDT0507/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDT0507 = await _context.PDT0507.FindAsync(id);
            if (pDT0507 == null)
            {
                return NotFound();
            }
            return View(pDT0507);
        }

        // POST: PDT0507/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("PDTID,PDTName")] PDT0507 pDT0507)
        {
            if (id != pDT0507.PDTID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(pDT0507);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PDT0507Exists(pDT0507.PDTID))
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
            return View(pDT0507);
        }

        // GET: PDT0507/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pDT0507 = await _context.PDT0507
                .FirstOrDefaultAsync(m => m.PDTID == id);
            if (pDT0507 == null)
            {
                return NotFound();
            }

            return View(pDT0507);
        }

        // POST: PDT0507/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var pDT0507 = await _context.PDT0507.FindAsync(id);
            _context.PDT0507.Remove(pDT0507);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PDT0507Exists(string id)
        {
            return _context.PDT0507.Any(e => e.PDTID == id);
        }
    }
}
