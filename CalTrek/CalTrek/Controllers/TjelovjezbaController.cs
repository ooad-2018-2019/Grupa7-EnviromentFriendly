using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CalTrek.Models;
using CalTrekApp.Models;

namespace CalTrek.Controllers
{
    public class TjelovjezbaController : Controller
    {
        private readonly CalTrekContext _context;

        public TjelovjezbaController(CalTrekContext context)
        {
            _context = context;
        }

        // GET: Tjelovjezba
        public async Task<IActionResult> Index()
        {
            return View(await _context.Tjelovjezba.ToListAsync());
        }

        // GET: Tjelovjezba/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tjelovjezba = await _context.Tjelovjezba
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tjelovjezba == null)
            {
                return NotFound();
            }

            return View(tjelovjezba);
        }

        // GET: Tjelovjezba/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Tjelovjezba/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,BCPM")] Tjelovjezba tjelovjezba)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tjelovjezba);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tjelovjezba);
        }

        // GET: Tjelovjezba/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tjelovjezba = await _context.Tjelovjezba.FindAsync(id);
            if (tjelovjezba == null)
            {
                return NotFound();
            }
            return View(tjelovjezba);
        }

        // POST: Tjelovjezba/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,BCPM")] Tjelovjezba tjelovjezba)
        {
            if (id != tjelovjezba.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tjelovjezba);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TjelovjezbaExists(tjelovjezba.Id))
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
            return View(tjelovjezba);
        }

        // GET: Tjelovjezba/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tjelovjezba = await _context.Tjelovjezba
                .FirstOrDefaultAsync(m => m.Id == id);
            if (tjelovjezba == null)
            {
                return NotFound();
            }

            return View(tjelovjezba);
        }

        // POST: Tjelovjezba/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tjelovjezba = await _context.Tjelovjezba.FindAsync(id);
            _context.Tjelovjezba.Remove(tjelovjezba);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TjelovjezbaExists(int id)
        {
            return _context.Tjelovjezba.Any(e => e.Id == id);
        }
    }
}
