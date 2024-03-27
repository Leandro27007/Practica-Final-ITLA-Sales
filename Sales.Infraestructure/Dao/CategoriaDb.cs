using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class CategoriaDb : DaoBase<Categoria>, ICategoriaDb
    {
        public CategoriaDb(SalesContext context) : base(context) { }
    }
}
