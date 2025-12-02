using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PersonaWithListadoDepDTO
    {
        #region propiedades
        public Persona persona { get; }
        public List<Departamento> listadoDepartamentos { get; }
        #endregion

        #region constructores
        public PersonaWithListadoDepDTO() { }
	    public PersonaWithListadoDepDTO(Persona persona, List<Departamento> listadoDepartamentos)
        {
            this.persona = persona;
            this.listadoDepartamentos = listadoDepartamentos;
        }
        #endregion
    }
}
