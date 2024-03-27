using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class NumeroCorrelativoDb : DaoBase<NumeroCorrelativo>, INumeroCorrelativoDb
    {
        public NumeroCorrelativoDb(SalesContext context) : base(context) { }
    }
}
