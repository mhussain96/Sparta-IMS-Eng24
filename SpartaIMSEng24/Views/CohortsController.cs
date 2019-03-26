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
    public class CohortsController : Controller
    {
        private readonly SpartaIMSEng24Context _context;

        public CohortsController(SpartaIMSEng24Context context)
        {
            _context = context;
        }

        // GET: Cohorts
        public async Task<IActionResult> Index()
        {
            return View(await _context.Cohort.ToListAsync());
        }

        // GET: Cohorts/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohort
                .FirstOrDefaultAsync(m => m.CohortID == id);
            if (cohort == null)
            {
                return NotFound();
            }

            return View(cohort);
        }

        // GET: Cohorts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Cohorts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("CohortID,CohortName,CohortNumber")] Cohort cohort)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cohort);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cohort);
        }

        // GET: Cohorts/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohort.FindAsync(id);
            if (cohort == null)
            {
                return NotFound();
            }
            return View(cohort);
        }

        // POST: Cohorts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("CohortID,CohortName,CohortNumber")] Cohort cohort)
        {
            if (id != cohort.CohortID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cohort);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CohortExists(cohort.CohortID))
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
            return View(cohort);
        }

        // GET: Cohorts/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cohort = await _context.Cohort
                .FirstOrDefaultAsync(m => m.CohortID == id);
            if (cohort == null)
            {
                return NotFound();
            }

            return View(cohort);
        }

        // POST: Cohorts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cohort = await _context.Cohort.FindAsync(id);
            _context.Cohort.Remove(cohort);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CohortExists(int id)
        {
            return _context.Cohort.Any(e => e.CohortID == id);
        }
    }
}
