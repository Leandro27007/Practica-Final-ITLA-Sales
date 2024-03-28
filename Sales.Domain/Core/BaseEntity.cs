namespace Sales.Domain.Core
{
    public class BaseEntity
    {
        public int Id { get; set; }
        public DateTime FechaRegistro { get; set; }

        public int IdUsuarioCreacion { get; set; }


    }
}
