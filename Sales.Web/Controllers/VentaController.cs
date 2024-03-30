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


            var negocios = result.data;

            return View(negocios);
        }

      

        public IActionResult CrearVenta()
        {
            return View();
        }

        public IActionResult GetDetails()
        {


            return View();
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
