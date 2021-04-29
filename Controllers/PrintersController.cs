using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Printercounter2.Data;
using Printercounter2.Models;

namespace Printercounter2.Controllers
{
    public class PrintersController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PrintersController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Printers
        public async Task<IActionResult> Index(int? pageNumber)
        {
           
            var devices = _context.Printers
                            .OrderBy(m=>m.PrinterIP);
            
            if (devices == null)
            {
                return NotFound();
            }
            
            int pageSize = 30;
            var device = (await PaginatedList<Printer>.CreateAsync(devices.AsNoTracking(), pageNumber ?? 1, pageSize));
            
            ViewBag.HasNextPage = device.HasNextPage;
            ViewBag.HasPreviousPage = device.HasPreviousPage;
            ViewBag.pageNumber =  pageNumber;
            ViewBag.TotalPages =device.TotalPages;
            return View(device);
        }

        // GET: Printers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers
                .FirstOrDefaultAsync(m => m.PrinterID == id);
            
            if (printer == null)
            {
                return NotFound();
            }

            return View(printer);
        }

        // GET: Printers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Printers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("PrinterID,PrinterIP,PrinterName,PrinterModel,PrinterDescription,PrinterSN,PrinterBarcode,PrinterLocation,PrinterTonerName,Active")] Printer printer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(printer);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(printer);
        }

        // GET: Printers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers.FindAsync(id);
            if (printer == null)
            {
                return NotFound();
            }
            return View(printer);
        }

        // POST: Printers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("PrinterID,PrinterIP,PrinterName,PrinterModel,PrinterDescription,PrinterSN,PrinterBarcode,PrinterLocation,PrinterTonerName,Active")] Printer printer)
        {
            if (id != printer.PrinterID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(printer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!PrinterExists(printer.PrinterID))
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
            return View(printer);
        }

        // GET: Printers/Delete/5
        [Authorize(Roles="Admin, Manager")]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var printer = await _context.Printers
                .FirstOrDefaultAsync(m => m.PrinterID == id);
            if (printer == null)
            {
                return NotFound();
            }

            return View(printer);
        }

        // POST: Printers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles="Admin, Manager")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var printer = await _context.Printers.FindAsync(id);
            _context.Printers.Remove(printer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool PrinterExists(int id)
        {
            return _context.Printers.Any(e => e.PrinterID == id);
        }
    }
}
