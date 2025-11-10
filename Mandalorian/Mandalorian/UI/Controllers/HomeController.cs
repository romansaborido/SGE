using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

using Domain.UseCases;
using Domain.Interfaces;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IListadoMisionesUseCases _listadoMisionesUseCase;

        public HomeController(ILogger<HomeController> logger, IListadoMisionesUseCases listadoMisionesUseCase)
        {
            _logger = logger;
            _listadoMisionesUseCase = listadoMisionesUseCase;
        }

        public IActionResult Index()
        {
            var misiones = _listadoMisionesUseCase.getMisiones();

            return View(misiones);
        }

        [HttpPost]
        public IActionResult MisionSeleccionada(int idMision)
        {
            var misionSeleccionada = _listadoMisionesUseCase.getMisionById(idMision);

            return View(misionSeleccionada);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
