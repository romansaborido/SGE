using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using Domain.UseCases;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

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
            List<PersonaWithNombreDepDTO> personas = new List<PersonaWithNombreDepDTO>();
            try
            {
                personas = _personaUseCases.getPersonas();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(personas);
        }

        public ActionResult Details(int id)
        {
            PersonaWithNombreDepDTO persona = new PersonaWithNombreDepDTO();
            try
            {
                persona = _personaUseCases.getPersona(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(persona);
        }

        public ActionResult Create()
        {
            List<Departamento> departamentos = new List<Departamento>();
            try
            {
                departamentos = _personaUseCases.getListadoDepartamentos();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(departamentos);
        }

        [HttpPost]
        public ActionResult Create(Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return View(_personaUseCases.getListadoDepartamentos());
            }
            else 
            {
                string mensaje;
                int res = 0;
                try
                {
                    res = _personaUseCases.addPersona(persona);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
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
        }

        public ActionResult Edit(int id)
        {
            PersonaWithListadoDepDTO dto = new PersonaWithListadoDepDTO();
            try
            {
                dto = _personaUseCases.GetPersonaWithListadoDepDTO(id);
            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(dto);
        }

        [HttpPost]
        public ActionResult Edit(int id, Persona persona)
        {
            if (!ModelState.IsValid)
            {
                return View(_personaUseCases.getListadoDepartamentos());
            }
            else
            {
                string mensaje;
                int res = 0;
                try
                {
                    res = _personaUseCases.updatePersona(id, persona);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
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
        }

        public ActionResult Delete(int id)
        {
            PersonaWithNombreDepDTO persona = new PersonaWithNombreDepDTO();
            try
            {
                persona = _personaUseCases.getPersona(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return View("~/Views/Home/Error.cshtml");
            }
            return View(persona);
        }

        [HttpPost]
        public ActionResult DeleteConfirmed(int id)
        {
            string mensaje;
            int res = 0;
            try
            {
                res = _personaUseCases.deletePersona(id);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
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
