using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class NumeroCorrelativo : BaseAuditable, IActivable
    {
        public int UltimoNumero { get; set; }
        public int CantidadDigitos { get; set; }
        public string Gestion { get; set; }
        public bool EsActivo { get; set; }
    }
}
