using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Categoria : BaseAuditable, IActivable
    {
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }

    }
}
