using Sales.Web.Models;
using Sales.Web.Models.Result;
using System.Text;
using System.Text.Json;

namespace Sales.Web.Services
{
    public class VentaService : IVentaService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<NegocioService> logger;
        private readonly IHttpClientFactory clientFactory;
        private string baseUrl;

        public VentaService(IConfiguration configuration, ILogger<NegocioService> logger, IHttpClientFactory clientFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.clientFactory = clientFactory;
            this.baseUrl = configuration["apiConfig:baseUrl"];
        }
   
        public async Task<ServiceResult<dynamic>> GetVenta(string numeroVenta)
        {
            throw new NotImplementedException();

        }

        public async Task<ServiceResult<List<VentaResponse>>> GetVentas()
        {
            ServiceResult<List<VentaResponse>> result = new ();
            try
            {
                using (var httpClient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.baseUrl}/Venta/GetVentas";

                    using (var response = await httpClient.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<ServiceResult<List<VentaResponse>>>(resp);
                        }
                        else
                        {
                            result.success = false;
                            result.message = "Error conectandose al end point de Get Venta";

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = "Error obteniendo la Venta";
                this.logger.LogError(result.message, ex.ToString());
            }
            return result;
        }

        public async Task<ServiceResult<List<VentaDetalleResponse>>> GetVentaDetalle(string numneroVenta)
        {
            ServiceResult<List<VentaDetalleResponse>> result = new();
            try
            {
                using (var httpClient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.baseUrl}/Venta/GetVentaDetalle"+ numneroVenta; 

                    using (var response = await httpClient.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<ServiceResult<List<VentaDetalleResponse>>>(resp);
                        }
                        else
                        {
                            result.success = false;
                            result.message = "Error conectandose al end point de Get Venta";

                        }

                    }

                }
            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = "Error obteniendo la Venta";
                this.logger.LogError(result.message, ex.ToString());
            }
            return result;
        }

        public async Task<ServiceResult<dynamic>> HacerVenta(VentaCreateModel venta)
        {
            ServiceResult<dynamic> result = new ServiceResult<dynamic>();
            try
            {
                using (var httpClient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.baseUrl}/Venta/CreateVenta";

                    StringContent content = new StringContent(JsonSerializer.Serialize(venta), Encoding.UTF8, "application/json");
                    string resp = string.Empty;
                    using (var response = await httpClient.PostAsync(url, content))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<ServiceResult<dynamic>>(resp);
                        }
                        else
                        {
                            if (response.StatusCode == System.Net.HttpStatusCode.BadRequest)
                            {
                                resp = await response.Content.ReadAsStringAsync();
                                result = JsonSerializer.Deserialize<ServiceResult<dynamic>>(resp);
                                return result;
                            }
                            else
                            {
                                result.success = false;
                                result.message = "Error conectandose al end point de Save Venta Crear.";
                            }

                        }
                    }
                }
            }
            catch (Exception ex)
            {

                result.success = false;
                result.message = "Error guardando la venta.";
                this.logger.LogError(result.message, ex.ToString()); ;
            }
            return result;
        }
    }
    
}
