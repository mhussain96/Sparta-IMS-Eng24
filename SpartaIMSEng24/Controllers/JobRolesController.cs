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
    public class JobRolesController : Controller
    {
        private readonly SpartaIMSContext _context;

        public JobRolesController(SpartaIMSContext context)
        {
            _context = context;
        }

        // GET: JobRoles
        public async Task<IActionResult> Index()
        {
            return View(await _context.JobRoles.ToListAsync());
        }

        // GET: JobRoles/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobRole = await _context.JobRoles
                .FirstOrDefaultAsync(m => m.JobRoleID == id);
            if (jobRole == null)
            {
                return NotFound();
            }

            return View(jobRole);
        }

        // GET: JobRoles/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: JobRoles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("JobRoleID,JobRoleName")] JobRole jobRole)
        {
            if (ModelState.IsValid)
            {
                _context.Add(jobRole);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(jobRole);
        }

        // GET: JobRoles/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobRole = await _context.JobRoles.FindAsync(id);
            if (jobRole == null)
            {
                return NotFound();
            }
            return View(jobRole);
        }

        // POST: JobRoles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("JobRoleID,JobRoleName")] JobRole jobRole)
        {
            if (id != jobRole.JobRoleID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(jobRole);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!JobRoleExists(jobRole.JobRoleID))
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
            return View(jobRole);
        }

        // GET: JobRoles/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var jobRole = await _context.JobRoles
                .FirstOrDefaultAsync(m => m.JobRoleID == id);
            if (jobRole == null)
            {
                return NotFound();
            }

            return View(jobRole);
        }

        // POST: JobRoles/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var jobRole = await _context.JobRoles.FindAsync(id);
            _context.JobRoles.Remove(jobRole);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool JobRoleExists(int id)
        {
            return _context.JobRoles.Any(e => e.JobRoleID == id);
        }
    }
}
