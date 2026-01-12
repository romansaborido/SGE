using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.DTOs
{
    public class PersonaDepartamentosDTO
    {
        #region propiedades
        public int id { get; }
        public string nombre { get; }
        public string apellidos { get; }
        public List<Departamento> departamentos { get; }
        #endregion

        #region constructores
        public PersonaDepartamentosDTO(string nombre, string apellidos, List<Departamento> departamentos)
        {
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.departamentos = departamentos;
        }
        #endregion
    }
}
