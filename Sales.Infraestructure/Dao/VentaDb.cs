using Microsoft.EntityFrameworkCore;
using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class VentaDb : DaoBase<Venta>, IVentaDb
    {
        private readonly SalesContext context;
        private DbSet<Venta> entities;


        public VentaDb(SalesContext context) : base(context)
        {
            this.context = context;
            this.entities = context.Set<Venta>();
        }

        public async Task<List<DetalleVenta>> GetVentaDetalle(string numeroVenta)
        {
            DataResult result = new();

            var detalles = await entities.Where(x => x.NumeroVenta == numeroVenta).Include(x => x.DetalleVentas).Select(x=> x.DetalleVentas).FirstOrDefaultAsync();

            return detalles;
        }
    }
}
