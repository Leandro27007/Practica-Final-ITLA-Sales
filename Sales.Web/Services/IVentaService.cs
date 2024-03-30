using Sales.Web.Models;
using Sales.Web.Models.Result;

namespace Sales.Web.Services
{
    public interface IVentaService
    {
        public Task<ServiceResult<dynamic>> GetVenta(string numeroVenta);
        public Task<ServiceResult<List<VentaResponse>>> GetVentas();
        public Task<ServiceResult<dynamic>> HacerVenta(VentaCreateModel venta);

    }
}
