using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using UI.Mappers;
using UI.Models;

namespace UI.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonaUseCases _personaUseCases;
        private readonly IPersonaDTOtoPersonaColor _mapper;

        public IActionResult Index()
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
