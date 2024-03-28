using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class RolMenu : BaseAuditable, IActivable
    {
        public int IdRol { get; set; }
        public int IdMenu { get; set; }
        public bool EsActivo { get; set; }
    }
}
