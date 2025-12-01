using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;

namespace Domain.DTOs
{
    public class PersonaWithNombreDepDTO
	{
		public Persona persona { get; }
		public string nombreDepartamento { get; }
		public PersonaWithNombreDepDTO() { }
		public PersonaWithNombreDepDTO(Persona persona, string nombreDepartamento) 
		{
			this.persona = persona;
			this.nombreDepartamento = nombreDepartamento;
		}
    }
}
