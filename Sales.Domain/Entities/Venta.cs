using Sales.Domain.Core;
using System.Net;

namespace Sales.Domain.Entities
{
    public class Venta : BaseEntity
    {
        public string NumeroVenta { get; set; }
        public int IdTipoDocumentoVenta { get; set; }
        public int IdUsuario { get; set; }
        public string CocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string? SubTotal { get; set; }
        public decimal ImpuestoTotal { get; set; }
        public decimal Total { get; set; }
        public List<DetalleVenta> DetalleVentas { get; set; }

    }
}
