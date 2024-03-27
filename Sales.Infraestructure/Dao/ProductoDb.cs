
using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class ProductoDb : DaoBase<Producto>, IProductoDb
    {
        private readonly List<Producto> _Productos;

        public ProductoDb(SalesContext context) : base(context)
        {

        }
    }
}
