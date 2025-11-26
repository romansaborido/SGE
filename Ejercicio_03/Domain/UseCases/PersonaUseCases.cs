using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.UseCases
{
    public class PersonaUseCases : IPersonaUseCases
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IDepartamentoRepository _departamentoRepository;

        public PersonaUseCases(IPersonaRepository personaRepository, IDepartamentoRepository departamentoRepository)
        {
            _personaRepository = personaRepository;
            _departamentoRepository = departamentoRepository;
        }

        public List<Departamento> getListadoDepartamentos() 
        {
            return _departamentoRepository.getDepartamentos();
        }

        public PersonaWithNombreDepDTO getPersona(int id)
        {
            // Obtenemos la persona
            Persona persona = _personaRepository.getPersona(id);

            // Obtenemos el nombre del departamento
            string nombreDepartamento = _departamentoRepository.getDepartamento(persona.idDepartamento).nombre;

            // Creamos el DTO
            PersonaWithNombreDepDTO personaDTO = new PersonaWithNombreDepDTO(persona, _departamentoRepository);

            // Devolvemos el DTO
            return personaDTO;
        }

        public List<PersonaWithNombreDepDTO> getPersonas()
        {
            // Creamos el listado a devolver
            List<PersonaWithNombreDepDTO> listadoDTOs = new List<PersonaWithNombreDepDTO>();

            // Obtenemos el listado de personas
            List<Persona> personas = _personaRepository.getPersonas();

            // Recorremos el listado de personas y mapeamos
            foreach (Persona persona in personas) 
            {
                // Obtenemos el nombre del departamento
                string nombreDepartamento = _departamentoRepository.getDepartamento(persona.idDepartamento).nombre;

                // Creamos el DTO
                PersonaWithNombreDepDTO personaDTO = new PersonaWithNombreDepDTO(persona, _departamentoRepository);

                // Añadimos el DTO a la lista
                listadoDTOs.Add(personaDTO);
            }

            // Devolvemos el listado
            return listadoDTOs;
        }

        public PersonaWithListadoDepDTO GetPersonaWithListadoDepDTO(int id) 
        {
            // Creamos el DTO
            PersonaWithListadoDepDTO personaListado = new PersonaWithListadoDepDTO(_personaRepository.getPersona(id), _departamentoRepository);

            // Devolvemos el listado
            return personaListado;
        }

        public int updatePersona(int id, Persona persona)
        {
            return _personaRepository.updatePersona(id, persona);
        }

        public int deletePersona(int id) 
        {
            return _personaRepository.deletePersona(id);
        }

        public int addPersona(Persona persona) 
        {
            return _personaRepository.addPersona(persona);
        }

    }
}
