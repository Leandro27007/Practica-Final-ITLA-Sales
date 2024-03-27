using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using Sales.AppServices.Dtos;
using Sales.Domain.Entities;
using Sales.Infraestructure.Interfaces;

namespace Sales.AppServices.Services
{
    public class NegocioService : INegocioService
    {
        private INegocioDb _negocioDb;
        public NegocioService(INegocioDb negocioDb)
        {
            this._negocioDb = negocioDb;
        }
        public async Task<ServiceResult> AddNegocio(NegocioAddDTO negocioAdd)
        {
            ServiceResult result = new();

            Negocio negocio = new()
            {
                Correo = negocioAdd.Correo,
                Direccion = negocioAdd.Direccion,
                Nombre = negocioAdd.Nombre,
                UrlLogo = negocioAdd.UrlLogo,
                Telefono = negocioAdd.Telefono,
                SimboloMoneda = negocioAdd.SimboloMoneda,
                PorcentajeImpuesto = negocioAdd.PorcentajeImpuesto,
                NumeroDocumento = negocioAdd.NumeroDocumento,
                NombreLogo = negocioAdd.NombreLogo

            };

            var dataResult = await _negocioDb.Save(negocio);


            result.Success = dataResult.Success;
            result.Message = dataResult.Message;


            return result;
        }

        public Task<ServiceResult> GetNegocio()
        {
            throw new NotImplementedException();
        }
    }
}
