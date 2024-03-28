using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Rol : BaseAuditable, IActivable
    {
        public string Descripcion { get; set; }
        public bool EsActivo { get; set; }

    }
}
