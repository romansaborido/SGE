using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces 
{
    public interface IPersonaRepository
    {
		List<Persona> getPersonas();
		Persona getPersona(int id);
        int deletePersona(int id);
        int updatePersona(int id, Persona persona);
        int addPersona(Persona persona);
    }
}
