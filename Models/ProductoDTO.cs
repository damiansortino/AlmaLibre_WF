using System;

namespace Yamy_Desktop.Models
{
    public class ProductoDTO
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public double PrecioUnit { get; set; }
        public double Rentabilidad { get; set; }
        public double Precio { get; set; }
        public string Talle { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }

        public ProductoDTO()
        {

        }

        public ProductoDTO(producto prod)
        {
            Id = prod.ProductoId;
            Codigo = prod.codigo;
            Nombre = prod.nombre;
            Descripcion = prod.descripcion;
            PrecioUnit = prod.precioUnitario;
            Rentabilidad = prod.porcentajeRentabilidad;
            Precio = (int)Math.Ceiling(PrecioUnit + ((PrecioUnit * Rentabilidad) / 100));
            Talle = prod.talle;
            Color = prod.color;
            Marca = prod.marca;
        }
    }

}
