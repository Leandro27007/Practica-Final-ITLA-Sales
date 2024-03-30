namespace Sales.Web.Models
{
    public class VentaCreateModel
    {
        public int IdTipoDocumentoVenta { get; set; }
        public int IdUsuario { get; set; }
        public string DocumentoCliente { get; set; }
        public string NombreCliente { get; set; }
        public string SubTotal { get; set; }
        public decimal ImpuestoTotal { get; set; }
        public List<VentaDetalleCreateModel> Detalle { get; set; }
    }
}
