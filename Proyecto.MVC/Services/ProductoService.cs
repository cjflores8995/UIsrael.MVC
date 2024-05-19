using Proyecto.MVC.Models;

using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace Proyecto.MVC.Services
{
    public class ProductoService
    {
        private readonly string _filePath;

        public ProductoService(string filePath)
        {
            _filePath = filePath;
        }

        public List<Producto> GetProductos()
        {
            var jsonString = File.ReadAllText(_filePath);

            return JsonSerializer.Deserialize<List<Producto>>(jsonString);
        }
    }
}
