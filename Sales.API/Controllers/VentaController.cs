using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Sales.AppServices.Contracts;
using Sales.AppServices.Dtos;

namespace Sales.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VentaController : ControllerBase
    {
        IVentaService _ventaService;
        public VentaController(IVentaService ventaService)
        {
            this._ventaService = ventaService;
        }

        [HttpGet("GetVentas")]
        public async Task<IActionResult> GetVentas()
        {
            var result = await this._ventaService.GetVentas();
            if (!result.Success)
                return BadRequest(result);


            return Ok(result);
        }

        [HttpGet("GetVentaDetalle{numeroVenta}")]
        public async Task<IActionResult> GetVentaDetalle(string numeroVenta)
        {
            var result = await this._ventaService.GetVentaDetalle(numeroVenta);
            if (!result.Success)
                return BadRequest(result);


            return Ok(result);
        }

        [HttpPost("CreateVenta")]
        public async Task<IActionResult> CreateVenta([FromBody] HacerVentaDTO venta)
        {
            var result = await this._ventaService.HacerVenta(venta);

            if (!result.Success)
                return BadRequest(result);

            return Ok(result);
        }



    }
}
