using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales.AppServices.Contracts;
using Sales.AppServices.Dtos;

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

        [HttpGet("GetNegocios")]
        public async Task<IActionResult> GetNegocios()
        {
            var result = await this._negocioService.GetNegocio();
            if (!result.Success)
                return BadRequest(result);


            return Ok(result);
        }    
        [HttpGet("GetNegocioById{id}")]
        public async Task<IActionResult> GetNegocioById(int id)
        {
            var result = await this._negocioService.GetNegocioById(id);
            if (!result.Success)
                return BadRequest(result);


            return Ok(result);
        }

        [HttpPost("SetNegocio")]
        public async Task<IActionResult> SetNegocio([FromBody]NegocioAddDTO negocio)
        {
            var result = await this._negocioService.AddNegocio(negocio);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }


        [HttpPut("UpdateNegocio")]
        public async Task<IActionResult> UpdateNegocio([FromBody] NegocioAddDTO negocio)
        {
            var result = await this._negocioService.AddNegocio(negocio);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }


    }
}
