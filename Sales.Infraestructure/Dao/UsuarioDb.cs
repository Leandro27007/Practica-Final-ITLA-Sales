using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class UsuarioDb : DaoBase<Usuario>, IUsuarioDb
    {

        public UsuarioDb(SalesContext context) : base(context) { }
    }
}
