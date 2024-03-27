using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using Sales.AppServices.Dtos;

namespace Sales.AppServices.Services
{
    public class VentaService : IVentaService
    {
        public Task<ServiceResult> GetVenta(int numeroVenta)
        {
            throw new NotImplementedException();
        }

        public Task<ServiceResult> HacerVenta(HacerVentaDTO venta)
        {
            throw new NotImplementedException();
        }
    }
}
