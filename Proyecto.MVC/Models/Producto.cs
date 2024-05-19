using System;

namespace Proyecto.MVC.Models
{
    public class Producto
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public double Precio { get; set; }
    }
}