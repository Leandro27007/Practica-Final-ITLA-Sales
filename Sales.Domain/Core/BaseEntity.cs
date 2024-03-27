namespace Sales.Domain.Core
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaMod { get; set; }
        public DateTime FechaElimino { get; set; }
        public bool EsActivo { get; set; }
        public bool Eliminado { get; set; }
        public string IdUsuarioCreacion { get; set; }
        public string IdUsuarioElimino { get; set; }

    }
}
