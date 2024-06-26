﻿using Sales.Domain.Entities;
using Sales.Infraestructure.Core;

namespace Sales.Infraestructure.Interfaces
{
    public interface IVentaDb : IDaoBase<Venta>
    {
        Task<List<DetalleVenta>> GetVentaDetalle(string numeroVenta);
    }
}
