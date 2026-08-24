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
    }   
}
