using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class RolMenuDb : DaoBase<RolMenu>, IRolMenuDb
    {

        public RolMenuDb(SalesContext context) : base(context) { }
    }
}
