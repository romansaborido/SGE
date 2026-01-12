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
        public int idDepartamento { get; }
        public List<Departamento> departamentos { get; }
        #endregion

        #region constructores
        public PersonaDepartamentosDTO(int id, string nombre, string apellidos, int idDepartamento, List<Departamento> departamentos)
        {
            this.id = id;
            this.nombre = nombre;
            this.apellidos = apellidos;
            this.idDepartamento = idDepartamento;
            this.departamentos = departamentos;
        }
        #endregion
    }
}
