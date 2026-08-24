using CRUDProductos.Models;
using CRUDProductos.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.EntityFrameworkCore;

namespace CRUDProductos.Controllers
{
    public class ProductosController : Controller
    {
        private readonly ApplicationDbContext _context; 

        public ProductosController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: PRODUCTOS .
        public async Task<IActionResult> Index()
        {
            var productos = await _context.Productos
                .AsNoTracking()
                .ToListAsync();

            return View(productos);
        }

        // GET: PRODUCTOS/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _context.Productos
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);
            
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: PRODUCTOS/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Producto producto)
        {
            if (ModelState.IsValid)
            {
                _context.Productos.Add(producto);
                await _context.SaveChangesAsync();

                return RedirectToAction(nameof(Index));
            }
            return View(producto);
        }

        // GET: PRODUCTOS/Edit/5 .
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var producto = await _context.Productos.FindAsync(id);
            
            if (producto == null)
            {
                return NotFound();
            }
            return View(producto);
        }

        // POST: PRODUCTOS/Edit/5 .
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Producto producto)
        {

            if (id != producto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(producto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProductoExiste(producto.Id))
                    {
                        return NotFound();
                    }

                        throw;
                    
                }
                return RedirectToAction(nameof(Index));
            }

            return View(producto);
        }

        // GET: PRODUCTOS/Delete/5  .
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.Id == id);

            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }

        // POST: PRODUCTOS/Delete/5  .
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos.FindAsync(id);

            if (producto != null)
            {
                _context.Productos.Remove(producto);
                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }

        private bool ProductoExiste(int id)
        {
            return _context.Productos.Any(e => e.Id == id);
        }
    }   
}
