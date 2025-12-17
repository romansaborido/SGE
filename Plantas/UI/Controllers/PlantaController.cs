using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Models;
using Domain.Interfaces;

namespace UI.Controllers
{
    public class PlantaController : Controller
    {
        private readonly IPlantaUseCases _plantaUseCases;

        public PlantaController(IPlantaUseCases plantaUseCases)
        {
            _plantaUseCases = plantaUseCases;
        }

        public IActionResult Index()
        {
            return View(_plantaUseCases.getPlantasCategorias(null));
        }

        [HttpPost]
        public IActionResult Index(int idCategoria)
        {
            return View(_plantaUseCases.getPlantasCategorias(idCategoria));
        }

        public IActionResult Planta(int idPlanta) {
            return View(_plantaUseCases.getPlantaById(idPlanta));
        }

        [HttpPost]
        public IActionResult Planta(int idPlanta, decimal nuevoPrecio) {
            int res = _plantaUseCases.cambiarPrecio(idPlanta, nuevoPrecio);
            if (res > 0)
            {
                ViewBag.Mensaje = "El precio se ha modificado correctamente";
            }
            else 
            {
                ViewBag.Mensaje = "El precio no se ha podido modificar";
            }
            return View(_plantaUseCases.getPlantaById(idPlanta));
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
