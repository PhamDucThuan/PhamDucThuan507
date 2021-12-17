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
    public class CompanyPDT507Controller : Controller
    {
        private readonly ApplicationDBContext _context;

        public CompanyPDT507Controller(ApplicationDBContext context)
        {
            _context = context;
        }

        // GET: CompanyPDT507
        public async Task<IActionResult> Index()
        {
            return View(await _context.CompanyPDT507.ToListAsync());
        }

        // GET: CompanyPDT507/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPDT507 = await _context.CompanyPDT507
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (companyPDT507 == null)
            {
                return NotFound();
            }

            return View(companyPDT507);
        }

        // GET: CompanyPDT507/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CompanyPDT507/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CompanyID,CompanyName")] CompanyPDT507 companyPDT507)
        {
            if (ModelState.IsValid)
            {
                _context.Add(companyPDT507);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(companyPDT507);
        }

        // GET: CompanyPDT507/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPDT507 = await _context.CompanyPDT507.FindAsync(id);
            if (companyPDT507 == null)
            {
                return NotFound();
            }
            return View(companyPDT507);
        }

        // POST: CompanyPDT507/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("CompanyID,CompanyName")] CompanyPDT507 companyPDT507)
        {
            if (id != companyPDT507.CompanyID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(companyPDT507);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CompanyPDT507Exists(companyPDT507.CompanyID))
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
            return View(companyPDT507);
        }

        // GET: CompanyPDT507/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var companyPDT507 = await _context.CompanyPDT507
                .FirstOrDefaultAsync(m => m.CompanyID == id);
            if (companyPDT507 == null)
            {
                return NotFound();
            }

            return View(companyPDT507);
        }

        // POST: CompanyPDT507/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var companyPDT507 = await _context.CompanyPDT507.FindAsync(id);
            _context.CompanyPDT507.Remove(companyPDT507);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CompanyPDT507Exists(string id)
        {
            return _context.CompanyPDT507.Any(e => e.CompanyID == id);
        }
    }
}
