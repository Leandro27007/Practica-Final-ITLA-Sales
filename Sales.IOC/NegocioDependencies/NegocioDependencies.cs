using Microsoft.Extensions.DependencyInjection;
using Sales.AppServices.Contracts;
using Sales.AppServices.Services;
using Sales.Infraestructure.Dao;
using Sales.Infraestructure.Interfaces;


namespace Sales.IOC.NegocioDependencies
{
    public static class NegocioDependencies
    {

        public static void AddDependency(this IServiceCollection services)
        {
            services.AddTransient<INegocioService, NegocioService>();
            services.AddTransient<IVentaService, VentaService>();
            services.AddScoped<INegocioDb, NegocioDb>();
            services.AddScoped<IVentaDb, VentaDb>();
        }
    }
}
