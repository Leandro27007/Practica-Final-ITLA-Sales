namespace Sales.Domain.Core
{
    public class BaseAuditable : BaseEntity
    {
        public DateTime FechaElimino { get; set; }
        public bool Eliminado { get; set; }
        public int IdUsuarioElimino { get; set; }
        public int IdUsuarioMod { get; set; }
        public DateTime FechaMod { get; set; }
    }
}
