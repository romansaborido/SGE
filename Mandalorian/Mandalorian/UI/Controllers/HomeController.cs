using Domain.Entities;
using Domain.Interfaces;
using Domain.UseCases;
using DTO.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;

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
            return View(_listadoMisionesUseCase.getMisiones());
        }

        [HttpPost]
        public IActionResult MisionSeleccionada(int idMision)
        {
            return View(_listadoMisionesUseCase.getMisionesWithSelectedMision(idMision));
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
