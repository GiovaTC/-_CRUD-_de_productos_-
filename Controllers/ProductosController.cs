using CRUDProductos.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUDProductos.Controllers
{
    public class ProductosController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Producto { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
