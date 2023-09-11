using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TP02.Data;
using TP02.Models;

/*
 Dupla:
    Gabriel Ferreira de Souza
    Rian Gustavo Quintanilha de Aquino
 */

namespace TP02.Controllers
{
    public class ContainersController : Controller
    {
        private readonly TP02Context _context;

        public ContainersController(TP02Context context)
        {
            _context = context;
        }

        // GET: Containers
        public async Task<IActionResult> Index()
        {
            var tP02Context = _context.Container.Include(c => c.BL);
            return View(await tP02Context.ToListAsync());
        }

        // GET: Containers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Container == null)
            {
                return NotFound();
            }

            var container = await _context.Container
                .Include(c => c.BL)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (container == null)
            {
                return NotFound();
            }

            return View(container);
        }

        // GET: Containers/Create
        public IActionResult Create()
        {
            ViewData["BLID"] = new SelectList(_context.BL, "ID", "ID");
            return View();
        }

        // POST: Containers/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,Numero,Tipo,Tamanho,BLID")] Container container)
        {
            if (ModelState.IsValid)
            {
                _context.Add(container);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }

            ViewData["BLID"] = new SelectList(_context.BL, "ID", "ID", container.BLID);
            return View(container);
        }

        // GET: Containers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Container == null)
            {
                return NotFound();
            }

            var container = await _context.Container.FindAsync(id);
            if (container == null)
            {
                return NotFound();
            }
            ViewData["BLID"] = new SelectList(_context.BL, "ID", "ID", container.BLID);
            return View(container);
        }

        // POST: Containers/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,Numero,Tipo,Tamanho,BLID")] Container container)
        {
            if (id != container.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(container);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ContainerExists(container.ID))
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
            ViewData["BLID"] = new SelectList(_context.BL, "ID", "ID", container.BLID);
            return View(container);
        }

        // GET: Containers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Container == null)
            {
                return NotFound();
            }

            var container = await _context.Container
                .Include(c => c.BL)
                .FirstOrDefaultAsync(m => m.ID == id);
            if (container == null)
            {
                return NotFound();
            }

            return View(container);
        }

        // POST: Containers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Container == null)
            {
                return Problem("Entity set 'TP02Context.Container'  is null.");
            }
            var container = await _context.Container.FindAsync(id);
            if (container != null)
            {
                _context.Container.Remove(container);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ContainerExists(int id)
        {
          return (_context.Container?.Any(e => e.ID == id)).GetValueOrDefault();
        }
    }
}
