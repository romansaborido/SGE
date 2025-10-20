using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Unidad7.Models;
using Unidad7.Models.Entities;

namespace Unidad7.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            DateTime horaActual = DateTime.Now;
            String saludo;
            Persona persona;

            if (horaActual.Hour >= 6 && horaActual.Hour <= 13)
            {
                saludo = "Buenos días";
            }
            else if (horaActual.Hour >= 13 && horaActual.Hour <= 20)
            {
                saludo = "Buenas tardes";
            }
            else
            {
                saludo = "Buenas noches";
            }

            ViewData["Title"] = saludo;
            ViewBag.FechaActual = DateTime.Now.ToLongDateString();

            persona = new Persona(1, "Roman");

            return View(persona);
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
