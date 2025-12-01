using Domain.DTOs;
using Domain.Entities;
using Domain.UseCases;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PersonaController : ControllerBase
    {
        private readonly PersonaUseCases _personaUseCases;

        public PersonaController(PersonaUseCases personaUseCases)
        {
            _personaUseCases = personaUseCases;
        }

        // GET: api/persona
        [HttpGet]
        public ActionResult<List<PersonaWithNombreDepDTO>> GetPersonas()
        {
            var personas = _personaUseCases.getPersonas();
            return Ok(personas);
        }

        // GET: api/persona/{id}
        [HttpGet("{id}")]
        public ActionResult<PersonaWithNombreDepDTO> GetPersona(int id)
        {
            var persona = _personaUseCases.getPersona(id);
            if (persona == null)
                return NotFound();

            return Ok(persona);
        }

        // GET: api/persona/{id}/detalle
        [HttpGet("{id}/detalle")]
        public ActionResult<PersonaWithListadoDepDTO> GetPersonaDetalle(int id)
        {
            var personaDetalle = _personaUseCases.GetPersonaWithListadoDepDTO(id);
            if (personaDetalle == null)
                return NotFound();

            return Ok(personaDetalle);
        }

        // POST: api/persona
        [HttpPost]
        public ActionResult<int> AddPersona([FromBody] Persona persona)
        {
            int id = _personaUseCases.addPersona(persona);
            return CreatedAtAction(nameof(GetPersona), new { id = id }, id);
        }

        // PUT: api/persona/{id}
        [HttpPut("{id}")]
        public ActionResult<int> UpdatePersona(int id, [FromBody] Persona persona)
        {
            int updated = _personaUseCases.updatePersona(id, persona);
            if (updated == 0)
                return NotFound();

            return Ok(updated);
        }

        // DELETE: api/persona/{id}
        [HttpDelete("{id}")]
        public ActionResult<int> DeletePersona(int id)
        {
            int deleted = _personaUseCases.deletePersona(id);
            if (deleted == 0)
                return NotFound();

            return Ok(deleted);
        }

        // GET: api/persona/departamentos
        [HttpGet("departamentos")]
        public ActionResult<List<Departamento>> GetDepartamentos()
        {
            var departamentos = _personaUseCases.getListadoDepartamentos();
            return Ok(departamentos);
        }
    }
}
