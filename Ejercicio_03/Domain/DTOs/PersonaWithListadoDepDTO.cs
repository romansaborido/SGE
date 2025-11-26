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
        private readonly IDepartamentoRepository _departamentosRepositorio;
        public Persona persona { get; }
        public List<Departamento> listadoDepartamentos { get; }
	    public PersonaWithListadoDepDTO() { }
	    public PersonaWithListadoDepDTO(Persona persona, IDepartamentoRepository departamentosRepositorio)
        {
            _departamentosRepositorio = departamentosRepositorio;
            this.persona = persona;
            this.listadoDepartamentos = _departamentosRepositorio.getDepartamentos();
        }
    }
}
