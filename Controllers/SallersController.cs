using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Weba2mvc.Data;
using Weba2mvc.Models;

namespace Weba2mvc.Controllers
{
    public class SallersController : Controller
    {
        private readonly Weba2mvcContext _context;

        public SallersController(Weba2mvcContext context)
        {
            _context = context;
        }

        // GET: Sallers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Saller.ToListAsync());
        }

        // GET: Sallers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saller = await _context.Saller
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saller == null)
            {
                return NotFound();
            }

            return View(saller);
        }

        // GET: Sallers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Sallers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Name,Email,BirthDate,BaseSalary")] Saller saller)
        {
            if (ModelState.IsValid)
            {
                _context.Add(saller);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(saller);
        }

        // GET: Sallers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saller = await _context.Saller.FindAsync(id);
            if (saller == null)
            {
                return NotFound();
            }
            return View(saller);
        }

        // POST: Sallers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Email,BirthDate,BaseSalary")] Saller saller)
        {
            if (id != saller.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(saller);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!SallerExists(saller.Id))
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
            return View(saller);
        }

        // GET: Sallers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var saller = await _context.Saller
                .FirstOrDefaultAsync(m => m.Id == id);
            if (saller == null)
            {
                return NotFound();
            }

            return View(saller);
        }

        // POST: Sallers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var saller = await _context.Saller.FindAsync(id);
            _context.Saller.Remove(saller);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool SallerExists(int id)
        {
            return _context.Saller.Any(e => e.Id == id);
        }
    }
}
