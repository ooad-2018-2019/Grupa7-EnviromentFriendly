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
    public class StrucnjakController : Controller
    {
        private readonly CalTrekContext _context;

        public StrucnjakController(CalTrekContext context)
        {
            _context = context;
        }

        // GET: Strucnjak
        public async Task<IActionResult> Index()
        {
            return View(await _context.Strucnjak.ToListAsync());
        }

        // GET: Strucnjak/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strucnjak = await _context.Strucnjak
                .FirstOrDefaultAsync(m => m.Id == id);
            if (strucnjak == null)
            {
                return NotFound();
            }

            return View(strucnjak);
        }

        // GET: Strucnjak/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Strucnjak/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("GodineIskustva,Tip,Id,Username,Ime,Prezime,DatumRodjenja,Spol,Grad,Drzava")] Strucnjak strucnjak)
        {
            if (ModelState.IsValid)
            {
                _context.Add(strucnjak);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(strucnjak);
        }

        // GET: Strucnjak/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strucnjak = await _context.Strucnjak.FindAsync(id);
            if (strucnjak == null)
            {
                return NotFound();
            }
            return View(strucnjak);
        }

        // POST: Strucnjak/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("GodineIskustva,Tip,Id,Username,Ime,Prezime,DatumRodjenja,Spol,Grad,Drzava")] Strucnjak strucnjak)
        {
            if (id != strucnjak.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(strucnjak);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!StrucnjakExists(strucnjak.Id))
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
            return View(strucnjak);
        }

        // GET: Strucnjak/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var strucnjak = await _context.Strucnjak
                .FirstOrDefaultAsync(m => m.Id == id);
            if (strucnjak == null)
            {
                return NotFound();
            }

            return View(strucnjak);
        }

        // POST: Strucnjak/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var strucnjak = await _context.Strucnjak.FindAsync(id);
            _context.Strucnjak.Remove(strucnjak);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool StrucnjakExists(int id)
        {
            return _context.Strucnjak.Any(e => e.Id == id);
        }
    }
}
