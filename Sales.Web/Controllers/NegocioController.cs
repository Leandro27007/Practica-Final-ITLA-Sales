using Microsoft.AspNetCore.Mvc;
using Sales.Web.Models;
using Sales.Web.Services;

namespace Sales.Web.Controllers
{
    public class NegocioController : Controller
    {
        private readonly INegocioService negocioService;

        public NegocioController(INegocioService negocioService)
        {
            this.negocioService = negocioService;
        }

        public async Task<IActionResult> Index()
        {

            var result = await negocioService.GetNegocio();

            if(!result.success)
            {
                ViewBag.Message = result.message;
                return View();
            }


            var negocios = result.data;

            return View(negocios);
        }

        public async Task<IActionResult> Edit(NegocioResponseModel model)
        {
            return View(model);
        }

    }
}
