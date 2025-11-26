using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    public class PersonaController : Controller
    {
        private readonly IPersonaUseCases _personaUseCases;

        public PersonaController(IPersonaUseCases personaUseCases)
        {
            _personaUseCases = personaUseCases;
        }

        public ActionResult Index()
        {
            return View(_personaUseCases.getPersonas());
        }

        public ActionResult Details(int id)
        {
            return View(_personaUseCases.getPersona(id));
        }

        public ActionResult Create()
        {
            return View(_personaUseCases.getListadoDepartamentos());
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            _personaUseCases.addPersona(persona);
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int id)
        {
            return View(_personaUseCases.GetPersonaWithListadoDepDTO(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Persona persona)
        {
            _personaUseCases.updatePersona(id, persona);
            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            return View(_personaUseCases.getPersona(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            _personaUseCases.deletePersona(id);
            return RedirectToAction("Index");
        }
    }
}
