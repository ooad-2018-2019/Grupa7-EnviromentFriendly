﻿using System;
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
    public class ObrokController : Controller
    {
        private readonly CalTrekContext _context;

        public ObrokController(CalTrekContext context)
        {
            _context = context;
        }

        // GET: Obroci
        public async Task<IActionResult> Index()
        {
            return View(await _context.Obrok.ToListAsync());
        }

        // GET: Obroci/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obrok = await _context.Obrok
                .FirstOrDefaultAsync(m => m.Id == id);
            if (obrok == null)
            {
                return NotFound();
            }

            return View(obrok);
        }

        // GET: Obroci/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Obroci/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Naziv,Proteini,Ugljikohidrati,Masti,Kalorije")] Obrok obrok)
        {
            if (ModelState.IsValid)
            {
                _context.Add(obrok);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(obrok);
        }

        // GET: Obroci/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obrok = await _context.Obrok.FindAsync(id);
            if (obrok == null)
            {
                return NotFound();
            }
            return View(obrok);
        }

        // POST: Obroci/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Naziv,Proteini,Ugljikohidrati,Masti,Kalorije")] Obrok obrok)
        {
            if (id != obrok.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(obrok);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ObrokExists(obrok.Id))
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
            return View(obrok);
        }

        // GET: Obroci/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var obrok = await _context.Obrok
                .FirstOrDefaultAsync(m => m.Id == id);
            if (obrok == null)
            {
                return NotFound();
            }

            return View(obrok);
        }

        // POST: Obroci/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var obrok = await _context.Obrok.FindAsync(id);
            _context.Obrok.Remove(obrok);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ObrokExists(int id)
        {
            return _context.Obrok.Any(e => e.Id == id);
        }
    }
}
