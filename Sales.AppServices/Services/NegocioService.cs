using Sales.AppServices.Contracts;
using Sales.AppServices.Core;
using Sales.AppServices.Dtos;
using Sales.Domain.Entities;
using Sales.Infraestructure.Core;
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



            try
            {
                if (_negocioDb.Exists(x => x.Id != 0))
                    throw new Exception("Ya esta registrado el negocio, no puedes agregar otro, Intenta editar el reciente.");


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
                    NombreLogo = negocioAdd.NombreLogo,
                    FechaRegistro = DateTime.UtcNow//DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                    ,
                    IdUsuarioCreacion = 1
                };

                var dataResult = await _negocioDb.Save(negocio);
                result.Success = dataResult.Success;
                result.Message = dataResult.Message;


                return result;
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = ex.Message;
                return result;
            }



        }

        public async Task<ServiceResult> GetNegocio()
        {
            ServiceResult serviceResult = new();

            var negocios = await _negocioDb.GetAll();

            serviceResult.Success = true;
            serviceResult.Data = negocios;

            return serviceResult;
        }
    }
}
