using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.DTOs
{
    public class PersonaWithNombreDepDTO
    {
        public int id { get; }
        public string nombre { get; }
        public string apellidos { get; }
		public string telefono { get; }
		public string direccion { get; }
		public string foto { get; }
		public DateOnly fechaNacimiento { get; }
		public string nombreDepartamento { get; }
		public PersonaWithNombreDepDTO() { }
		public PersonaWithNombreDepDTO(int id, string nombre, string apellidos, string telefono, string direccion, string foto, DateOnly fechaNacimiento, string nombreDepartamento) 
		{
			this.id = id;
			this.nombre = nombre;
			this.apellidos = apellidos;
			this.telefono = telefono;
			this.direccion = direccion;
			this.foto = foto;
			this.fechaNacimiento = fechaNacimiento;
			this.nombreDepartamento = nombreDepartamento;
		}
    }
}
