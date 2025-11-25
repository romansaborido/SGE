using Domain.DTOs;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPersonaUseCases
    {
        List<Departamento> getListadoDepartamentos();
        PersonaWithNombreDepDTO getPersona(int id);
        List<PersonaWithNombreDepDTO> getPersonas();
        PersonaWithListadoDepDTO GetPersonaWithListadoDepDTO(int id);
        int updatePersona(int id, Persona persona);
        int deletePersona(int id);
        public int addPersona(Persona persona);
    }
}
