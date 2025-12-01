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
            string mensaje;
            int res = _personaUseCases.addPersona(persona);
            if (res > 0)
            {
                mensaje = "La persona se ha creado correctamente";
            }
            else
            {
                mensaje = "La persona no se ha podido crear";
            }
            ViewBag.mensaje = mensaje;
            return View(_personaUseCases.getListadoDepartamentos());
        }

        public ActionResult Edit(int id)
        {
            return View(_personaUseCases.GetPersonaWithListadoDepDTO(id));
        }

        [HttpPost]
        public ActionResult Edit(int id, Persona persona)
        {
            string mensaje;
            int res = _personaUseCases.updatePersona(id, persona);
            if (res > 0)
            {
                mensaje = "La persona se ha modificado correctamente";
            }
            else 
            {
                mensaje = "La persona no se ha podido modificar";
            }
            ViewBag.mensaje = mensaje;
            return View(_personaUseCases.GetPersonaWithListadoDepDTO(id));
        }

        public ActionResult Delete(int id)
        {
            return View(_personaUseCases.getPersona(id));
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            string mensaje;
            int res = _personaUseCases.deletePersona(id);
            if (res > 0)
            {
                mensaje = "La persona se ha eliminado correctamente";
            }
            else 
            {
                mensaje = "La persona no se ha podido eliminar";
            }
            ViewBag.mensaje = mensaje;
            return View("Delete", _personaUseCases.getPersona(id));
        }
    }
}
