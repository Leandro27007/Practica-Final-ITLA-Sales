using Sales.Domain.Core;

namespace Sales.Domain.Entities
{
    public class Configuracion : BaseEntity
    {
        public string Recurso { get; set; }
        public string Propiedad { get; set; }
        public string Valor { get; set; }
    }
}
