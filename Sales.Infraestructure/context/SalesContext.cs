using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entities;

namespace Sales.Infraestructure.context
{
    public class SalesContext : DbContext
    {

        public SalesContext(DbContextOptions<SalesContext> options): base(options) { }



        #region "DbSet"
            
        public DbSet<Categoria> Categoria { get; set; }
        public DbSet<Configuracion> ConfiguracionDb { get; set; }
        public DbSet<Negocio> Negocio { get; set; }
        public DbSet<NumeroCorrelativo> NumeroCorrelativo { get; set; }
        public DbSet<Producto> Producto { get; set; }
        public DbSet<Rol> rol{ get; set; }
        public DbSet<RolMenu> RolMenu{ get; set; }
        public DbSet<TipoDocumentoVenta> TipoDocumentoVenta{ get; set; }
        public DbSet<Usuario> Usuario{ get; set; }
        public DbSet<Venta> Venta{ get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
