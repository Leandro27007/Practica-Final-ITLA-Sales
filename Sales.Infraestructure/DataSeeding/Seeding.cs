using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Sales.Domain.Entities;
using Sales.Infraestructure.context;
using Sales.Infraestructure.Dao;

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


                //TIPO DOCUMENTO
                if (!(await db.TipoDocumentoVenta.AnyAsync()))
                {
                    TipoDocumentoVenta tipoDoc = new()
                    {
                        Descripcion = "Cedula",
                        EsActivo = true,
                        FechaRegistro = DateTime.UtcNow,
                    };

                    db.TipoDocumentoVenta.Add(tipoDoc);

                    await db.SaveChangesAsync();
                }



                //ROL

                if (!(await db.Rol.AnyAsync()))
                {
                    Rol rol = new()
                    {
                        Descripcion = "Default Rol",
                        EsActivo = true,
                        FechaRegistro = DateTime.UtcNow,
                    };

                    db.Rol.Add(rol);

                    await db.SaveChangesAsync();
                }


                //USUARIO

                if (!(await db.Usuario.AnyAsync()))
                {
                    Usuario usuario = new()
                    {
                        Nombre = "Leandro",
                        Correo = "Leandro@gmail.com",
                        Clave = "123456",
                        Telefono = "809-000-0000",
                        IdRol = 1,
                        EsActivo = true,
                        FechaRegistro = DateTime.UtcNow,
                    };

                    db.Usuario.Add(usuario);

                    await db.SaveChangesAsync();
                }


                //Venta

                if (!(await db.Venta.AnyAsync()))
                {


                    var usuario = await db.Usuario.FirstAsync();
                    var documento = await db.TipoDocumentoVenta.FirstAsync();

                    List<DetalleVenta> detallesVentas = new()
                    {
                        new DetalleVenta()
                        {
                            IdProducto = 2654,
                            Cantidad = 2,
                            Precio = 350, //TODO: Get a real product price and remove this hardcode
                            Total = (2 * 350)
                        }
                    };


                    Venta venta = new Venta()
                    {
                        NumeroVenta = "123456",
                        CocumentoCliente = "000131801",
                        IdTipoDocumentoVenta = documento.Id,
                        IdUsuario = usuario.Id,
                        IdUsuarioCreacion = usuario.Id,
                        ImpuestoTotal = 200,
                        NombreCliente = "Leandro",
                        Total = 900,
                        FechaRegistro = DateTime.UtcNow,
                        DetalleVentas = detallesVentas

                    };

                    db.Venta.Add(venta);

                    await db.SaveChangesAsync();
                }






            }
            catch (Exception ex)
            {
               
                _logger.LogError($"Error al sembrar data de TipoDocumento: Ex.Message:{ex.Message}");
            }

        }
    }
}
