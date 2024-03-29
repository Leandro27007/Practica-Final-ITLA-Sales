using Sales.AppServices.Core;
using Sales.AppServices.Dtos;

namespace Sales.AppServices.Contracts
{
    public interface IVentaService
    {
        public Task<ServiceResult> GetVenta(string numeroVenta);
        public Task<ServiceResult> GetVentas();
        public Task<ServiceResult> HacerVenta(HacerVentaDTO venta);

    }
}
