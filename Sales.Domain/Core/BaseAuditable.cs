namespace Sales.Domain.Core
{
    //Todo: Set class like Abstract class
    public class BaseAuditable : BaseEntity
    {
        public string? FechaElimino { get; set; }
        public bool Eliminado { get; set; }
        public int IdUsuarioElimino { get; set; }
        public int IdUsuarioMod { get; set; }
        public string? FechaMod { get; set; }
    }
}
