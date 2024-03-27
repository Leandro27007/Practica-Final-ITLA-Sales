using Sales.AppServices.Core;
using Sales.AppServices.Dtos;

namespace Sales.AppServices.Contracts
{
    internal interface IVentaService
    {
        public Task<ServiceResult> GetVenta(int numeroVenta);
        public Task<ServiceResult> HacerVenta(HacerVentaDTO venta);

    }
}
