using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpartaIMSEng24.Models;

namespace SpartaIMSEng24.Views
{
    public class SpecialisationsController : Controller
    {
        private readonly SpartaIMSEng24Context _context;

        public SpecialisationsController(SpartaIMSEng24Context context)
        {
            _context = context;
        }

        // GET: Specialisations
        public async Task<IActionResult> Index()
        {
            return View(await _context.Specialisation.ToListAsync());
        }

        // GET: Specialisations/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisation
                .FirstOrDefaultAsync(m => m.SpecID == id);
            if (specialisation == null)
            {
                return NotFound();
            }

            return View(specialisation);
        }

        // GET: Specialisations/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Specialisations/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpecID,SpecName")] Specialisation specialisation)
        {
            if (ModelState.IsValid)
            {
                _context.Add(specialisation);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(specialisation);
        }

        // GET: Specialisations/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisation.FindAsync(id);
            if (specialisation == null)
            {
                return NotFound();
            }
            return View(specialisation);
        }

        // POST: Specialisations/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpecID,SpecName")] Specialisation specialisation)
        {
            if (id != specialisation.SpecID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(specialisation);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpecialisationExists(specialisation.SpecID))
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
            return View(specialisation);
        }

        // GET: Specialisations/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var specialisation = await _context.Specialisation
                .FirstOrDefaultAsync(m => m.SpecID == id);
            if (specialisation == null)
            {
                return NotFound();
            }

            return View(specialisation);
        }

        // POST: Specialisations/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var specialisation = await _context.Specialisation.FindAsync(id);
            _context.Specialisation.Remove(specialisation);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpecialisationExists(int id)
        {
            return _context.Specialisation.Any(e => e.SpecID == id);
        }
    }
}
