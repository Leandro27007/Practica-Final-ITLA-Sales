using Sales.Web.Models;
using Sales.Web.Models.Result;
using System.Text.Json;

namespace Sales.Web.Services
{
    public class NegocioService : INegocioService
    {
        private readonly IConfiguration configuration;
        private readonly ILogger<NegocioService> logger;
        private readonly IHttpClientFactory clientFactory;
        private string baseUrl;

        public NegocioService(IConfiguration configuration, ILogger<NegocioService> logger, IHttpClientFactory clientFactory)
        {
            this.configuration = configuration;
            this.logger = logger;
            this.clientFactory = clientFactory;
            this.baseUrl = configuration["apiConfig:baseUrl"];
        }


        public async Task<ServiceResult<List<NegocioResponseModel>>> GetNegocio()
        {
            ServiceResult<List<NegocioResponseModel>> result = new ServiceResult<List<NegocioResponseModel>>();
            try
            {
                using (var httpClient = this.clientFactory.CreateClient())
                {
                    var url = $"{this.baseUrl }/Negocio/GetNegocios";

                    using (var response = await httpClient.GetAsync(url))
                    {
                        if (response.IsSuccessStatusCode)
                        {
                            string resp = await response.Content.ReadAsStringAsync();
                            result = JsonSerializer.Deserialize<ServiceResult<List<NegocioResponseModel>>>(resp);
                        }
                        else
                        {
                            result.success = false;
                            result.message = "Error conectandose al end point de Get Departments";
                           
                        }

                     }

                }
            }
            catch (Exception ex)
            {
                result.success = false;
                result.message = "Error obteniendo los departamentos";
                this.logger.LogError(result.message, ex.ToString());
            }
            return result;
        }

        public Task<ServiceResult<dynamic>> AddNegocio(NegocioCreateModel negocio)
        {
            throw new NotImplementedException();
        }


    }
}
