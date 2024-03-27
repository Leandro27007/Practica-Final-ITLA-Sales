using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entities;

namespace Sales.Infraestructure.context
{
    public class SalesContext : DbContext
    {

        public SalesContext(DbContextOptions<SalesContext> options): base(options) { }



        #region "DbSet"
            
        public DbSet<Categoria> categorias { get; set; }
        public DbSet<Configuracion> configuracionDbs { get; set; }
        public DbSet<Negocio> negocios { get; set; }
        public DbSet<NumeroCorrelativo> numeroCorrelativos { get; set; }
        public DbSet<Producto> productos { get; set; }
        public DbSet<Rol> rols{ get; set; }
        public DbSet<RolMenu> rolMenus{ get; set; }
        public DbSet<TipoDocumentoVenta> TipoDocumentoVentas{ get; set; }
        public DbSet<Usuario> usuarios{ get; set; }
        public DbSet<Venta> ventas{ get; set; }



        #endregion

    }
}
