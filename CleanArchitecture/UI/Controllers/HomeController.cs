using System.Diagnostics;
using Domain.Interfaces.IUseCases;
using Microsoft.AspNetCore.Mvc;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IGetListadoPersonasUseCase _listadoPersonasUseCases;

        public HomeController(ILogger<HomeController> logger, IGetListadoPersonasUseCase listadoPersonasUseCases)
        {
            _logger = logger;
            _listadoPersonasUseCases = listadoPersonasUseCases;
        }

        public IActionResult Index()
        {
            return View(_listadoPersonasUseCases.getListadoPersonas());
        }

        public IActionResult Details(int id)
        {
            return View();
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
