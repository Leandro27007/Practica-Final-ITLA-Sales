using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class RolMenu : BaseEntity
    {
        public int IdRol { get; set; }
        public int IdMenu { get; set; }
    }
}
