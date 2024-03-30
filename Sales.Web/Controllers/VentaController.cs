using Microsoft.AspNetCore.Mvc;
using Sales.Web.Models;
using Sales.Web.Services;

namespace Sales.Web.Controllers
{
    public class VentaController : Controller
    {
        private readonly IVentaService ventaService;

        public VentaController(IVentaService ventaService)
        {
            this.ventaService = ventaService;
        }

        public async Task<IActionResult> Index()
        {

            var result = await ventaService.GetVentas();

            if (!result.success)
            {
                ViewBag.Message = result.message;
                return View();
            }


            var ventas = result.data;

            return View(ventas);
        }

      

        public IActionResult CrearVenta()
        {
            return View();
        }

        public async Task<IActionResult> GetDetails(string numeroVenta)
        {

            var result = await ventaService.GetVentaDetalle(numeroVenta);

            if (!result.success)
            {
                ViewBag.Message = result.message;
                return View();
            }


            var detalles = result.data;

            return View(detalles);
        }
        public IActionResult AgregarProducto(VentaCreateModel model)
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GuardarVenta(VentaCreateModel model)
        {


            var result = await ventaService.HacerVenta(model);

            if (!result.success)
            {
                ViewBag.Message = result.message;
                return View();
            }

            return RedirectToAction("Index");
        }

    }
}
