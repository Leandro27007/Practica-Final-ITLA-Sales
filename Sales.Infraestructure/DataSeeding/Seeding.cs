using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sales.Domain.Entities;
using Sales.Infraestructure.context;

namespace Sales.Infraestructure.DataSeeding
{
    public class Seeding
    {

        public async static Task Seed(IServiceProvider provider)
        {
            var _logger = provider.GetRequiredService<ILogger<Object>>();

            try
            {
                var db = provider.GetRequiredService<SalesContext>();
                var configuration = provider.GetRequiredService<IConfiguration>();

                db.Database.EnsureCreated();

                if ((await db.TipoDocumentoVenta.AnyAsync()))
                    return;

                TipoDocumentoVenta tipoDoc = new()
                {
                    Descripcion = "Cedula",
                    EsActivo = true,
                    FechaRegistro = DateTime.UtcNow,
                };

                db.TipoDocumentoVenta.Add(tipoDoc);

                await db.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error al sembrar data de TipoDocumento: Ex.Message:{ex.Message}");
            }

        }
    }
}
