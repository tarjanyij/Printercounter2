using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Printercounter2.Data;
using Printercounter2.Models;

namespace Printercounter2.Controllers
{
    public class RepairReportListsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RepairReportListsController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: RepairReportLists
        public async Task<IActionResult> Index()
        {
            var applicationDbContext = _context.RepairReportList.Include(r => r.Printer);
            return View(await applicationDbContext.ToListAsync());
        }

        // GET: RepairReportLists/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repairReportList = await _context.RepairReportList
                .Include(r => r.Printer)
                .FirstOrDefaultAsync(m => m.RepairReportListID == id);
            if (repairReportList == null)
            {
                return NotFound();
            }

            return View(repairReportList);
        }

        // GET: RepairReportLists/Create
        public IActionResult Create()
        {
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID");
            return View();
        }

        // POST: RepairReportLists/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("RepairReportListID,PrinterID,AnnouncementDate,RepairDate,ReportedError,DetectedError,WorkDescription,UsedMaterials,Administrator")] RepairReportList repairReportList)
        {
            if (ModelState.IsValid)
            {
                _context.Add(repairReportList);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID", repairReportList.PrinterID);
            return View(repairReportList);
        }

        // GET: RepairReportLists/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repairReportList = await _context.RepairReportList.FindAsync(id);
            if (repairReportList == null)
            {
                return NotFound();
            }
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID", repairReportList.PrinterID);
            return View(repairReportList);
        }

        // POST: RepairReportLists/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("RepairReportListID,PrinterID,AnnouncementDate,RepairDate,ReportedError,DetectedError,WorkDescription,UsedMaterials,Administrator")] RepairReportList repairReportList)
        {
            if (id != repairReportList.RepairReportListID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(repairReportList);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!RepairReportListExists(repairReportList.RepairReportListID))
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
            ViewData["PrinterID"] = new SelectList(_context.Printers, "PrinterID", "PrinterID", repairReportList.PrinterID);
            return View(repairReportList);
        }

        // GET: RepairReportLists/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var repairReportList = await _context.RepairReportList
                .Include(r => r.Printer)
                .FirstOrDefaultAsync(m => m.RepairReportListID == id);
            if (repairReportList == null)
            {
                return NotFound();
            }

            return View(repairReportList);
        }

        // POST: RepairReportLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var repairReportList = await _context.RepairReportList.FindAsync(id);
            _context.RepairReportList.Remove(repairReportList);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool RepairReportListExists(int id)
        {
            return _context.RepairReportList.Any(e => e.RepairReportListID == id);
        }
    }
}
