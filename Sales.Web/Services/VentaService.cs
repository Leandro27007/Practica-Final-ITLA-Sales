using Sales.Web.Models;
using Sales.Web.Models.Result;
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

        public Task<ServiceResult<dynamic>> HacerVenta(VentaCreateModel venta)
        {
            throw new NotImplementedException();
        }
    }
}
