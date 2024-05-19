using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Proyecto.MVC.Models;
using Proyecto.MVC.Services;

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Proyecto.MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductoService _productoService;

        public HomeController(ProductoService productoService)
        {
            _productoService = productoService;
        }

        public IActionResult Index()
        {
            List<Producto> productos = _productoService.GetProductos();

            return View(productos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
