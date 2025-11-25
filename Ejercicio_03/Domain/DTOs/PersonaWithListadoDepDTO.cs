using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PersonaWithListadoDepDTO
    {
        public Persona persona { get; }
        public List<Departamento> listadoDepartamentos { get; }
	    public PersonaWithListadoDepDTO() { }
	    public PersonaWithListadoDepDTO(Persona persona, List<Departamento> listadoDepartamentos) 
        {
            this.persona = persona;
            this.listadoDepartamentos = listadoDepartamentos;
        }
}
}
