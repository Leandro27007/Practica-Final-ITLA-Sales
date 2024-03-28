using System.ComponentModel.DataAnnotations;

namespace Sales.AppServices.Dtos
{
    public class NegocioAddDTO
    {
        public string Id { get; set; }
        public string UrlLogo { get; set; }
        public string NombreLogo { get; set; }
        public string NumeroDocumento { get; set; }
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public decimal PorcentajeImpuesto { get; set; }
        [MaxLength(5)]
        public string SimboloMoneda { get; set; }
    }
}
