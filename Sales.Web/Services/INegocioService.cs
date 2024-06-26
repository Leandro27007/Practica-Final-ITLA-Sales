﻿using Sales.Web.Models;
using Sales.Web.Models.Result;

namespace Sales.Web.Services
{
    public interface INegocioService
    {
        Task<ServiceResult<List<NegocioResponseModel>>> GetNegocio();
        Task<ServiceResult<NegocioResponseModel>> GetNegocioById(int id);
        public Task<ServiceResult<dynamic>> AddNegocio(NegocioCreateModel negocio);
    }
}
