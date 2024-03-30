namespace Sales.Web.Models
{
    public class VentaResponse
    {
        
        public string numeroVenta { get; set; }
        public int idTipoDocumentoVenta { get; set; }

        public int idUsuario { get; set; }
        public string cocumentoCliente { get; set; }
        public string nombreCliente { get; set; }
        public object subTotal { get; set; }

        public decimal impuestoTotal { get; set; }

        public decimal total { get; set; }

        public dynamic detalleVentas { get; set; }

        public int id { get; set; }

        public int idUsuarioCreacion { get; set; }
        public DateTime fechaRegistro { get; set; }

    }
}
