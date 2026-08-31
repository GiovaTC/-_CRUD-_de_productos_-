using CRUDProductos.Data;
using CRUDProductos.Models;
using Microsoft.AspNetCore.Mvc;
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

        // =====================================================
        // GET: /Productos
        // LISTAR PRODUCTOS
        // =====================================================

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var productos = await _context.Productos
                .AsNoTracking()
                .ToListAsync();

            return View(productos);
        }


        // =====================================================
        // GET: /Productos/Details/5
        // VER DETALLES
        // =====================================================

        [HttpGet]
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


        // =====================================================
        // GET: /Productos/Create
        // MOSTRAR FORMULARIO
        // =====================================================

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }


        // =====================================================
        // POST: /Productos/Create
        // GUARDAR PRODUCTO
        // =====================================================

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


        // =====================================================
        // GET: /Productos/Edit/5
        // MOSTRAR FORMULARIO DE EDICIÓN
        // =====================================================

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var producto = await _context.Productos
                .FindAsync(id);

            if (producto == null)
            {
                return NotFound();
            }

            return View(producto);
        }


        // =====================================================
        // POST: /Productos/Edit/5
        // ACTUALIZAR PRODUCTO
        // =====================================================

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


        // =====================================================
        // GET: /Productos/Delete/5
        // MOSTRAR CONFIRMACIÓN
        // =====================================================

        [HttpGet]
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


        // =====================================================
        // POST: /Productos/Delete/5
        // ELIMINAR PRODUCTO
        // =====================================================

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producto = await _context.Productos
                .FindAsync(id);

            if (producto != null)
            {
                _context.Productos.Remove(producto);

                await _context.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Index));
        }


        // =====================================================
        // MÉTODO AUXILIAR
        // =====================================================

        private bool ProductoExiste(int id)
        {
            return _context.Productos
                .Any(e => e.Id == id);
        }
    }
}   