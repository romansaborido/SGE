using Domain.Entities;
using Domain.Interfaces;
using Domain.UseCases;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PersonasController : ControllerBase
{
    private readonly IPersonaUseCases _personasUseCase;

    public PersonasController(IPersonaUseCases personasUseCase)
    {
        _personasUseCase = personasUseCase;
    }

    // GET api/personas
    [HttpGet]
    public IActionResult Get()
    {
        try
        {
            var listado = _personasUseCase.getPersonas();

            if (listado == null || !listado.Any())
                return NoContent();

            return Ok(listado);
        }
        catch
        {
            return BadRequest();
        }
    }

    // GET api/personas/5
    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        try
        {
            var persona = _personasUseCase.getPersona(id);

            if (persona == null)
                return NotFound();

            return Ok(persona);
        }
        catch
        {
            return BadRequest();
        }
    }

    // POST api/personas
    [HttpPost]
    public IActionResult Post([FromBody] Persona persona)
    {
        try
        {
            int filas = _personasUseCase.addPersona(persona);

            if (filas == 0)
                return BadRequest();

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }

    // PUT api/personas/5
    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] Persona persona)
    {
        try
        {
            int filas = _personasUseCase.updatePersona(id, persona);

            if (filas == 0)
                return NotFound();

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }

    // DELETE api/personas/5
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        try
        {
            int filas = _personasUseCase.deletePersona(id);

            if (filas == 0)
                return NotFound();

            return Ok();
        }
        catch
        {
            return BadRequest();
        }
    }
}