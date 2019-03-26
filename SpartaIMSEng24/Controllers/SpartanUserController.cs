﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SpartaIMSEng24.Data;
using SpartaIMSEng24.Models;

namespace SpartaIMSEng24.Controllers
{
    public class SpartanUserController : Controller
    {
        private readonly SpartaIMSContext _context;

        public SpartanUserController(SpartaIMSContext context)
        {
            _context = context;
        }

        // GET: SpartanUser
        public async Task<IActionResult> Index()
        {
            var spartaIMSContext = _context.SpartanUsers.Include(s => s.Cohort).Include(s => s.JobRole);
            return View(await spartaIMSContext.ToListAsync());
        }

        // GET: SpartanUser/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spartanUser = await _context.SpartanUsers
                .Include(s => s.Cohort)
                .Include(s => s.JobRole)
                .FirstOrDefaultAsync(m => m.SpartanID == id);
            if (spartanUser == null)
            {
                return NotFound();
            }

            return View(spartanUser);
        }

        // GET: SpartanUser/Create
        public IActionResult Create()
        {
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID");
            ViewData["JobRoleID"] = new SelectList(_context.JobRoles, "JobRoleID", "JobRoleID");
            return View();
        }

        // POST: SpartanUser/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("SpartanID,FirstName,LastName,Email,Password,FullName,CohortID,JobRoleID")] SpartanUser spartanUser)
        {
            if (ModelState.IsValid)
            {
                _context.Add(spartanUser);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID", spartanUser.CohortID);
            ViewData["JobRoleID"] = new SelectList(_context.JobRoles, "JobRoleID", "JobRoleID", spartanUser.JobRoleID);
            return View(spartanUser);
        }

        // GET: SpartanUser/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spartanUser = await _context.SpartanUsers.FindAsync(id);
            if (spartanUser == null)
            {
                return NotFound();
            }
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID", spartanUser.CohortID);
            ViewData["JobRoleID"] = new SelectList(_context.JobRoles, "JobRoleID", "JobRoleID", spartanUser.JobRoleID);
            return View(spartanUser);
        }

        // POST: SpartanUser/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("SpartanID,FirstName,LastName,Email,Password,FullName,CohortID,JobRoleID")] SpartanUser spartanUser)
        {
            if (id != spartanUser.SpartanID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(spartanUser);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SpartanUserExists(spartanUser.SpartanID))
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
            ViewData["CohortID"] = new SelectList(_context.Cohorts, "CohortID", "CohortID", spartanUser.CohortID);
            ViewData["JobRoleID"] = new SelectList(_context.JobRoles, "JobRoleID", "JobRoleID", spartanUser.JobRoleID);
            return View(spartanUser);
        }

        // GET: SpartanUser/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var spartanUser = await _context.SpartanUsers
                .Include(s => s.Cohort)
                .Include(s => s.JobRole)
                .FirstOrDefaultAsync(m => m.SpartanID == id);
            if (spartanUser == null)
            {
                return NotFound();
            }

            return View(spartanUser);
        }

        // POST: SpartanUser/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var spartanUser = await _context.SpartanUsers.FindAsync(id);
            _context.SpartanUsers.Remove(spartanUser);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SpartanUserExists(int id)
        {
            return _context.SpartanUsers.Any(e => e.SpartanID == id);
        }
    }
}
