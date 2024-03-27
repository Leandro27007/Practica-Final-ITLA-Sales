using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales.AppServices.Contracts;

namespace Sales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NegocioController : ControllerBase
    {
        private readonly INegocioService _negocioService;

        public NegocioController(INegocioService negocioService)
        {
            this._negocioService = negocioService;
        }

        [HttpPost("GetNegocios")]
        public async Task<IActionResult> GetNegocios()
        {
            var result = await this._negocioService.GetNegocio();
            if (!result.Success)
                return BadRequest(result);


            return Ok(result);
        }


    }
}
