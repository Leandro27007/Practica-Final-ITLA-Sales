using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using Sales.AppServices.Dtos;
using Sales.Domain.Entities;
using Sales.Infraestructure.Interfaces;

namespace Sales.AppServices.Services
{
    public class VentaService : IVentaService
    {
        private readonly IVentaDb ventaDB;

        public VentaService(IVentaDb ventaDB)
        {
            this.ventaDB = ventaDB;
        }
        public async Task<ServiceResult> GetVenta(string numeroVenta)
        {               
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = await ventaDB.GetEntitiesWithFilters(x => x.NumeroVenta == numeroVenta);
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result.Success = false;
                result.Message = "Ocurrio un error mientras se recuperaban los datos.";
                return result;
            }

        }
        public async Task<ServiceResult> GetVentas()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                result.Data = await ventaDB.GetAll();
                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                result.Success = false;
                result.Message = "Ocurrio un error mientras se recuperaban los datos.";
                return result;
            }

        }

        public async Task<ServiceResult> HacerVenta(HacerVentaDTO ventaDTO)
        {
            ServiceResult result = new ServiceResult();
            Random rnd = new Random();

            //Default Document Type
            if (ventaDTO.IdTipoDocumentoVenta == 0)
                ventaDTO.IdTipoDocumentoVenta = 1;   
            //Default User, this is only for test. shold be removed on production.
            if (ventaDTO.IdUsuario == 0)
                ventaDTO.IdTipoDocumentoVenta = 1;

            Venta venta = new Venta()
            {
                NumeroVenta = rnd.Next(100000,900000).ToString(),
                CocumentoCliente = ventaDTO.DocumentoCliente,
                IdTipoDocumentoVenta = ventaDTO.IdTipoDocumentoVenta,
                IdUsuario = ventaDTO.IdUsuario,
                IdUsuarioCreacion = ventaDTO.IdUsuario,
                ImpuestoTotal = ventaDTO.ImpuestoTotal,
                NombreCliente = ventaDTO.NombreCliente,
                Total = 900,
                FechaRegistro = DateTime.UtcNow,
                DetalleVentas = ventaDTO.Detalle.Select(x => new DetalleVenta()
                {
                    IdProducto = x.IdProducto,
                    Cantidad = x.Cantidad,
                    Precio = 50, //TODO: Get a real product price and remove this hardcode
                    Total = (x.Cantidad * 50)
                }).ToList()
                
            };

            try
            {
                await ventaDB.Save(venta);

                result.Success = await ventaDB.Commit() > 0;
                return result;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                return result;
            }

        }
    }
}
