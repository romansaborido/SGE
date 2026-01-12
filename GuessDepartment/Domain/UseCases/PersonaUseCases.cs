using Domain.DTOs;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.UseCases
{
    public class PersonaUseCases : IPersonaUseCases
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IDepartamentoUseCases _departamentoUseCases;

        public PersonaUseCases(IPersonaRepository personaRepository, IDepartamentoUseCases departamentoUseCases)
        {
            _personaRepository = personaRepository;
            _departamentoUseCases = departamentoUseCases;
        }

        public List<PersonaDepartamentosDTO> getPersonas()
        {
            // Obtenemos los departamentos
            List<Departamento> departamentos = _departamentoUseCases.getDepartamentos();

            // Obtenemos las personas
            List<Persona> personas = _personaRepository.getPersonas();

            // Creamos el listado de DTOs a devolver
            List<PersonaDepartamentosDTO> listado = new List<PersonaDepartamentosDTO>();

            // Recorremos las personas, mapeamos a DTOs y las añadimos a listado a devolver
            foreach (Persona persona in personas) 
            {
                PersonaDepartamentosDTO personaDeptos = new PersonaDepartamentosDTO(persona.id, persona.nombre, persona.apellidos, persona.idDepartamento, departamentos);
                listado.Add(personaDeptos);
            }

            return listado;
        }

        public int getAciertos(List<IdPersonaDepartamentoDTO> resForm)
        {
            // Creamos la variable aciertos a devolver
            int aciertos = 0;

            // Obtenemos los IDs de personas y su correspondiente departamento
            List<IdPersonaDepartamentoDTO> IDs = _personaRepository.getIds();

            // Comparamos los dos listados
            for (int i = 0; i < resForm.Count; i++) 
            {
                if (IDs[i].idPersona == resForm[i].idPersona && IDs[i].idDepartamento == resForm[i].idDepartamento) 
                {
                    aciertos += 1;
                }
            }

            return aciertos;
        }
    }
}
