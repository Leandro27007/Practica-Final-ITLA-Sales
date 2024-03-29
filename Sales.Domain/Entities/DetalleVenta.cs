using Sales.Domain.Core;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sales.Domain.Entities
{
    public class DetalleVenta
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }
        public string MarcaProducto { get; set; }
        public string DescripcionProducto { get; set; }
        public string CategoriaProducto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal Total { get; set; }
        public Venta Venta { get; set; }
        [ForeignKey(nameof(Venta))]
        public int IdVenta { get; set; }
    }
}
