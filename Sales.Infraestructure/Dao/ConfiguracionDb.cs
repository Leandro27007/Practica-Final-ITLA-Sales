using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Core;
using Sales.Infraestructure.Exceptions;
using Sales.Infraestructure.Interfaces;

namespace Sales.Infraestructure.Dao
{
    public class ConfiguracionDb :DaoBase<Configuracion>, IConfiguracionDb
    {

        public ConfiguracionDb(SalesContext context) : base(context) { }

    }
}
