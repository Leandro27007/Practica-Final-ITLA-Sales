using Sales.AppServices.Core;
using Sales.AppServices.Dtos;

namespace Sales.AppServices.Contracts
{
    public interface INegocioService
    {

        public Task<ServiceResult> GetNegocio();
        public Task<ServiceResult> AddNegocio(NegocioAddDTO negocio);


    }
}
