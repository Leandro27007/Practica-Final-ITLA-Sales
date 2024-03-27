using Sales.AppServices.Core;
using Sales.AppServices.Dtos;

namespace Sales.AppServices.Contracts
{
    internal interface INegocioService
    {

        public Task<ServiceResult> GetNegocio();
        public Task<ServiceResult> AddNegocio(NegocioAddDTO negocio);


    }
}
