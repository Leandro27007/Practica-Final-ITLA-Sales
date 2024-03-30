namespace Sales.Web.Models
{
    public class VentaDetalleResponse
    {
        public int id { get; set; }
        public int idProducto { get; set; }
        public string marcaProducto { get; set; }
        public string descripcionProducto { get; set; }
        public string categoriaProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precio { get; set; }
        public decimal total { get; set; }
        public dynamic venta { get; set; }
        public int idVenta { get; set; }
    }
}
